using System;
using System.Text.RegularExpressions;

namespace Timetable_Data.Model
{
    class Lecture_Time
    {
        private static readonly string regex_format = @"^\[(\d):(\d\d)-(\d\d)\]$";
        //[1:03-04] => Day = Monday, Start_Period = 3, End_Period = 4;

        public int Id { get; set; }
        private int start_period, end_period;
        public int Start_Period { get => start_period; set => start_period = Valid_Period(value) ? value : 1; }
        public int End_Period { get => end_period; set => end_period = Valid_Period(value) ? value : 1; }
        public DayOfWeek Day { get; set; }

        public Lecture_Time() { }
        public Lecture_Time(int id, DayOfWeek day, int start_period, int end_period)
        {
            Id = id;
            Day = day;
            Start_Period = start_period;
            End_Period = end_period;
        }

        public Lecture_Time(int id, string time)
        {
            Id = id;
            Match match = Regex.Match(time, regex_format);
            if (!match.Success) return; //exit if wrong format

            Day = (DayOfWeek)Int32.Parse(match.Groups[1].ToString());
            start_period = Int32.Parse(match.Groups[2].ToString());
            end_period = Int32.Parse(match.Groups[3].ToString());
        }

        private bool Valid_Period(int period)
        {
            return (period >= 1 && period <= 15);
        }

        private bool In_Range(int period)
        {
            return start_period < period && period < end_period;
        }
        public bool Intersect(Lecture_Time time)
        {
            return In_Range(time.start_period) || In_Range(time.end_period);
        }

        public override string ToString()
        {
            return string.Format("[{0}:{1:00}-{2:00}]",
                Day.ToString(), start_period.ToString(), end_period.ToString())
                .ToString();
        }
    }
}
