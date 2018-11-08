using Dapper.Contrib.Extensions;
using System.Collections.Generic;
using TimetableData.Controller;

namespace TimetableData.Model
{
    [Table("SelectionLecturer")]
    public class SelectionLecturer
    {
        public int Id { get; set; }
        public int Selection_Id { get; set; }
        public int Lecturer_Id { get; set; }
        
    }
}
