using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Timetable_Scheduler.Model
{
    class Subject_Selection
    {
        public int Id { get; set; }
        public Subject Subject { get; set; }
        public List<Lecturer> Lecturers { get; set; }
        public Lecture_Hall Hall { get; set; }
        public List<Lecture_Time> Times { get; set; }
        public int Priority { get; set; }

        public Subject_Selection() { }
        
        public Subject_Selection(Subject subject, List<Lecturer> lecturers,
            Lecture_Hall hall, List<Lecture_Time> times, int priority = 0)
        {
            Subject = subject;
            Lecturers = lecturers;
            Hall = hall;
            Times = times;
            Priority = priority;
        }


        public static string ListToString<T>(List<T> list)
        {
            string result = "[";
            for (int i = 0; i < list.Count - 1; ++i)
                result += list[i].ToString() + ", ";
            result += list[list.Count - 1] + "]";
            return result;
        }

        public override string ToString()
        {
            return string.Format("{0}, {1}, {2}, {3}, {4}",
                Subject, ListToString(Lecturers), Hall.ToString(),
                ListToString(Times), Priority.ToString()).ToString();
        }
    }
}
