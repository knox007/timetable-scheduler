using Timetable_Data.Model;
using Dapper;
using Dapper.Contrib.Extensions;

namespace Timetable_Data.Control
{
    class Lecture_Time_Controller : Base_Controller<Lecture_Time>
    {
        public override bool Delete(Lecture_Time t)
        {
            return Exists_In_Table("Selection_Time", "Lecture_Time_Id", t.Id)
                ? false : connection.Delete<Lecture_Time>(t);
        }
    }
}
