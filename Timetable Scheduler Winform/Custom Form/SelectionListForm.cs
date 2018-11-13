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
    public partial class SelectionListForm : Form
    {
        DataTable all_selections;
        SubjectSelectionController controller = new SubjectSelectionController();

        private void AddToTable(SubjectSelection selection)
        {
            all_selections.Rows.Add(
                selection.Id,
                selection.Subject,
                selection.Hall,
                Lecturer.LecturersToString(selection.Lecturers),
                LectureTime.TimeListToString(selection.Times),
                selection.ToString()
            );
        }

        private void InitializeData()
        {
            all_selections = new DataTable();
            all_selections.Columns.Add("Id");
            all_selections.Columns.Add("Subject");
            all_selections.Columns.Add("Hall");
            all_selections.Columns.Add("Lecturers");
            all_selections.Columns.Add("Times");
            all_selections.Columns.Add("Filter");

            foreach (SubjectSelection selection in controller.GetAll())
                AddToTable(selection);

            SelectionsGridView.DataSource = all_selections;
            SelectionsGridView.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            SelectionsGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            SelectionsGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            SelectionsGridView.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            SelectionsGridView.ReadOnly = true;

            SelectionsGridView.AllowUserToAddRows = false;
            SelectionsGridView.AllowUserToDeleteRows = false;
            SelectionsGridView.AllowUserToOrderColumns = false;
            SelectionsGridView.AllowUserToResizeColumns = false;
            SelectionsGridView.AllowUserToResizeRows = false;
            SelectionsGridView.MultiSelect = false;
            SelectionsGridView.RowHeadersVisible = false;

            SelectionsGridView.Columns["Filter"].Visible = false;
            SelectionsGridView.Columns["Id"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            SelectionsGridView.Columns["Times"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            SelectionsGridView.Columns["Hall"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            SelectionsGridView.Columns["Subject"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            
        }

        public SelectionListForm()
        {
            InitializeComponent();
            InitializeData();
        }

        private void SelectionFilteringTextbox_TextChanged(object sender, EventArgs e)
        {
            string filter = SelectionFilteringTextbox.Text,
                query = "";
            string[] words = filter.Split(' ');
            if (words.Length == 0) return;

            for(int i = 0; i < words.Length - 1; ++i)
                query += string.Format("(Filter LIKE '%{0}%') AND", words[i]);
            query += string.Format("(Filter LIKE '%{0}%')", words[words.Length - 1]);

            all_selections.DefaultView.RowFilter = query;
        }

        private void SelectionFormPopup(SubjectSelection selection)
        {
            SelectionForm form = new SelectionForm();
            form.SetSelection(selection);
            form.Show();

            form.FormClosed += SelectionForm_Closed;
        }

        private void InsertButton_Click(object sender, EventArgs e)
        {
            SelectionFormPopup(new SubjectSelection());
        }
        
        private void UpdateButton_Click(object sender, EventArgs e)
        {
            if (SelectionsGridView.Rows.Count == 0)
            {
                CustomMessages.ChooseBeforeCarryOn(this, "a selection");
                return;
            }
                

            int index = SelectionsGridView.CurrentCell.RowIndex,
                id = Int32.Parse(SelectionsGridView["Id", index].Value.ToString());
            SelectionFormPopup(controller.Get(id));
        }

        private void RemoveCurrentSelection()
        {
            if (SelectionsGridView.Rows.Count == 0)
            {
                CustomMessages.SelectFail(this);
                return;
            }
                

            int index = SelectionsGridView.CurrentCell.RowIndex,
                id = Convert.ToInt32(SelectionsGridView["Id", index].Value);
            controller.Delete(new SubjectSelection()
            {
                Id = id
            });
            RemoveFromTableById(id);
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            RemoveCurrentSelection();
        }

        private void SelectionForm_Closed(object sender, FormClosedEventArgs e)
        {
            SelectionForm form = (SelectionForm)sender;
            if (form.InsertedSelections.Count > 0)
                foreach (SubjectSelection selection in form.InsertedSelections)
                    AddToTable(selection);
            else if (form.Deleted)
                RemoveCurrentSelection();
            else if (form.Updated)
            {
                UpdateInTable(controller.Get(form.deep_copy.Id));
            }
        }

        private void RemoveFromTableById(int id)
        {
            foreach(DataRow row in all_selections.Rows)
                if(Convert.ToInt32(row["Id"]) == id)
                {
                    all_selections.Rows.Remove(row);
                    break;
                }
        }

        private void UpdateInTable(SubjectSelection selection)
        {
            foreach (DataRow row in all_selections.Rows)
                if (Convert.ToInt32(row["Id"]) == selection.Id)
                {
                    row["Subject"] = selection.Subject;
                    row["Hall"] = selection.Hall;
                    row["Lecturers"] = Lecturer.LecturersToString(selection.Lecturers);
                    row["Times"] = LectureTime.TimeListToString(selection.Times);
                    row["Filter"] = selection.ToString();
                }
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SelectionFormPopup(new SubjectSelection());
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int index = SelectionsGridView.CurrentCell.RowIndex,
                id = Int32.Parse(SelectionsGridView["Id", index].Value.ToString());
            SelectionFormPopup(controller.Get(id));
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RemoveCurrentSelection();
        }
    }
}
