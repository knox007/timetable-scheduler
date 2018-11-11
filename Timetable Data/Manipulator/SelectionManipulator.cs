using System;
using System.Collections.Generic;
using System.Text;
using TimetableData.Model;

namespace TimetableData.Manipulator
{
    public class SelectionManipulator
    {
        public List<SubjectSelection> AllSelections { get; set; }
        private List<SubjectSelection> AvailableSelecions { get; set; }

        public List<Subject> Selected_Subjects { get; set; }
        public List<Lecturer> Preferred_Lecturers { get; set; }
        public List<Lecturer> Denied_Lecturers { get; set; }
        public List<LectureTime> Preferred_Lecture_Times { get; set; }
        public List<LectureTime> Denied_Lecture_Times { get; set; }
        public bool Halls_Height_Preference { get; set; }

        private SelectionGenerator Generator { get; set; }

        public SelectionManipulator()
        {
            AllSelections = new List<SubjectSelection>();
            AvailableSelecions = new List<SubjectSelection>();

            Selected_Subjects = new List<Subject>();
            Preferred_Lecturers = new List<Lecturer>();
            Denied_Lecturers = new List<Lecturer>();
            Preferred_Lecture_Times = new List<LectureTime>();
            Denied_Lecture_Times = new List<LectureTime>();
            Halls_Height_Preference = false;

            Generator = new SelectionGenerator();
        }

        private void SetPriorityByHallsHeightPreference()
        {
            if (!Halls_Height_Preference) //== false
                return;

            int max_height = -1;
            foreach (SubjectSelection selection in AllSelections)
                max_height = (max_height > selection.Hall.Floor) ?
                    max_height : selection.Hall.Floor;

            foreach (SubjectSelection selection in AllSelections)
                if (selection.Priority > 0)
                    selection.Priority += max_height - selection.Hall.Floor;
        }

        private void SetPriorityByLectureTimes()
        {
            foreach (SubjectSelection selection in AllSelections)
                foreach (LectureTime time in selection.Times)
                {
                    foreach (LectureTime denied_time in Denied_Lecture_Times)
                        if (time.Intersect(denied_time))
                            selection.Priority = 0;
                    foreach (LectureTime preferred_time in Preferred_Lecture_Times)
                        if (time.Intersect(preferred_time) && selection.Priority > 0)
                            selection.Priority += 5;
                }
        }

        private void SetPriorityByLecturers()
        {
            foreach (SubjectSelection selection in AllSelections)
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

        private void SetPriorityBySubject()
        {
            foreach (SubjectSelection selection in AllSelections)
                if (!Selected_Subjects.Exists(subject => subject.Id == selection.Subject.Id))
                    selection.Priority = 0;
                else
                    selection.Priority += 1;
        }

        private void CalculatePriority()
        {
            AllSelections.ForEach(subject => subject.Priority = 0);

            SetPriorityBySubject();
            SetPriorityByLecturers();
            SetPriorityByLectureTimes();
            SetPriorityByHallsHeightPreference();

            AvailableSelecions.Clear();
            AllSelections.ForEach(subject => {
                if (subject.Priority > 0) AvailableSelecions.Add(subject);
            });
            //AllSelections.Sort()
        }

        public bool Add_Preferred_Selection(SubjectSelection selection)
        {
            return Generator.Add_Preferred_Selection(selection);
        }

        public void Remove_Preferred_Selection(SubjectSelection selection)
        {
            Generator.Remove_Preferred_Selection(selection);
        }

        public List<List<SubjectSelection>> GetOptimizedSelections()
        {
            CalculatePriority();
            Generator.AvailableSelections = AvailableSelecions;
            return Generator.Get_Optimized_Selections();
        }
    }
}
