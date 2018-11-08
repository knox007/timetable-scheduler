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
using TimetableSchedulerWinform.CustomForm;

namespace TimetableSchedulerWinform
{
    public partial class MainForm : Form
    {
        DataTable all_subjects;
        HashSet<int> checked_subjects_id;

        private void InitializeCompulsorySubjects()
        {
            all_subjects = new DataTable();
            checked_subjects_id = new HashSet<int>();
            using (var reader = ObjectReader.Create(new SubjectController().GetAll()))
                all_subjects.Load(reader);
            CompulsorySubjectsGridView.DataSource = all_subjects;

            CompulsorySubjectsGridView.ColumnHeadersDefaultCellStyle = new DataGridViewCellStyle()
            {
                Alignment = DataGridViewContentAlignment.MiddleCenter
            };

            CompulsorySubjectsGridView.Columns.Add(new DataGridViewCheckBoxColumn()
            {
                Name = "Select"
            });
            //id 0, name 1, codename 2, checkbox 3
            CompulsorySubjectsGridView.Columns["Id"].Visible = false;
            CompulsorySubjectsGridView.Columns["Codename"].Visible = false;

            CompulsorySubjectsGridView.Columns["Name"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            CompulsorySubjectsGridView.Columns["Name"].ReadOnly = true;

            CompulsorySubjectsGridView.Columns["Select"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            CompulsorySubjectsGridView.CellValueChanged += CompulsorySubjectsGridView_CellValueChanged;
            CompulsorySubjectsGridView.CellMouseUp += CompulsorySubjectsGridView_CellMouseUp;

            CompulsorySubjectsGridView.AllowUserToAddRows = false;
            CompulsorySubjectsGridView.AllowUserToDeleteRows = false;
            CompulsorySubjectsGridView.AllowUserToOrderColumns = false;
            CompulsorySubjectsGridView.AllowUserToResizeColumns = false;
            CompulsorySubjectsGridView.AllowUserToResizeRows = false;

            CompulsorySubjectsGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            CompulsorySubjectsGridView.MultiSelect = false;
        }

        private void CompulsorySubjectsGridView_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex == 0)
                CompulsorySubjectsGridView.EndEdit();
        }

        private void CompulsorySubjectsGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                if ((bool)CompulsorySubjectsGridView.Rows[e.RowIndex].Cells[0].Value)
                    checked_subjects_id.Add((int)CompulsorySubjectsGridView.Rows[e.RowIndex].Cells[2].Value);
                //MessageBox.Show("Checked");
                else
                    checked_subjects_id.Remove((int)CompulsorySubjectsGridView.Rows[e.RowIndex].Cells[2].Value);
            }
        }

        public MainForm()
        {
            InitializeComponent();
            InitializeCompulsorySubjects();
        }

        private void SubjectFilteringTextbox_TextChanged(object sender, EventArgs e)
        {
            all_subjects.DefaultView.RowFilter 
                = String.Format("Name LIKE '%{0}%'", SubjectFilteringTextbox.Text);
            foreach(DataGridViewRow row in CompulsorySubjectsGridView.Rows)
                //same id
               if (checked_subjects_id.Contains((int)row.Cells[2].Value))
                    row.Cells[0].Value = true;
        }
        
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void floorsHeightPreferenceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool state = floorsHeightPreferenceToolStripMenuItem.Checked;
            floorsHeightPreferenceToolStripMenuItem.Checked = !state;
        }

        private void newSelectionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SelectionForm form = new SelectionForm();
            form.Show(this);
        }
    }
}
