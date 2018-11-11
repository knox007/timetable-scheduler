using Dapper.Contrib.Extensions;
using System.Collections.Generic;
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

        public Lecturer(Lecturer lecturer)
        {
            Id = lecturer.Id;
            Name = lecturer.Name;
        }

        public override string ToString()
        {
            return Name;
        }

        public static string LecturersToString(List<Lecturer> lecturers)
        {
            if (lecturers.Count == 0) return "";

            string result = "";

            for (int i = 0; i < lecturers.Count - 1; ++i)
                result += lecturers[i] + System.Environment.NewLine;
            result += lecturers[lecturers.Count - 1];

            return result;
        }
    }
}
