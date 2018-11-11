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
        OptimizedSelectionsForm form;

        private int current_selection;
        private int CurrentSelection
        {
            get
            {
                return current_selection;
            }
            set
            {
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

                SelectionNumberingLabel.Text 
                    = string.Format("Selection {0}/{1}", 
                    current_selection + 1, 
                    optimized_selections.Count);

                form.SetData(optimized_selections[current_selection]);
                form.Show();
            }
        }

        public MainForm()
        {
            InitializeComponent();
            InitializeCompulsorySubjects();

            manipulator = new SelectionManipulator();
            subject_controller = new SubjectController();
            form = new OptimizedSelectionsForm();
            form.FormClosing += AvoidClosing;
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
            manipulator.Selected_Subjects.Clear();
            manipulator.Halls_Height_Preference
                = floorsHeightPreferenceToolStripMenuItem.Checked;

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
            SelectionForm form = new SelectionForm();
            form.SetSelection(new SubjectSelection());
            form.Show(this);
        }

        private void showSelectionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SelectionListForm form = new SelectionListForm();
            form.Show(this);
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
            new LectureHallController().DeleteAll();
        }

        private void resetSubjectsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //new SubjectController().DeleteAll();
        }

        private void lecturersOptionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new LecturersOptionForm().Show();
        }
    }
}
