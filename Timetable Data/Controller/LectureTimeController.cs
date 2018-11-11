using TimetableData.Model;
using Dapper;
using Dapper.Contrib.Extensions;
using System.Collections.Generic;

namespace TimetableData.Controller
{
    public class LectureTimeController : BaseController<LectureTime>
    {
        public override long Insert(LectureTime t)
        {
            return Exists_In_Table("LectureTime", "Time", t.Time)
                ? connection.QueryFirst("SELECT Id FROM LectureTime " +
                    "WHERE Time = @Time", new { t.Time }).Id
                : base.Insert(t);
        }

        public override bool Delete(LectureTime t)
        {
            return Exists_In_Table("Selection_Time", "LectureTimeId", t.Id.ToString())
                ? false : connection.Delete(t);
        }

        public List<LectureTime> GetBySelection(SubjectSelection selection)
        {
            return connection.Query<LectureTime>(
                "SELECT Id, Time FROM LectureTime WHERE Id IN " +
                "(SELECT LectureTimeId FROM Selection_Time " +
                "WHERE SelectionId = @Id)",
                new { selection.Id })
                .AsList();
        }
    }
}
