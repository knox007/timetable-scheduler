using System;
using System.Collections.Generic;
using System.Linq;
using Timetable_Scheduler.Model;

namespace Timetable_Processing.Control
{
    class Selection_Generator
    {
        private bool[,] table;
        // = new bool[7, 15]
        //7 days, 15 periods
        private List<Subject_Selection> Available_Selections { get; set; }
        private List<List<Subject_Selection>> Grouped_Selections;

        public Selection_Generator(List<Subject_Selection> Available_Selections)
        {
            this.Available_Selections = Available_Selections;
            table = new bool[7, 16];
        }
        
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

        private void Attempt_Selections(ref List<List<int>> result,
            int[] selections, int i)
        {
            if (i == Grouped_Selections.Count)
                result.Add(selections.ToList());
            else
                for (int j = 0; j < Grouped_Selections[i].Count; ++j)
                {
                    if (Add_Selection_To_Table(Grouped_Selections[i][j]))
                    {
                        selections[i] = j;
                        Attempt_Selections(ref result, selections, i + 1);
                    }
                        
                    Remove_Selection_From_Table(Grouped_Selections[i][j]);
                }
                    
        }

        public List<List<int>> Get_Optimized_Selections()
        {
            Grouped_Selections = Available_Selections
                .GroupBy(s => s.Subject.Id)
                .Select(g => g.OrderBy(s => s.Priority).ToList())
                .ToList();

            List<List<int>> result = new List<List<int>>();
            int[] selections = new int[Grouped_Selections.Count];
            Attempt_Selections(ref result, selections, 0);

            return result;
        }
    }
}
