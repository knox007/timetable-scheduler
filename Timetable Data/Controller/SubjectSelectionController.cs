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
            new Selection_LecturerController().DeleteBySelection(t.Id);
            new Selection_TimeController().DeleteBySelection(t.Id);
            return base.Delete(t);
        }

        public bool AddLecturer(ref SubjectSelection ss, Lecturer l)
        {
            return connection.Insert<SelectionLecturer>(
                new SelectionLecturer()
                    { LecturerId = l.Id, SelectionId = ss.Id }
            ) > 0; //insert success
        }

        public bool AddTime(ref SubjectSelection ss, LectureTime lt)
        {
            return connection.Insert<Selection_Time>(
                new Selection_Time()
                { LectureTimeId = lt.Id, SelectionId = ss.Id }
            ) > 0; //insert success
        }

        public bool RemoveLecturer(ref SubjectSelection ss, Lecturer l)
        {
            return connection.Delete<SelectionLecturer>(
                new SelectionLecturer()
                    { LecturerId = l.Id, SelectionId = ss.Id }
            ); //insert success
        }

        public bool RemoveTime(ref SubjectSelection selection, LectureTime time)
        {
            throw new System.Exception("Not implementated");
        }

        public bool DeleteAll()
        {
            return new Selection_TimeController().DeleteAll() //Foreign keys?
                && new Selection_LecturerController().DeleteAll()
                && connection.ExecuteScalar<bool>("DELETE FROM SubjectSelection");
        }
    }
}
