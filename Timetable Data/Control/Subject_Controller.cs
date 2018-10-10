using System;
using System.Collections.Generic;
using System.Linq;
using Dapper.Contrib.Extensions;
using Dapper;
using Timetable_Data.Model;

namespace Timetable_Data.Control
{
    class Subject_Controller : Base_Controller<Subject>
    {
        public override bool Delete(Subject t)
        {
            return Exists_In_Table("Subject_Selection", "Subject_Id", t.Id)
                ? false : connection.Delete<Subject>(t);
        }
    }
}
