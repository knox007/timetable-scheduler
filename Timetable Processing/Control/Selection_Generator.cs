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
        private List<List<Subject_Selection>> Grouped_Selections, Optimized_Selections;

        public Selection_Generator(List<Subject_Selection> Available_Selections)
        {
            this.Available_Selections = Available_Selections;
            Optimized_Selections = new List<List<Subject_Selection>>();
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

        private List<Subject_Selection> Int_Array_To_Selection_List(int[] selections)
        {
            List<Subject_Selection> result = new List<Subject_Selection>();
            for (int i = 0; i < selections.Length; ++i)
                result.Add(Grouped_Selections[i][selections[i]]);
            return result;
        }

        private void Attempt_Selections(int[] selections, int i)
        {
            if (i == Grouped_Selections.Count)
                Optimized_Selections.Add(Int_Array_To_Selection_List(selections));
            else
                for (int j = 0; j < Grouped_Selections[i].Count; ++j)
                {
                    if (Add_Selection_To_Table(Grouped_Selections[i][j]))
                    {
                        selections[i] = j;
                        Attempt_Selections(selections, i + 1);
                    }
                        
                    Remove_Selection_From_Table(Grouped_Selections[i][j]);
                }
                    
        }

        public List<List<Subject_Selection>> Get_Optimized_Selections()
        {
            Grouped_Selections = Available_Selections
                .GroupBy(s => s.Subject.Id)
                .Select(g => g.OrderBy(s => s.Priority).ToList())
                .ToList();

            int[] selections = new int[Grouped_Selections.Count];
            Attempt_Selections(selections, 0);

            return Optimized_Selections;
        }
    }
}
