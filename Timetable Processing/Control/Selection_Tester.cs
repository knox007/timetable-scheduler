using System;
using System.Collections.Generic;
using Timetable_Scheduler.Model;

namespace Timetable_Processing.Control
{
    class Selection_Tester
    {
        public Selection_Tester()
        {
            Selection_Controller controller = new Selection_Controller();
            controller.All_Selections.Add(new Subject_Selection(
                new Subject(1, "Database"),
                new List<Lecturer>() {
                    new Lecturer(1, "Nguyen Van A"),
                    new Lecturer(2, "Nguyen Van B")
                },
                new Lecture_Hall(1, "H9", 2, "202"),
                new List<Lecture_Time>() {
                    new Lecture_Time(DayOfWeek.Monday, 1, 3),
                    new Lecture_Time(DayOfWeek.Wednesday, 1, 3)
                }
            ));

            controller.All_Selections.Add(new Subject_Selection(
                new Subject(1, "Database"),
                new List<Lecturer>() {
                    new Lecturer(1, "Nguyen Van A"),
                    new Lecturer(2, "Nguyen Van B")
                },
                new Lecture_Hall(1, "H9", 2, "202"),
                new List<Lecture_Time>() {
                    new Lecture_Time(DayOfWeek.Monday, 4, 6),
                    new Lecture_Time(DayOfWeek.Wednesday, 4, 5)
                }
            ));

            controller.All_Selections.Add(new Subject_Selection(
                new Subject(2, "Programming Language 2"),
                new List<Lecturer>() {
                    new Lecturer(3, "Nga Van Uyen"),
                    new Lecturer(2, "Nguyen Van B")
                },
                new Lecture_Hall(1, "H9", 2, "202"),
                new List<Lecture_Time>() {
                    new Lecture_Time(DayOfWeek.Tuesday, 3, 5),
                    new Lecture_Time(DayOfWeek.Thursday, 3, 4)
                }
            ));

            controller.Selected_Subjects.Add(new Subject(1, "Database"));
            controller.Selected_Subjects.Add(new Subject(2, "Programming Language 2"));

            foreach (List<int> list in controller.Get_Optimized_Selections())
            {
                foreach (int i in list)
                    Console.Write("{0} ", i);
                Console.WriteLine();
            }
        }
    }
}
