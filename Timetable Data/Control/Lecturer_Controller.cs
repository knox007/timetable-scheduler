using System.Collections.Generic;
using System.Linq;
using Timetable_Data.Model;
using Dapper;
using Dapper.Contrib.Extensions;


namespace Timetable_Data.Control
{
    public class Lecturer_Controller : Base_Controller<Lecturer>
    {
        public override long Insert(Lecturer t)
        {
            return Exists_In_Table("Lecturer", "Name", t.Name)
                ? Get_By("Lecturer", "Name", t.Name).Id
                : base.Insert(t);
        }

        public override bool Delete(Lecturer t)
        {
            return Exists_In_Table("Selection_Lecturer", "Lecturer_Id", t.Id.ToString())
                ? false : connection.Delete(t);
        }
    }
}
