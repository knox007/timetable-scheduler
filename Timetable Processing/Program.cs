using System;
using System.Collections.Generic;

namespace Timetable_Processing
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, List<int>> d = new Dictionary<int, List<int>>();

            d[0].Add(1);
            d[0].Add(2);
            d[0].Add(3);

            Console.Write(d[0].ToString());

            Console.ReadKey();
        }
    }
}
