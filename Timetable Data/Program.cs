using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimetableData.Controller;
using TimetableData.Model;
using Dapper;
using System.Data.SqlClient;

namespace TimetableData
{
    class Program
    {
        static void Main(string[] args)
        {
            LectureTimeController controller = new LectureTimeController();
            LectureTime time;
            for(int i = 0; i <= 10; ++i)
            {
                time = controller.Get(i);
                if(time != null)
                {
                    Console.WriteLine(time.Time);
                }
            }
                
            Console.ReadKey();
        }
    }
}
