using Timetable_Data.Model;
using Dapper;
using Dapper.Contrib.Extensions;

namespace Timetable_Data.Control
{
    class Lecture_Time_Controller : Base_Controller<Lecture_Time>
    {
        public override long Insert(Lecture_Time t)
        {
            return Exists_In_Table("Lecture_Time", "Time", t.Time)
                ? connection.QueryFirst("SELECT Id FROM Lecture_Time" +
                    "WHERE Time = @Time", new { t.Time }).Id
                : base.Insert(t);
        }

        public override bool Delete(Lecture_Time t)
        {
            return Exists_In_Table("Selection_Time", "Lecture_Time_Id", t.Id.ToString())
                ? false : connection.Delete(t);
        }
    }
}
