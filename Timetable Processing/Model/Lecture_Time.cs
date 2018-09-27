using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Timetable_Scheduler.Model
{
    class Lecture_Time
    {
        private int start_period, end_period;

        private bool Valid_Period(int period)
        {
            return (period >= 1 && period <= 15);
        }

        private bool In_Range(int period)
        {
            return start_period < period && period < end_period;
        }
        public bool Intersect(Lecture_Time time)
        {
            return In_Range(time.start_period) || In_Range(time.end_period);
        }

        public int Start_Period { get => start_period; set => start_period = Valid_Period(value) ? value : 1; }
        public int End_Period { get => end_period; set => end_period = Valid_Period(value) ? value : 1; }
        public DayOfWeek Day { get; set; }
    }
}
