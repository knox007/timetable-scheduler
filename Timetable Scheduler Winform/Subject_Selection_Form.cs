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
        SelectorControl<Subject, SubjectForm> SubjectSelector;
        SelectorControl<LectureHall, LectureHallForm> HallSelector;
        LecturerUserControl LecturerSelector;
        SubjectSelection selection, deep_copy;

        private bool new_value;
        public bool New
        {
            get { return new_value; }
            set
            {
                if(value)
                {
                    AcceptButton.Text = "New";
                    DeclineButton.Text = "Reset";
                }
                else
                {
                    AcceptButton.Text = "Update";
                    DeclineButton.Text = "Delete";
                }
                new_value = value;
            }
        }

        public void SetSubjectSelection(SubjectSelection selection)
        {
            New = (selection.Id == 0);

            this.selection = selection;
            deep_copy = new SubjectSelection()
            {
                Id = selection.Id,
            };
        }

        public Subject_Selection_Form()
        {
            InitializeComponent();

            SubjectSelector = new SelectorControl<Subject, SubjectForm>();
            HallSelector = new SelectorControl<LectureHall, LectureHallForm>();

            HallSelector.SelectWhatLabel.Text = "Select Lecture Hall";

            SelectorsFlowPanel.Controls.Add(SubjectSelector);
            SelectorsFlowPanel.Controls.Add(HallSelector);

            SubjectSelector.Visible = true;
            HallSelector.Visible = true;

            LecturerSelector = new LecturerUserControl();

            LecturersPanel.Controls.Add(LecturerSelector);
            LecturerSelector.Left = (LecturersPanel.Width - LecturerSelector.Width) / 2;
            LecturerSelector.Top = (LecturersPanel.Height - LecturerSelector.Height) / 2 + 6;

            LecturerSelector.Visible = true;

            //SelectLecturersLabel.BringToFront();
        }

        private void ApplyButton_Click(object sender, EventArgs e)
        {
            TimetableControl.ResetLectureTimes();
            TimetableControl.AddSubjectAndTimes(
                SubjectSelector.GetModel(), TimetableControl.GetLectureTimes());
        }
    }
}
