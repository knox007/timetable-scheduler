using Dapper.Contrib.Extensions;

namespace TimetableData.Model
{
    [Table("Selection_Time")]
    public class Selection_Time
    {
        public int Id { get; set; }
        public int SelectionId { get; set; }
        public int LectureTimeId { get; set; }
    }
}
