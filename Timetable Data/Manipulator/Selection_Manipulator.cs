using System;
using System.Collections.Generic;
using System.Text;
using Timetable_Data.Model;

namespace Timetable_Data.Control
{
    class Selection_Manipulator
    {
        public List<Subject_Selection> All_Selections { get; set; }
        private List<Subject_Selection> Available_Selecions { get; set; }

        public List<Subject> Selected_Subjects { get; set; }
        public List<Lecturer> Preferred_Lecturers { get; set; }
        public List<Lecturer> Denied_Lecturers { get; set; }
        public List<Lecture_Time> Preferred_Lecture_Times { get; set; }
        public List<Lecture_Time> Denied_Lecture_Times { get; set; }
        public bool Halls_Height_Preference { get; set; }

        private Selection_Generator Generator { get; set; }

        public Selection_Manipulator()
        {
            All_Selections = new List<Subject_Selection>();
            Available_Selecions = new List<Subject_Selection>();

            Selected_Subjects = new List<Subject>();
            Preferred_Lecturers = new List<Lecturer>();
            Denied_Lecturers = new List<Lecturer>();
            Preferred_Lecture_Times = new List<Lecture_Time>();
            Denied_Lecture_Times = new List<Lecture_Time>();
            Halls_Height_Preference = false;

            Generator = new Selection_Generator();
        }

        private void Set_Priority_By_Halls_Height_Preference()
        {
            if (!Halls_Height_Preference) //== false
                return;

            int max_height = -1;
            foreach (Subject_Selection selection in All_Selections)
                max_height = (max_height > selection.Hall.Floor) ?
                    max_height : selection.Hall.Floor;

            foreach (Subject_Selection selection in All_Selections)
                if (selection.Priority > 0)
                    selection.Priority += max_height - selection.Hall.Floor;
        }

        private void Set_Priority_By_Lecture_Times()
        {
            foreach (Subject_Selection selection in All_Selections)
                foreach (Lecture_Time time in selection.Times)
                {
                    foreach (Lecture_Time denied_time in Denied_Lecture_Times)
                        if (time.Intersect(denied_time))
                            selection.Priority = 0;
                    foreach (Lecture_Time preferred_time in Preferred_Lecture_Times)
                        if (time.Intersect(preferred_time) && selection.Priority > 0)
                            selection.Priority += 5;
                }
        }

        private void Set_Priority_By_Lecturers()
        {
            foreach (Subject_Selection selection in All_Selections)
                foreach (Lecturer lecturer in selection.Lecturers)
                {
                    foreach (Lecturer denied_lecturer in Denied_Lecturers)
                        if (lecturer == denied_lecturer)
                            selection.Priority = 0;
                    foreach (Lecturer preferred_lecturer in Preferred_Lecturers)
                        if (lecturer == preferred_lecturer)
                            selection.Priority = 0;
                }
        }

        private void Set_Priority_By_Subject()
        {
            foreach (Subject_Selection selection in All_Selections)
                if (!Selected_Subjects.Exists(subject => subject.Id == selection.Subject.Id))
                    selection.Priority = 0;
                else
                    selection.Priority += 1;
        }

        private void Calculate_Priority()
        {
            All_Selections.ForEach(subject => subject.Priority = 0);

            Set_Priority_By_Subject();
            Set_Priority_By_Lecturers();
            Set_Priority_By_Lecture_Times();
            Set_Priority_By_Halls_Height_Preference();

            Available_Selecions.Clear();
            All_Selections.ForEach(subject => {
                if (subject.Priority > 0) Available_Selecions.Add(subject);
            });
        }

        public bool Add_Preferred_Selection(Subject_Selection selection)
        {
            return Generator.Add_Preferred_Selection(selection);
        }

        public void Remove_Preferred_Selection(Subject_Selection selection)
        {
            Generator.Remove_Preferred_Selection(selection);
        }

        public List<List<Subject_Selection>> Get_Optimized_Selections()
        {
            Calculate_Priority();
            Generator.Available_Selections = Available_Selecions;
            return Generator.Get_Optimized_Selections();
        }
    }
}
