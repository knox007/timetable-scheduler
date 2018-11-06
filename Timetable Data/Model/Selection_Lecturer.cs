using Dapper.Contrib.Extensions;

namespace TimetableData.Model
{
    [Table("Selection_Lecturer")]
    public class Selection_Lecturer
    {
        public int Id { get; set; }
        public int Selection_Id { get; set; }
        public int Lecturer_Id { get; set; }
    }
}
