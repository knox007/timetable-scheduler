namespace Timetable_Data.Model
{
    class Lecture_Hall
    {
        public int Id { get; set; }
        public string Building { get; set; }
        public int Floor { get; set; }
        public string Room { get; set; }
        
        public Lecture_Hall() { }
        public Lecture_Hall(int id, string building, int floor, string room)
        {
            Id = id;
            Building = building;
            Floor = floor;
            Room = room;
        }

        public static implicit operator Control.Lecture_Hall(Lecture_Hall hall)
        {
            return new Control.Lecture_Hall()
            {
                Id = hall.Id,
                Building = hall.Building,
                Floor = hall.Floor,
                Room = hall.Room
            };
        }

        public static implicit operator Lecture_Hall(Control.Lecture_Hall hall)
        {
            return new Lecture_Hall()
            {
                Id = hall.Id,
                Building = hall.Building,
                Floor = hall.Floor.GetValueOrDefault(),
                Room = hall.Room
            };
        }

        public override string ToString()
        {
            return Building + " " + Room;
        }
    }
}
