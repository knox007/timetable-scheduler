using Dapper;
using Dapper.Contrib.Extensions;
using System.ComponentModel;

namespace TimetableData.Model
{
    [Table("Lecture_Hall")]
    public class LectureHall : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public int Id { get; set; }
        public string Building { get; set; }
        public int Floor { get; set; }
        public string Room { get; set; }
        
        public LectureHall() { }
        public LectureHall(string building, int floor, string room)
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
