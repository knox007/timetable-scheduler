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
            Selection_Manipulator sm = new Selection_Manipulator();
            
            Console.ReadKey();
        }
    }
}
