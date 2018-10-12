using Dapper.Contrib.Extensions;

namespace Timetable_Data.Model
{
    [Table("Selection_Time")]
    class Selection_Time
    {
        public int Id { get; set; }
        public int Selection_Id { get; set; }
        public int Lecture_Time_Id { get; set; }
    }
}
