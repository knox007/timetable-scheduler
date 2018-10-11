using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Timetable_Data.Control;
using Timetable_Data.Model;
using Dapper;
using System.Data.SqlClient;

namespace Timetable_Data
{
    class Program
    {
        static void Main(string[] args)
        {
            Lecture_Time_Controller ltc = new Lecture_Time_Controller();
            ltc.Insert(new Lecture_Time(1, "[1:02-03]"));

            Console.ReadKey();
        }
    }
}
