using System.Collections.Generic;
using Dapper.Contrib.Extensions;

namespace TimetableData.Model
{
    [Table("Subject_Selection")]
    public class Subject_Selection
    {
        public int Id { get; set; }
        public int Subject_Id { get; set; }
        public int Hall_Id { get; set; }

        [Computed]
        public Subject Subject { get; set; }
        [Computed]
        public List<Lecturer> Lecturers { get; set; }
        [Computed]
        public LectureHall Hall { get; set; }
        [Computed]
        public List<Lecture_Time> Times { get; set; }
        [Computed]
        public int Priority { get; set; }

        public Subject_Selection() : this(new Subject(), new List<Lecturer>(),
            new LectureHall(), new List<Lecture_Time>()) {}
        
        public Subject_Selection(int subject_id, int hall_id)
        {
            Subject_Id = subject_id;
            Hall_Id = hall_id;
        }

        public Subject_Selection(Subject subject, List<Lecturer> lecturers,
            LectureHall hall, List<Lecture_Time> times, int priority = 0)
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
            if(list.Count > 0)
            {
                for (int i = 0; i < list.Count - 1; ++i)
                    result += list[i].ToString() + ", ";
                result += list[list.Count - 1];
            }
            result += "]";

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
