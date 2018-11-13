using System;
using System.Collections.Generic;
using System.Linq;
using Dapper.Contrib.Extensions;
using Dapper;
using TimetableData.Model;

namespace TimetableData.Controller
{
    public class SubjectController : BaseController<Subject>
    {
        public override long Insert(Subject t)
        {
            return Exists_In_Table("[Subject]", "Name", t.Name)
                ? GetBy("[Subject]", "Name", t.Name).Id
                : base.Insert(t);
        }

        public override bool Delete(Subject t)
        {
            return Exists_In_Table("SubjectSelection", "SubjectId", t.Id.ToString())
                ? false
                : connection.Delete(t);
            /*return connection.ExecuteScalar<bool>(
                    "DELETE FROM SubjectSelection " +
                    "WHERE SubjectId = @Id", new { t.Id })
                && connection.Delete(t);*/
        }

        public bool DeleteAll()
        {
            return connection.ExecuteScalar<bool>(
                "DELETE FROM [Subject]"
            );
        }
    }
}
