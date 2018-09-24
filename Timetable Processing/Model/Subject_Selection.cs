using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Timetable_Scheduler.Model
{
    class Subject_Selection
    {
        public Subject Subject { get; set; }
        public List<Lecturer> Lecturers { get; set; }
        public Lecture_Hall Hall { get; set; }
        public List<Lecture_Time> Times { get; set; }
        public int Priority { get; set; }
    }
}
