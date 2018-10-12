﻿using System.Collections.Generic;
using Dapper.Contrib.Extensions;
using Dapper;
using System.Linq;
using Timetable_Data.Model;

namespace Timetable_Data.Control
{
    class Subject_Selection_Controller : Base_Controller<Subject_Selection>
    {
        public override bool Delete(Subject_Selection t)
        {
            return (Exists_In_Table("Selection_Lecturer", "Selection_Id", t.Id)
                || Exists_In_Table("Selection_Time", "Selection_Id", t.Id))
                ? false : Delete(t);
        }

        public override Subject_Selection Get(int Id)
        {
            Subject_Selection ss = base.Get(Id);
            ss.Hall = new Lecture_Hall_Controller().Get(ss.Hall_Id);
            ss.Subject = new Subject_Controller().Get(ss.Subject_Id);

            foreach (var row in connection.Query("SELECT Lecturer_Id FROM Selection_Lecturer " +
                "WHERE Selection_Id = @Id", new { Id }).ToList())
                ss.Lecturers.Add((new Lecturer_Controller().Get(row.Lecturer_Id)));
            
            foreach (var row in connection.Query("SELECT Lecture_Time_Id FROM Selection_Time " +
                "WHERE Selection_Id = @Id", new { Id }).ToList())
                ss.Times.Add(new Lecture_Time_Controller().Get(row.Time_Id));

            return ss;
        }

        public override List<Subject_Selection> Get_All()
        {
            List<Subject_Selection> lss = new List<Subject_Selection>();
            foreach (var row in connection.Query("SELECT Id FROM Subject_Selection_Id)").ToList())
                lss.Add(Get(row.Id));
            return lss;
        }

        public bool Add_Lecturer(ref Subject_Selection ss, Lecturer l)
        {
            
        }
    }
}
