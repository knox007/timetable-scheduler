using FastMember;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TimetableData.Controller;
using TimetableData.Model;
using TimetableData.Manipulator;
using TimetableSchedulerWinform.CustomControl;
using TimetableSchedulerWinform.CustomForm;

namespace TimetableSchedulerWinform
{
    public partial class MainForm : Form
    {
        SelectionManipulator manipulator;
        List<List<SubjectSelection>> optimized_selections;
        SubjectController subject_controller;
        LecturerController lecturer_controller;
        LectureTimeController time_controller;
        OptimizedSelectionsForm optimized_selection_form;
        LecturersOptionForm lecturers_option_form;
        TimesOptionForm times_option_form;

        private int current_selection;
        private int CurrentSelection
        {
            get
            {
                return current_selection;
            }
            set
            {
                if (optimized_selections.Count == 0)
                    return;
                if (value < 0 || value >= optimized_selections.Count)
                {
                    if (value < 0) CurrentSelection = optimized_selections.Count - 1;
                    else CurrentSelection = 0;

                    return;
                }
                else
                    current_selection = value;

                TimetableControl.ResetLectureTimes();
                foreach (SubjectSelection selection in optimized_selections[current_selection])
                    TimetableControl.AddSubjectSelection(selection);

                TotalSelectionTextbox.Text = optimized_selections.Count().ToString();
                CurrentSelectionTextbox.Text = (current_selection + 1).ToString();

                optimized_selection_form.SetData(optimized_selections[current_selection]);
                optimized_selection_form.Show();
            }
        }

        public MainForm()
        {
            InitializeComponent();
            InitializeSubjects();

            manipulator = new SelectionManipulator();
            subject_controller = new SubjectController();
            lecturer_controller = new LecturerController();
            time_controller = new LectureTimeController();

            optimized_selections = new List<List<SubjectSelection>>();
            optimized_selection_form = new OptimizedSelectionsForm();
            optimized_selection_form.FormClosing += AvoidClosing;

            lecturers_option_form = new LecturersOptionForm();
            lecturers_option_form.FormClosing += AvoidClosing;
            times_option_form = new TimesOptionForm();
            times_option_form.FormClosing += AvoidClosing;

            TotalSelectionTextbox.Enabled = false;
        }

        private void AvoidClosing(object sender, FormClosingEventArgs e)
        {
            if(e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                ((Form)sender).Hide();
            }
        }

        private void GenerateButton_Click(object sender, EventArgs e)
        {
            if (checked_subjects_id.Count == 0)
            {
                CustomMessages.SelectFail(this);
                return;
            }

            manipulator.AllSelections = new SubjectSelectionController().GetAll();
            
            manipulator.Halls_Height_Preference
                = floorsHeightPreferenceToolStripMenuItem.Checked;

            manipulator.Preferred_Lecturers.Clear();
            manipulator.Denied_Lecturers.Clear();

            foreach (int id in lecturers_option_form.preferred_lecturers_id)
                manipulator.Preferred_Lecturers.Add(lecturer_controller.Get(id));
            foreach (int id in lecturers_option_form.denied_lecturers_id)
                manipulator.Denied_Lecturers.Add(lecturer_controller.Get(id));

            if(times_option_form.preferred_times != null)
                manipulator.Preferred_Lecture_Times = times_option_form.preferred_times;
            if(times_option_form.denied_times != null)
                manipulator.Denied_Lecture_Times = times_option_form.denied_times;

            manipulator.Selected_Subjects.Clear();

            foreach (int id in checked_subjects_id)
                manipulator.Selected_Subjects.Add(subject_controller.Get(id));
            optimized_selections = manipulator.GetOptimizedSelections();

            if (optimized_selections.Count == 0 || optimized_selections[0].Count == 0)
                CustomMessages.NoSelectionAvailable(this);
            else
                CurrentSelection = 0;
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            ++CurrentSelection;
        }

        private void PreviousButton_Click(object sender, EventArgs e)
        {
            --CurrentSelection;
        }

        private void floorsHeightPreferenceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool state = floorsHeightPreferenceToolStripMenuItem.Checked;
            floorsHeightPreferenceToolStripMenuItem.Checked = !state;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void newSelectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void showSelectionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SelectionListForm selection_list_form = new SelectionListForm();
            selection_list_form.Show();
        }

        private void resetSelectionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (CustomMessages.YesNoReset(this))
                new SubjectSelectionController().DeleteAll();
        }

        private void resetLecturersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (CustomMessages.YesNoReset(this))
                new LecturerController().DeleteAll();
        }

        private void resetHallsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (CustomMessages.YesNoReset(this))
                new LectureHallController().DeleteAll();
        }

        private void resetAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //new LectureHallController().DeleteAll();
        }

        private void resetSubjectsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(CustomMessages.YesNoReset(this))
                new SubjectController().DeleteAll();
        }

        private void lecturersOptionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lecturers_option_form.Show();
        }

        private void timesOptionLectureTimesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            times_option_form.Show();
        }

        private void CurrentSelectionTextbox_TextChanged(object sender, EventArgs e)
        {
            
            //CurrentSelection = Convert.ToInt32(CurrentSelectionTextbox.Text);
        }

        private void CurrentSelectionTextbox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                CurrentSelection = Convert.ToInt32(CurrentSelectionTextbox.Text) - 1;
        }
    }
}
