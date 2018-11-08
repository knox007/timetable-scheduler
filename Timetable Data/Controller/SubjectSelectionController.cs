using System.Collections.Generic;
using Dapper.Contrib.Extensions;
using Dapper;
using System.Linq;
using TimetableData.Model;

namespace TimetableData.Controller
{
    public class SubjectSelectionController : BaseController<SubjectSelection>
    {
        public override bool Delete(SubjectSelection t)
        {
            return (Exists_In_Table("SelectionLecturer", "SelectionId", t.Id.ToString())
                || Exists_In_Table("SelectionTime", "SelectionId", t.Id.ToString()))
                ? false : Delete(t);
        }

        public bool AddLecturer(ref SubjectSelection ss, Lecturer l)
        {
            return connection.Insert<SelectionLecturer>(
                new SelectionLecturer()
                    { Lecturer_Id = l.Id, Selection_Id = ss.Id }
            ) > 0; //insert success
        }

        public bool AddTime(ref SubjectSelection ss, LectureTime lt)
        {
            return connection.Insert<Selection_Time>(
                new Selection_Time()
                { Lecture_Time_Id = lt.Id, Selection_Id = ss.Id }
            ) > 0; //insert success
        }

        public bool RemoveLecturer(ref SubjectSelection ss, Lecturer l)
        {
            return connection.Delete<SelectionLecturer>(
                new SelectionLecturer()
                    { Lecturer_Id = l.Id, Selection_Id = ss.Id }
            ); //insert success
        }

        public bool RemoveTime(ref SubjectSelection selection, LectureTime time)
        {
            throw new System.Exception("Not implementated");
        }
    }
}
