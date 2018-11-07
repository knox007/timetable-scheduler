using System.Collections.Generic;
using TimetableData.Model;
using Dapper;
using Dapper.Contrib.Extensions;


namespace TimetableData.Control
{
    public class LecturerController : BaseController<Lecturer>
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

        public List<Lecturer> GetBySelection(SubjectSelection selection)
        {
            return connection.Query<Lecturer>("SELECT * FROM Lecturer " +
                "WHERE Lecturer_Id IN " +
                "(SELECT Lecturer_Id FROM Selection_Lecturer " +
                "WHERE Selection_Id = @Selection_Id)",
                new { selection.Id })
                .AsList();
        }
    }
}
