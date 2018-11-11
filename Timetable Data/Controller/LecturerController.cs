using System.Collections.Generic;
using TimetableData.Model;
using Dapper;
using Dapper.Contrib.Extensions;


namespace TimetableData.Controller
{
    public class LecturerController : BaseController<Lecturer>
    {
        public override long Insert(Lecturer t)
        {
            return Exists_In_Table("Lecturer", "Name", t.Name)
                ? GetBy("Lecturer", "Name", t.Name).Id
                : base.Insert(t);
        }

        public override bool Delete(Lecturer t)
        {
            return base.Delete(t) || connection.ExecuteScalar<bool>(
                "DELETE FROM Selection_Lecturer WHERE " +
                "LecturerId = @Id", new { t.Id });

            /*return connection.ExecuteScalar<bool>(
                "DELETE FROM Selection_Lecturer WHERE " +
                "LecturerId = @Id", new { t.Id })
                && base.Delete(t);*/
        }

        public List<Lecturer> GetBySelection(SubjectSelection selection)
        {
            return connection.Query<Lecturer>(
                "SELECT Id, Name FROM Lecturer " +
                "WHERE Id IN " +
                "(SELECT LecturerId FROM Selection_Lecturer " +
                "WHERE SelectionId = @Id)",
                new { selection.Id })
                .AsList();
        }

        public bool DeleteAll()
        {
            return new Selection_LecturerController().DeleteAll()
                && connection.ExecuteScalar<bool>("DELETE FROM Lecturer");
        }
    }
}
