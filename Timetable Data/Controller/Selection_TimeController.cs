using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimetableData.Model;
using Dapper;

namespace TimetableData.Controller
{
    public class Selection_TimeController : BaseController<Selection_Time>
    {
        public void InsertTimes(int selection_id, List<LectureTime> times)
        {
            int time_id;
            LectureTimeController time_controller = new LectureTimeController();

            foreach (LectureTime time in times)
            {
                time_id = (int)time_controller.Insert(time);
                Insert(new Selection_Time()
                {
                    SelectionId = selection_id,
                    LectureTimeId = time_id
                });
            }
        }

        public bool DeleteBySelection(int selection_id)
        {
            return connection.ExecuteScalar<bool>("DELETE FROM Selection_Time " +
                "WHERE SelectionId = @selection_id", new { selection_id });
        }

        public bool DeleteAll()
        {
            return connection.ExecuteScalar<bool>(
                "DELETE FROM Selection_Time");
        }
    }
}
