using Dapper.Contrib.Extensions;

namespace Timetable_Data.Model
{
    [Table("Lecturer")]
    public class Lecturer
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Lecturer() { }
        public Lecturer(int id, string name)
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
