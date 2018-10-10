using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Timetable_Data.Control;
using Timetable_Data.Model;

namespace Timetable_Data
{
    class Program
    {
        static void Main(string[] args)
        {
            Subject_Controller sc = new Subject_Controller();
            sc.Insert(new Subject(1, "Database"));
            
            Console.ReadKey();
        }
    }
}
