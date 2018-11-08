using TimetableData.Model;
using Dapper;
using Dapper.Contrib.Extensions;
using System.Collections.Generic;

namespace TimetableData.Controller
{
    class Lecture_Time_Controller : BaseController<LectureTime>
    {
        public override long Insert(LectureTime t)
        {
            return Exists_In_Table("Lecture_Time", "Time", t.Time)
                ? connection.QueryFirst("SELECT Id FROM Lecture_Time" +
                    "WHERE Time = @Time", new { t.Time }).Id
                : base.Insert(t);
        }

        public override bool Delete(LectureTime t)
        {
            return Exists_In_Table("Selection_Time", "Lecture_Time_Id", t.Id.ToString())
                ? false : connection.Delete(t);
        }

        public List<LectureTime> GetBySelection(SubjectSelection selection)
        {
            return connection.Query<LectureTime>(
                "SELECT * FROM Lecture_Time WHERE Id IN " +
                "(SELECT Lecture_Time_Id FROM Selection_Time " +
                "WHERE Selection_Id = @Selection_Id)",
                new { selection.Id })
                .AsList();
        }
    }
}
