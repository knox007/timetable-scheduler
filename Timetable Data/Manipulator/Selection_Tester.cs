using System;
using System.Collections.Generic;
using Timetable_Data.Model;

namespace Timetable_Processing.Control
{
    class Selection_Tester
    {
        public Selection_Tester()
        {
            Selection_Manipulator m = new Selection_Manipulator();
            m.All_Selections.Add(new Subject_Selection(
                new Subject(1, "Database"),
                new List<Lecturer>() {
                    new Lecturer(1, "Nguyen Van A"),
                    new Lecturer(2, "Nguyen Van B")
                },
                new Lecture_Hall(1, "H9", 2, "202"),
                new List<Lecture_Time>() {
                    new Lecture_Time(1, DayOfWeek.Monday, 1, 3),
                    new Lecture_Time(2, DayOfWeek.Wednesday, 1, 3)
                }
            ));

            m.All_Selections.Add(new Subject_Selection(
                new Subject(1, "Database"),
                new List<Lecturer>() {
                    new Lecturer(1, "Nguyen Van A"),
                    new Lecturer(2, "Nguyen Van B")
                },
                new Lecture_Hall(1, "H9", 2, "202"),
                new List<Lecture_Time>() {
                    new Lecture_Time(1, DayOfWeek.Monday, 4, 6),
                    new Lecture_Time(2, DayOfWeek.Wednesday, 4, 5)
                }
            ));

            m.All_Selections.Add(new Subject_Selection(
                new Subject(2, "Programming Language 2"),
                new List<Lecturer>() {
                    new Lecturer(3, "Nga Van Uyen"),
                    new Lecturer(2, "Nguyen Van B")
                },
                new Lecture_Hall(1, "H9", 2, "202"),
                new List<Lecture_Time>() {
                    new Lecture_Time(1, DayOfWeek.Tuesday, 3, 5),
                    new Lecture_Time(2, DayOfWeek.Thursday, 3, 4)
                }
            ));

            m.Selected_Subjects.Add(new Subject(1, "Database"));
            m.Selected_Subjects.Add(new Subject(2, "Programming Language 2"));

            foreach (List<Subject_Selection> list in m.Get_Optimized_Selections())
            {
                foreach (Subject_Selection selection in list)
                    Console.WriteLine("{0}", selection.ToString());
                Console.WriteLine();
            }
        }
    }
}
