using Dapper;
using Dapper.Contrib.Extensions;
using System.ComponentModel;

namespace TimetableData.Model
{
    [Table("LectureHall")]
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
        public LectureHall(LectureHall hall)
        { //deep copy
            Id = hall.Id;
            Building = hall.Building;
            Floor = hall.Floor;
            Room = hall.Room;
        }

        public override string ToString()
        {
            return Building + " " + Room;
        }
    }
}
