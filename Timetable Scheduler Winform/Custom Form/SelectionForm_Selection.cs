using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TimetableData.Controller;
using TimetableData.Model;
using TimetableSchedulerWinform.CustomControl;

namespace TimetableSchedulerWinform.CustomForm
{
    partial class SelectionForm
    {
        SubjectSelection selection;
        public SubjectSelection deep_copy;

        SubjectSelectionController controller;
        LectureTimeController time_controller;
        Selection_TimeController selection_time_controller;
        Selection_LecturerController selection_lecturer_controller;

        private bool new_value;
        public bool New
        {
            get
            {
                return new_value;
            }
            set
            {
                if(value)
                {
                    SelectionAcceptButton.Text = "Insert";
                    SelectionDeclineButton.Text = "Reset";
                }
                else
                {
                    SelectionAcceptButton.Text = "Update";
                    SelectionDeclineButton.Text = "Delete";
                }

                new_value = value;
            }
        }

        public bool Deleted { get; private set; }
        public List<SubjectSelection> InsertedSelections { get; private set; }
        public bool Updated { get; private set; }

        private void InitializeSelection()
        {
            controller = new SubjectSelectionController();
            time_controller = new LectureTimeController();
            selection_time_controller = new Selection_TimeController();
            selection_lecturer_controller = new Selection_LecturerController();

            InsertedSelections = new List<SubjectSelection>();
            Updated = false;

            FormClosed += SelectionForm_Closed;
        }

        private void LoadSelectedLecturers()
        {
            foreach (int lecturer_id in selection_lecturer_controller.GetBySelection(selection.Id))
                for (int i = 0; i < LecturersGridView.Rows.Count; ++i)
                    if (Convert.ToInt32(LecturersGridView["Id", i].Value) == lecturer_id)
                        LecturersGridView["Select", i].Value = true;
        }

        private void SelectionForm_Closed(object sender, System.Windows.Forms.FormClosedEventArgs e)
        {
            if(!Deleted
                && InsertedSelections.Count == 0)
            {
                selection.HallId = deep_copy.HallId;
                selection.SubjectId = deep_copy.SubjectId;
            }
        }

        private void BindData()
        {
            SubjectCombobox.DataBindings.Clear();
            HallCombobox.DataBindings.Clear();

            SubjectCombobox.DataBindings.Add("SelectedValue", this.selection, "SubjectId",
                false, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged);
            HallCombobox.DataBindings.Add("SelectedValue", this.selection, "HallId",
                false, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged);
        }

        public void SetSelection(SubjectSelection selection)
        {
            this.selection = selection;
            deep_copy = new SubjectSelection(selection);
            New = (selection.Id == 0);

            //BindData();
            SubjectCombobox.SelectedValue = selection.SubjectId;
            HallCombobox.SelectedValue = selection.HallId;

            TimetableControl.AddSubjectAndTimes(
                selection.Subject, 
                selection.Times);
        }

        private void SetAfterInsert()
        {
            deep_copy = new SubjectSelection(selection);
            selection = new SubjectSelection();
            TimetableControl.ResetLectureTimes();
        }

        private void SelectionApplyButton_Click(object sender, EventArgs e)
        {
            TimetableControl.ResetLectureTimes();
            TimetableControl.AddSubjectToSelectedCells((Subject)SubjectCombobox.SelectedItem);
        }

        private void SelectionAcceptButton_Click(object sender, EventArgs e)
        {
            if(SubjectCombobox.SelectedIndex == -1
                || HallCombobox.SelectedIndex == -1)
            {
                CustomMessages.ChooseBeforeCarryOn(this, "subject and hall");
                return;
            }
                
            if(New)
            {
                //databinding by hand
                selection.HallId = Convert.ToInt32(HallCombobox.SelectedValue);
                selection.SubjectId = Convert.ToInt32(SubjectCombobox.SelectedValue);

                int selection_id = (int)controller.Insert(selection);
                selection.Id = selection_id;
                if (selection_id > 0)
                {
                    selection_time_controller.InsertTimes(selection_id, 
                        TimetableControl.GetLectureTimes(TimetableControl.IsSelectedCell));
                    selection_lecturer_controller.InsertLecturers(selection_id,
                        checked_lecturers_id.ToList());
                    CustomMessages.Inserted(this, "selection");

                    InsertedSelections.Add(selection);
                    SetAfterInsert();
                }
            }
            else
            {
                //quite the horrible way as I delete everything and re-insert them
                if(controller.Update(selection))
                {
                    selection_time_controller.DeleteBySelection(selection.Id);
                    selection_lecturer_controller.DeleteBySelection(selection.Id);

                    selection_time_controller.InsertTimes(selection.Id,
                        TimetableControl.GetLectureTimes(TimetableControl.IsSelectedCell));
                    selection_lecturer_controller.InsertLecturers(selection.Id,
                        checked_lecturers_id.ToList());

                    SetSelection(selection);
                    CustomMessages.Updated(this, "selection");
                    //TimetableControl.ResetLectureTimes();
                    Updated = true;
                }
            }
        }

        private void SelectionDeclineButton_Click(object sender, EventArgs e)
        {
            if(New) //reset
            {
                //reset
                SetSelection(new SubjectSelection());

                //reset all lecturers
                for (int i = 0; i < LecturersGridView.Rows.Count; ++i)
                    if (LecturersGridView["Select", i].Value != null
                        && (bool)LecturersGridView["Select", i].Value)
                        LecturersGridView["Select", i].Value = false;
                checked_lecturers_id.Clear();

                TimetableControl.ResetLectureTimes();
            }
            else if(CustomMessages.YesNoDelete(this))
            {
                Deleted = controller.Delete(selection);
                Close();
            }
        }
    }
}

