using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using Dapper.Contrib.Extensions;

namespace TimetableData.Model
{
    [Table("LectureTime")]
    public class LectureTime
    {
        private static readonly string regex_format = @"\[(\d):(\d+)-(\d+)\]";
        //[1:03-04] => Day = Monday, Start_Period = 3, End_Period = 4;
        public int Id { get; set; }

        public string Time
        {
            get { return TimeNumbersToTimeString(Day, start_period, end_period); }
            set { Time_String_To_Time_Numbers(value); }
        }

        private int start_period, end_period;
        [Computed]
        public int Start_Period { get => start_period; set => start_period = Valid_Period(value) ? value : 1; }
        [Computed]
        public int End_Period { get => end_period; set => end_period = Valid_Period(value) ? value : 1; }
        [Computed]
        public DayOfWeek Day { get; set; }

        public static string TimeNumbersToTimeString(DayOfWeek day, int start_period, int end_period)
        {
            return string.Format("[{0}:{1:00}-{2:00}]",
                (int)day, start_period.ToString(), end_period.ToString());
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
        
        public LectureTime() { }
        public LectureTime(DayOfWeek day, int start_period, int end_period)
        {
            //Id = id;
            Day = day;
            Start_Period = start_period;
            End_Period = end_period;
            Time = TimeNumbersToTimeString(day, start_period, end_period);
        }

        public LectureTime(string time)
        {
            //Id = id;
            Time_String_To_Time_Numbers(time);
        }

        private bool Valid_Period(int period)
        {
            return (period >= 1 && period <= 16);
        }

        private bool Available(int period)
        {
            return start_period < period && period < end_period;
        }
        public bool Intersect(LectureTime time)
        {
            return Available(time.start_period) || Available(time.end_period);
        }
        public static bool IsSubset(LectureTime container, LectureTime to_be_contained)
        { //timeB is subset of timeA?
            return container.Available(to_be_contained.start_period) 
                && container.Available(to_be_contained.end_period);
        }

        public override string ToString()
        {
            return //TimeNumbersToTimeString(Day, start_period, end_period);
                ToNiceString();
        }

        public string ToNiceString()
        {
            return string.Format("[{0}: {1} - {2}]", 
                Day.ToString(), 
                start_period, 
                end_period);
        }

        public static string TimeListToString(List<LectureTime> times)
        {
            if (times.Count == 0) return "";

            string result = "";
            for (int i = 0; i < times.Count - 1; ++i)
                result += (times[i].ToNiceString() + Environment.NewLine);
            result += times[times.Count - 1].ToNiceString();
            return result;
        }
    }
}
