using Dapper.Contrib.Extensions;
using System.ComponentModel;

namespace TimetableData.Model
{
    [Table("Subject")]
    public class Subject
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Codename { get; set; }

        public Subject() { }
        public Subject(string name, string codename)
        {
            Name = name;
            Codename = codename;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
