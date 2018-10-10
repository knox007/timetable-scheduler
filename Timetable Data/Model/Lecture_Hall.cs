using Dapper;
using Dapper.Contrib.Extensions;

namespace Timetable_Data.Model
{
    [Table("Lecture_Hall")]
    public class Lecture_Hall
    {
        [Key]
        public int Id { get; set; }
        public string Building { get; set; }
        public int Floor { get; set; }
        public string Room { get; set; }
        
        public Lecture_Hall() { }
        public Lecture_Hall(string building, int floor, string room)
        {
            Building = building;
            Floor = floor;
            Room = room;
        }

        public override string ToString()
        {
            return Building + " " + Room;
        }
    }
}
