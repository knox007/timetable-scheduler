using Dapper.Contrib.Extensions;

namespace Timetable_Data.Model
{
    [Table("Selection_Lecturer")]
    class Selection_Lecturer
    {
        public int Id { get; set; }
        public int Selection_Id { get; set; }
        public int Lecturer_Id { get; set; }
    }
}
