using System.Collections.Generic;
using Dapper.Contrib.Extensions;
using Timetable_Data.Model;
using System.Linq;

namespace Timetable_Data.Control
{
    class Lecture_Hall_Controller : Base_Controller<Lecture_Hall>
    {
        public override bool Delete(Lecture_Hall t)
        {
            return Exists_In_Table("Subject_Selection", "Hall_Id", t.Id)
                ? false : connection.Delete<Lecture_Hall>(t);
        }
    }
}
