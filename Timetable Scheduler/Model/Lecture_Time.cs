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

        private bool valid_period(int period)
        {
            return (period >= 1 && period <= 12);
        }

        public int Start_period { get => start_period; set => start_period = valid_period(value) ? value : 1; }
        public int End_period { get => end_period; set => end_period = valid_period(value) ? value : 1; }
        public DayOfWeek Day { get; set; }
    }
}
