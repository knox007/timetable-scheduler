using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FastMember;
using TimetableData.Controller;
using TimetableData.Model;
using TimetableSchedulerWinform.CustomControl;

namespace TimetableSchedulerWinform.CustomForm
{
    public partial class LecturersOptionForm : Form
    {
        DataTable preferred_lecturers,
            denied_lecturers;
        public HashSet<int> preferred_lecturers_id,
            denied_lecturers_id;

        public LecturersOptionForm()
        {
            InitializeComponent();
            LoadData();
            SetEvents();
        }

        private void PreferredFilter_TextChanged(object sender, EventArgs e)
        {
            preferred_lecturers.DefaultView.RowFilter 
                = string.Format("Name LIKE '%{0}%'", PreferredFilter.Text);
            for(int i = 0; i < PreferredLecturersCheckedListBox.Items.Count; ++i)
            {
                DataRowView row_view = 
                    (DataRowView)PreferredLecturersCheckedListBox.Items[i];

                int id = Convert.ToInt32(row_view.Row.ItemArray[0]);
                if (preferred_lecturers_id.Contains(id))
                    PreferredLecturersCheckedListBox.SetItemChecked(i, true);
            }
        }

        private void DeniedFilter_TextChanged(object sender, EventArgs e)
        {
            denied_lecturers.DefaultView.RowFilter
                = string.Format("Name LIKE '%{0}%'", DeniedFilter.Text);

            for (int i = 0; i < DeniedLecturersCheckedListBox.Items.Count; ++i)
            {
                DataRowView row_view =
                    (DataRowView)DeniedLecturersCheckedListBox.Items[i];

                int id = Convert.ToInt32(row_view.Row.ItemArray[0]);
                if (denied_lecturers_id.Contains(id))
                    DeniedLecturersCheckedListBox.SetItemChecked(i, true);
            }
        }

        private void LoadData()
        {
            preferred_lecturers = new DataTable();
            denied_lecturers = new DataTable();

            preferred_lecturers_id = new HashSet<int>();
            denied_lecturers_id = new HashSet<int>();

            List<Lecturer> all_lecturers = new LecturerController().GetAll();
            using (var reader = ObjectReader.Create(all_lecturers))
                preferred_lecturers.Load(reader);
            using (var reader = ObjectReader.Create(all_lecturers))
                denied_lecturers.Load(reader);

            PreferredLecturersCheckedListBox.DataSource = preferred_lecturers;
            PreferredLecturersCheckedListBox.DisplayMember = "Name";
            PreferredLecturersCheckedListBox.ValueMember = "Id";
            DeniedLecturersCheckedListBox.DataSource = denied_lecturers;
            DeniedLecturersCheckedListBox.DisplayMember = "Name";
            DeniedLecturersCheckedListBox.ValueMember = "Id";
        }

        private void SetEvents()
        {
            PreferredLecturersCheckedListBox.ItemCheck += Preferred_ItemCheck;
            DeniedLecturersCheckedListBox.ItemCheck += Denied_ItemCheck;
            FormClosing += LecturersOptionForm_FormClosing;
        }

        private void LecturersOptionForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(e.CloseReason == CloseReason.UserClosing)
                ResetEverything();
        }

        private void Denied_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            DataRowView row_view = (DataRowView)DeniedLecturersCheckedListBox.Items[e.Index];
            int id = Convert.ToInt32(row_view.Row.ItemArray[0]);

            if (e.NewValue == CheckState.Checked)
                denied_lecturers_id.Add(id);
            else if (e.NewValue == CheckState.Unchecked)
                denied_lecturers_id.Remove(id);
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            ResetEverything();
            Hide();
        }

        private void ResetEverything()
        {
            PreferredFilter.Text = "";
            preferred_lecturers_id.Clear();
            foreach(int i in PreferredLecturersCheckedListBox.CheckedIndices)
                PreferredLecturersCheckedListBox.SetItemChecked(i, false);
            if (PreferredLecturersCheckedListBox.Items.Count > 0)
                PreferredLecturersCheckedListBox.SelectedIndex = 0;

            DeniedFilter.Text = "";
            if (DeniedLecturersCheckedListBox.Items.Count > 0)
                DeniedLecturersCheckedListBox.SelectedIndex = 0;
            denied_lecturers_id.Clear();
            foreach (int i in DeniedLecturersCheckedListBox.CheckedIndices)
                DeniedLecturersCheckedListBox.SetItemChecked(i, false);
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            ResetEverything();
        }

        private void Preferred_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            DataRowView row_view = (DataRowView)PreferredLecturersCheckedListBox.Items[e.Index];
            int id = Convert.ToInt32(row_view.Row.ItemArray[0]);

            if (e.NewValue == CheckState.Checked)
                preferred_lecturers_id.Add(id);
            else if (e.NewValue == CheckState.Unchecked)
                preferred_lecturers_id.Remove(id);
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            if(preferred_lecturers_id.Intersect(denied_lecturers_id).Count() > 0)
            {
                MessageBox.Show(this, "You cannot mark a lecturer as both preferred and denied!",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation,
                    MessageBoxDefaultButton.Button1);
            }
            else if(preferred_lecturers_id.Count > 0 
                || denied_lecturers_id.Count > 0)
            {
                CustomMessages.OptionsSaved(this);
                Hide();
            }
            else
            {
                Hide();
            }
        }
    }
}
