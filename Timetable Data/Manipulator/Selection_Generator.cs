using System;
using System.Collections.Generic;
using System.Linq;
using TimetableData.Model;

namespace TimetableData.Control
{
    class Selection_Generator
    {
        private int[,] table;
        // = new int[16, 7]
        //16 periods each day in week
        public List<Subject_Selection> Available_Selections { get; set; }
        private List<int> Preferred_Selections_Id;
        private List<List<Subject_Selection>> Grouped_Selections, Optimized_Selections;

        public Selection_Generator()
        {
            Preferred_Selections_Id = new List<int>();
            Optimized_Selections = new List<List<Subject_Selection>>();
            table = new int[16, 7];
        }
        public Selection_Generator(List<Subject_Selection> Available_Selections)
            : this()
        {
            this.Available_Selections = Available_Selections;
        }
        
        public bool Add_Preferred_Selection(Subject_Selection selection)
        {
            if(Add_Selection_To_Table(selection))
            {
                Preferred_Selections_Id.Add(selection.Id);
                return true;
            }

            return false;
        }

        public void Remove_Preferred_Selection(Subject_Selection selection)
        {
            Preferred_Selections_Id.Remove(selection.Id);
            Remove_Selection_From_Table(selection);
        }

        private bool Period_Used(int period, DayOfWeek day)
        {
            return table[(int)day, period] > 0;
        }
        private void Set_Period(int period, DayOfWeek day, int subject_id)
        {
            table[(int)day, period] = subject_id;
        }

        private bool Add_Selection_To_Table(Subject_Selection selection)
        {
            foreach(Lecture_Time time in selection.Times)
                for (int period = time.Start_Period; period <= time.End_Period; ++period)
                    if (Period_Used(period, time.Day))
                        return false;
                    else Set_Period(period, time.Day, selection.Subject_Id);
            
            return true;
        }

        private void Remove_Selection_From_Table(Subject_Selection selection)
        {
            foreach (Lecture_Time time in selection.Times)
                for (int period = time.Start_Period - 1; period < time.End_Period; ++period)
                    if (table[(int)time.Day, period] == selection.Subject_Id)
                        Set_Period(period, time.Day, 0);
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

            for (int i = 0; i < Grouped_Selections.Count; ++i)
                if ((Grouped_Selections[i].Count > 0) //exists at least one
                    && (Preferred_Selections_Id.Exists(Id =>
                        Id == Grouped_Selections[i][0].Subject_Id)))
                    Grouped_Selections.RemoveAt(i--);

            int[] selections = new int[Grouped_Selections.Count];
            Attempt_Selections(selections, 0);

            return Optimized_Selections;
        }
    }
}
