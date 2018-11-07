using System.Collections.Generic;
using Dapper.Contrib.Extensions;
using TimetableData.Control;

namespace TimetableData.Model
{
    [Table("Subject_Selection")]
    public class SubjectSelection
    {
        public int Id { get; set; }
        public int SubjectId { get; set; }
        public int HallId { get; set; }

        [Computed]
        public Subject Subject
        {
            get
            {
                return new SubjectController().Get(SubjectId);
            }
        }

        [Computed]
        public LectureHall Hall
        {
            get
            {
                return new LectureHallController().Get(HallId);
            }
        }

        [Computed]
        public List<Lecturer> Lecturers
        {
            get
            {
                return new LecturerController().GetBySelection(this);
            }
        }

        [Computed]
        public List<LectureTime> Times
        {
            get
            {
                return new Lecture_Time_Controller().GetBySelection(this);
            }
        }

        [Computed]
        public int Priority { get; set; }

        public SubjectSelection()
        {
        }
        
        public SubjectSelection(int subject_id, int hall_id)
        {
            SubjectId = subject_id;
            HallId = hall_id;
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
                Subject, ListToString(Lecturers), Hall,
                ListToString(Times), Priority.ToString());
        }
    }
}
