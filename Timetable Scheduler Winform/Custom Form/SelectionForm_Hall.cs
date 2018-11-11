using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TimetableData.Controller;
using TimetableData.Model;

namespace TimetableSchedulerWinform.CustomForm
{
    partial class SelectionForm
    {
        BindingList<LectureHall> all_halls;
        private void InitializeHalls()
        {
            all_halls = new BindingList<LectureHall>(new LectureHallController().GetAll());
            HallCombobox.DataSource = all_halls;
            HallCombobox.DataBindings.DefaultDataSourceUpdateMode 
                = System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged;
            HallCombobox.SelectedValueChanged += HallCombobox_SelectedValueChanged;

            HallCombobox.ValueMember = "Id";
            HallCombobox.DisplayMember = "";
        }

        private void HallCombobox_SelectedValueChanged(object sender, EventArgs e)
        {
            if (HallCombobox.SelectedIndex > -1 && selection != null)
                selection.HallId = Convert.ToInt32(HallCombobox.SelectedValue);
        }

        private void HallEditButton_Click(object sender, EventArgs e)
        {
            LectureHallForm form = new LectureHallForm();
            form.SetHall((LectureHall)HallCombobox.SelectedItem);
            form.Show();

            form.FormClosed += LectureHallForm_Closed;
        }

        private void HallNewButton_Click(object sender, EventArgs e)
        {
            LectureHallForm form = new LectureHallForm();
            form.SetHall(new LectureHall());
            form.Show();

            form.FormClosed += LectureHallForm_Closed;
        }

        private void LectureHallForm_Closed(object sender, System.Windows.Forms.FormClosedEventArgs e)
        {
            LectureHallForm form = (LectureHallForm)sender;
            if (form.InsertedHalls.Count > 0)
            {
                foreach (LectureHall hall in form.InsertedHalls)
                    all_halls.Add(hall);
                HallCombobox.SelectedIndex = HallCombobox.Items.Count - 1;
            }
            else if (form.Deleted)
                all_halls.RemoveAt(HallCombobox.SelectedIndex);
        }

    }
}