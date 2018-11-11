using System.Collections.Generic;
using Dapper.Contrib.Extensions;
using Dapper;
using TimetableData.Model;
using System.Linq;

namespace TimetableData.Controller
{
    public class LectureHallController : BaseController<LectureHall>
    {
        public override bool Delete(LectureHall t)
        {
            return Exists_In_Table("SubjectSelection", "HallId", t.Id.ToString())
                ? false : connection.Delete<LectureHall>(t);
        }

        public LectureHall GetBySelection(SubjectSelection selection)
        {
            return connection.QueryFirst<LectureHall>(
                "SELECT * FROM LectureHall WHERE Id = @Id",
                new { selection.HallId });
        }

        public bool DeleteAll()
        {
            return new SubjectSelectionController().DeleteAll()
                && connection.ExecuteScalar<bool>("DELETE FROM LectureHall");
        }
    }
}
