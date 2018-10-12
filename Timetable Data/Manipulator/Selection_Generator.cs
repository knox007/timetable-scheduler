using System;
using System.Collections.Generic;
using System.Linq;
using Timetable_Data.Model;

namespace Timetable_Data.Control
{
    class Selection_Generator
    {
        private int[,] table;
        // = new bool[7, 17]
        //7 days of a week, 15 periods
        public List<Subject_Selection> Available_Selections { get; set; }
        public List<Subject_Selection> Preferred_Selections { get; set; }
        private List<List<Subject_Selection>> Grouped_Selections, Optimized_Selections;

        public Selection_Generator()
        {
            Optimized_Selections = new List<List<Subject_Selection>>();
            table = new int[7, 17];
        }
        public Selection_Generator(List<Subject_Selection> Available_Selections)
            : this()
        {
            this.Available_Selections = Available_Selections;
        }
        
        public bool Add_To_Preferred_Selections(Subject_Selection selection)
        {
            if(Add_Selection_To_Table(selection))
            {
                return true;
            }
            return false;
        }

        private bool Period_Used(DayOfWeek day, int period)
        {
            return table[(int)day, period] > 0;
        }
        private void Set_Period(DayOfWeek day, int period, int subject_id)
        {
            table[(int)day, period] = subject_id;
        }

        private bool Add_Selection_To_Table(Subject_Selection selection)
        {
            foreach(Lecture_Time time in selection.Times)
                for (int period = time.Start_Period; period <= time.End_Period; ++period)
                    if (Period_Used(time.Day, period))
                        return false;
                    else Set_Period(time.Day, period, selection.Subject_Id);
            
            return true;
        }

        private void Remove_Selection_From_Table(Subject_Selection selection)
        {
            foreach (Lecture_Time time in selection.Times)
                for (int period = time.Start_Period - 1; period < time.End_Period; ++period)
                    if (table[(int)time.Day, period] == selection.Subject_Id)
                        Set_Period(time.Day, period, 0);
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
