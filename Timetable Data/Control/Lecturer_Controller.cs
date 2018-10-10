using System.Collections.Generic;
using System.Linq;
using Timetable_Data.Model;
using Dapper;
using Dapper.Contrib.Extensions;


namespace Timetable_Data.Control
{
    class Lecturer_Controller : Base_Controller<Lecturer>
    {
        public override bool Delete(Lecturer t)
        {
            return Exists_In_Table("Selection_Lecturer", "Lecturer_Id", t.Id)
                ? false : connection.Delete<Lecturer>(t);
        }
    }
}
