using System;
using System.Collections.Generic;
using System.Linq;
using Dapper.Contrib.Extensions;
using Dapper;
using TimetableData.Model;

namespace TimetableData.Control
{
    public class SubjectController : BaseController<Subject>
    {
        public override long Insert(Subject t)
        {
            return Exists_In_Table("[Subject]", "Name", t.Name)
                ? Get_By("[Subject]", "Name", t.Name).Id
                : base.Insert(t);
        }

        public override bool Delete(Subject t)
        {
            return Exists_In_Table("Subject_Selection", "Subject_Id", t.Id.ToString())
                ? false
                : connection.Delete(t);
        }
    }
}
