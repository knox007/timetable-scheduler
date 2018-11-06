using System;
using System.Text.RegularExpressions;
using Dapper.Contrib.Extensions;

namespace TimetableData.Model
{
    [Table("Lecture_Time")]
    public class Lecture_Time
    {
        private static readonly string regex_format = @"^\[(\d):(\d\d)-(\d\d)\]$";
        //[1:03-04] => Day = Monday, Start_Period = 3, End_Period = 4;
        public int Id { get; set; }

        public string Time
        {
            get { return Time_Numbers_To_Time_String(Day, start_period, end_period); }
            set { Time_String_To_Time_Numbers(value); }
        }

        private int start_period, end_period;
        [Computed]
        public int Start_Period { get => start_period; set => start_period = Valid_Period(value) ? value : 1; }
        [Computed]
        public int End_Period { get => end_period; set => end_period = Valid_Period(value) ? value : 1; }
        [Computed]
        public DayOfWeek Day { get; set; }

        public static string Time_Numbers_To_Time_String(DayOfWeek day, int start_period, int end_period)
        {
            return string.Format("[{0}:{1:00}-{2:00}]",
                (int)day, start_period.ToString(), end_period.ToString()).ToString();
        }

        public bool Time_String_To_Time_Numbers(string time)
        {
            Match match = Regex.Match(time, regex_format);
            if (!match.Success) return false; //exit if wrong format

            Day = (DayOfWeek)int.Parse(match.Groups[1].ToString());
            start_period = int.Parse(match.Groups[2].ToString());
            end_period = int.Parse(match.Groups[3].ToString());
            return true;
        }
        
        public Lecture_Time() { }
        public Lecture_Time(DayOfWeek day, int start_period, int end_period)
        {
            //Id = id;
            Day = day;
            Start_Period = start_period;
            End_Period = end_period;
            Time = Time_Numbers_To_Time_String(day, start_period, end_period);
        }

        public Lecture_Time(string time)
        {
            //Id = id;
            Time_String_To_Time_Numbers(time);
        }

        private bool Valid_Period(int period)
        {
            return (period >= 1 && period <= 16);
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
            return Time_Numbers_To_Time_String(Day, start_period, end_period);
        }
    }
}
