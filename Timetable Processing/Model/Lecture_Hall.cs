namespace Timetable_Scheduler.Model
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

        public override string ToString()
        {
            return Building + " " + Room;
        }
    }
}
