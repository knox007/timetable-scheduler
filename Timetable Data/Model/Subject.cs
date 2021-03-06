﻿using Dapper.Contrib.Extensions;
using System.ComponentModel;

namespace TimetableData.Model
{
    [Table("Subject")]
    public class Subject : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public int Id { get; set; }
        public string Name { get; set; }
        public string Codename { get; set; }

        public Subject() { }
        public Subject(string name, string codename)
        {
            Name = name;
            Codename = codename;
        }

        //deep copy constructor
        public Subject(Subject subject)
        {
            Id = subject.Id;
            Name = subject.Name;
            Codename = subject.Codename;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
