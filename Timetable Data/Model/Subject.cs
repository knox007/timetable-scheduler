namespace Timetable_Data.Model
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
        
        public override string ToString()
        {
            return Name;
        }
    }
}
