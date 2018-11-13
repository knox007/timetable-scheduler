using FastMember;
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
using TimetableSchedulerWinform.CustomForm;

namespace TimetableSchedulerWinform
{
    partial class MainForm
    {
        DataTable all_subjects;
        HashSet<int> checked_subjects_id;

        private void InitializeSubjects()
        {
            all_subjects = new DataTable();
            checked_subjects_id = new HashSet<int>();
            using (var reader = ObjectReader.Create(new SubjectController().GetAll()))
                all_subjects.Load(reader);

            SubjectsGridView.DataSource = all_subjects;

            SubjectsGridView.ColumnHeadersDefaultCellStyle = new DataGridViewCellStyle()
            {
                Alignment = DataGridViewContentAlignment.MiddleCenter
            };

            SubjectsGridView.Columns.Add(new DataGridViewCheckBoxColumn()
            {
                Name = "Select"
            });
            //id 0, name 1, codename 2, checkbox 3
            SubjectsGridView.Columns["Id"].Visible = false;
            SubjectsGridView.Columns["Codename"].Visible = false;

            SubjectsGridView.Columns["Name"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            SubjectsGridView.Columns["Name"].ReadOnly = true;

            SubjectsGridView.Columns["Select"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            SubjectsGridView.CellValueChanged += CompulsorySubjectsGridView_CellValueChanged;
            SubjectsGridView.CellMouseUp += CompulsorySubjectsGridView_CellMouseUp;

            SubjectsGridView.AllowUserToAddRows = false;
            SubjectsGridView.AllowUserToDeleteRows = false;
            SubjectsGridView.AllowUserToOrderColumns = false;
            SubjectsGridView.AllowUserToResizeColumns = false;
            SubjectsGridView.AllowUserToResizeRows = false;

            SubjectsGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            SubjectsGridView.MultiSelect = false;
        }

        private void CompulsorySubjectsGridView_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex == 0)
                SubjectsGridView.EndEdit();
        }

        private void CompulsorySubjectsGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                if ((bool)SubjectsGridView.Rows[e.RowIndex].Cells[0].Value)
                    checked_subjects_id.Add((int)SubjectsGridView.Rows[e.RowIndex].Cells[2].Value);
                //MessageBox.Show("Checked");
                else
                    checked_subjects_id.Remove((int)SubjectsGridView.Rows[e.RowIndex].Cells[2].Value);
            }
        }

        private void SubjectFilteringTextbox_TextChanged(object sender, EventArgs e)
        {
            all_subjects.DefaultView.RowFilter
                = String.Format("Name LIKE '%{0}%'", SubjectFilteringTextbox.Text);
            foreach (DataGridViewRow row in SubjectsGridView.Rows)
                //same id
                if (checked_subjects_id.Contains((int)row.Cells[2].Value))
                    row.Cells[0].Value = true;
        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            checked_subjects_id.Clear();
            all_subjects = new DataTable();
            using (var reader = ObjectReader.Create(new SubjectController().GetAll()))
                all_subjects.Load(reader);
            SubjectsGridView.DataSource = all_subjects;
        }

        private void SelectAllButton_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in SubjectsGridView.Rows)
            {
                row.Cells["Select"].Value = true;
            }
        }
    }
}
