using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Timetable_Data.Model;

namespace Timetable_Scheduler_Winform
{
    public partial class Main_Form : Form
    {
        public Main_Form()
        {
            InitializeComponent();
            Timetable.Add_Subject_Selection(new Subject_Selection()
            {
                Subject = new Subject()
                {
                    Name = "none",
                    Codename = "CSDL"
                },

                Times = new List<Lecture_Time>()
                {
                    new Lecture_Time(1, DayOfWeek.Monday, 1, 3),
                    new Lecture_Time(2, DayOfWeek.Tuesday, 1, 2),
                }
            });
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Timetable.Set_Denied_Lecture_Times();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Timetable.Set_Preferred_Lecture_Times();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Timetable.Reset_Lecture_Times();
        }
    }
}
