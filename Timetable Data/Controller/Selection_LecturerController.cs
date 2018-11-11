using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimetableData.Model;
using Dapper;

namespace TimetableData.Controller
{
    public class Selection_LecturerController : BaseController<SelectionLecturer>
    {
        public void InsertLecturers(int selection_id, List<int> lecturers_id)
        {
            foreach(int lecturer_id in lecturers_id)
                Insert(new SelectionLecturer()
                {
                    SelectionId = selection_id,
                    LecturerId = lecturer_id
                });
        }

        public List<int> GetBySelection(int selection_id)
        {
            return connection.Query<int>("SELECT LecturerId " +
                "FROM Selection_Lecturer " +
                "WHERE SelectionId = @selection_id", new { selection_id })
                .AsList();
        }

        public bool DeleteBySelection(int selection_id)
        {
            return connection.ExecuteScalar<bool>("DELETE FROM Selection_Lecturer " +
                "WHERE SelectionId = @selection_id", new { selection_id });
        }

        public bool DeleteAll()
        {
            return connection.ExecuteScalar<bool>(
                "DELETE FROM Selection_Lecturer");
        }
    }
}
