using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimetableData.Model;
using Dapper;

namespace TimetableData.Control
{
    class Selection_TimeController : BaseController<Selection_Time>
    {
        public override bool Delete(Selection_Time t)
        {
            return connection.ExecuteScalar<Boolean>(
                "DELETE FROM Selection_Time " +
                "WHERE Lecturer_Time_Id = @Lecture_Time_Id " +
                "AND Selection_Id = @Selection_Id",
                new { t.Lecture_Time_Id, t.Selection_Id });
        }
    }
}
