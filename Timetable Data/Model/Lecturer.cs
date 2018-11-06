using Dapper.Contrib.Extensions;
using System.ComponentModel;

namespace TimetableData.Model
{
    [Table("Lecturer")]
    public class Lecturer : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public int Id { get; set; }
        public string Name { get; set; }

        public Lecturer() { }
        public Lecturer(string name)
        {
            Name = name;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
