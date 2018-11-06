using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimetableData.Control;
using TimetableData.Model;
using Dapper;
using System.Data.SqlClient;

namespace TimetableData
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
