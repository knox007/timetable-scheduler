using Dapper.Contrib.Extensions;

namespace Timetable_Data.Model
{
    [Table("Subject")]
    class Subject
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Subject() { }
        public Subject(int id, string name)
        {
            Name = name;
        }
        
        public override string ToString()
        {
            return Name;
        }
    }
}
