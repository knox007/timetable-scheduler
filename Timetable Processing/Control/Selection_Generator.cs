using System;
using System.Collections.Generic;
using System.Text;
using Timetable_Scheduler.Model;

namespace Timetable_Processing.Control
{
    class Selection_Generator
    {
        private bool[,] table;
        // = new bool[7, 15]
        //7 days, 15 periods
        public List<Subject_Selection> All_Selections { get; set; }
        private List<Subject_Selection> optimized_selections;
        
        private bool Period_Available(DayOfWeek day, int period)
        {
            return table[(int)day, period];
        }
        private void Set_Period(DayOfWeek day, int period, bool value)
        {
            table[(int)day, period] = value;
        }

        private bool Add_Selection_To_Table(Subject_Selection selection)
        {
            foreach(Lecture_Time time in selection.Times)
                for (int period = time.Start_Period - 1; period < time.End_Period; ++period)
                    if (Period_Available(time.Day, period))
                        return false;
                    else Set_Period(time.Day, period, true);
            
            return true;
        }

        private void Remove_Selection_From_Table(Subject_Selection selection)
        {
            foreach (Lecture_Time time in selection.Times)
                for (int period = time.Start_Period - 1; period < time.End_Period; ++period)
                    Set_Period(time.Day, period, false);
        }

        private void Attempt_Selections()
        {

        }

        public List<Subject_Selection> Get_Optimized_Selections()
        {
            return optimized_selections;
        }
    }
}
