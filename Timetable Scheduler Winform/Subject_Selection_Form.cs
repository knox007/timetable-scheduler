using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TimetableData.Model;
using TimetableSchedulerWinform.CustomControl;

namespace TimetableSchedulerWinform
{
    public partial class Subject_Selection_Form : Form
    {
        public Subject_Selection_Form()
        {
            InitializeComponent();

            SelectorControl<Lecturer, Lecturer_Form> LecturerSelector =
                new SelectorControl<Lecturer, Lecturer_Form>();
            SelectorControl<LectureHall, LectureHallForm> HallSelector =
                new SelectorControl<LectureHall, LectureHallForm>();

            HallSelector.SelectWhatLabel.Text = "Select Lecture Hall";

            SelectorsFlowPanel.Controls.Add(LecturerSelector);
            SelectorsFlowPanel.Controls.Add(HallSelector);

            LecturerSelector.Visible = true;
            HallSelector.Visible = true;
        }
    }
}
