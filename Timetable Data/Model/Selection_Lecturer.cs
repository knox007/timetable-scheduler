using Dapper.Contrib.Extensions;
using System.Collections.Generic;
using TimetableData.Controller;

namespace TimetableData.Model
{
    [Table("Selection_Lecturer")]
    public class SelectionLecturer
    {
        public int Id { get; set; }
        public int SelectionId { get; set; }
        public int LecturerId { get; set; }
        
    }
}
