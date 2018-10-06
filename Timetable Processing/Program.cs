using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using Timetable_Processing.Control;

namespace Timetable_Processing
{
    class Program
    {
        static void Main(string[] args)
        {
            string regex_format = @"^\[(\d):(\d\d)-(\d\d)\]$",
                test = @"[0:12-34]";

            Match match = Regex.Match(test, regex_format);
            for (int i = 0; i < match.Groups.Count; ++i)
                Console.WriteLine("{0} {1}", i, match.Groups[i]);

            Console.ReadKey();
        }
    }
}
