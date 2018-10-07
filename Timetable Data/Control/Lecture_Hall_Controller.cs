using System.Collections.Generic;
using Timetable_Data.Model;
using System.Data.Linq;
using System.Linq;
using Timetable_Data.Control;
using Lecture_Hall = Timetable_Data.Model.Lecture_Hall;

namespace Timetable_Processing.Control
{
    class Lecture_Hall_Controller
    {
        public List<Lecture_Hall> Get_All()
        {
            Database_ClassesDataContext classes = new Database_ClassesDataContext();

            return (from h in classes.Lecture_Halls
                    select (Lecture_Hall)h).ToList();
        }

        public void Insert(Lecture_Hall hall)
        {
            Database_ClassesDataContext classes = new Database_ClassesDataContext();
            classes.Lecture_Halls.InsertOnSubmit(hall);
        }

        public void Delete(Lecture_Hall hall)
        {
            Database_ClassesDataContext classes = new Database_ClassesDataContext();
            classes.Lecture_Halls.DeleteOnSubmit(hall);
        }
    }
}
