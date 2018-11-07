using System.Collections.Generic;
using Dapper.Contrib.Extensions;
using Dapper;
using TimetableData.Model;
using System.Linq;

namespace TimetableData.Control
{
    public class LectureHallController : BaseController<LectureHall>
    {
        public override bool Delete(LectureHall t)
        {
            return Exists_In_Table("Subject_Selection", "Hall_Id", t.Id.ToString())
                ? false : connection.Delete<LectureHall>(t);
        }

        public LectureHall GetBySelection(SubjectSelection selection)
        {
            return connection.QueryFirst<LectureHall>(
                "SELECT * FROM Lecture_Hall WHERE Id = @Id",
                new { selection.HallId });
        }
    }
}
