using System.Collections.Generic;
using Dapper.Contrib.Extensions;
using TimetableData.Model;
using System.Linq;

namespace TimetableData.Control
{
    public class LectureHallController : Base_Controller<LectureHall>
    {
        public override bool Delete(LectureHall t)
        {
            return Exists_In_Table("Subject_Selection", "Hall_Id", t.Id.ToString())
                ? false : connection.Delete<LectureHall>(t);
        }
    }
}
