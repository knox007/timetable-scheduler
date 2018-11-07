using System.Collections.Generic;
using Dapper.Contrib.Extensions;
using Dapper;
using System.Linq;
using TimetableData.Model;

namespace TimetableData.Control
{
    class SubjectSelectionController : BaseController<SubjectSelection>
    {
        public override bool Delete(SubjectSelection t)
        {
            return (Exists_In_Table("Selection_Lecturer", "Selection_Id", t.Id.ToString())
                || Exists_In_Table("Selection_Time", "Selection_Id", t.Id.ToString()))
                ? false : Delete(t);
        }

        public bool AddLecturer(ref SubjectSelection ss, Lecturer l)
        {
            return connection.Insert<Selection_Lecturer>(
                new Selection_Lecturer()
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
            return connection.Delete<Selection_Lecturer>(
                new Selection_Lecturer()
                    { Lecturer_Id = l.Id, Selection_Id = ss.Id }
            ); //insert success
        }

        public bool RemoveTime(ref SubjectSelection selection, LectureTime time)
        {
            return new Selection_TimeController().Delete(new Selection_Time()
            {
                Selection_Id = selection.Id,
                Lecture_Time_Id = time.Id
            });
        }
    }
}
