namespace Timetable_Scheduler.Model
{
    class Subject
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Subject() { }
        public Subject(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public int CompareTo(Subject subject)
        {
            return Id.CompareTo(subject.Id);
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
