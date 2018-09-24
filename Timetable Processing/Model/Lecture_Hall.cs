using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Timetable_Scheduler.Model
{
    class Lecture_Hall
    {
        public string Building { get; set; }
        public int Floor { get; set; }
        public string Room { get; set; }
        public int Id { get; set; }

        public override string ToString()
        {
            return Building + Floor + Room;
        }
    }
}
