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
    public partial class OptimizedSelectionsForm : Form
    {
        DataTable all_selections;
        public List<SubjectSelection> selections;

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

            foreach (SubjectSelection selection in selections)
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

        public OptimizedSelectionsForm()
        {
            InitializeComponent();
            selections = new List<SubjectSelection>();
        }

        public void SetData(List<SubjectSelection> selections)
        {
            this.selections = selections;
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
    }
}
