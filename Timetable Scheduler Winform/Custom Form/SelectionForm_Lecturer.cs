using FastMember;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TimetableData.Controller;

namespace TimetableSchedulerWinform.CustomForm
{
    partial class SelectionForm
    {
        DataTable all_lecturers;
        HashSet<int> checked_lecturers_id;

        private void InitializeLecturers()
        {
            all_lecturers = new DataTable();
            checked_lecturers_id = new HashSet<int>();
            using (var reader = ObjectReader.Create(new LecturerController().GetAll()))
                all_lecturers.Load(reader);
            LecturersGridView.DataSource = all_lecturers;

            LecturersGridView.ColumnHeadersDefaultCellStyle = new DataGridViewCellStyle
            {
                Alignment = DataGridViewContentAlignment.MiddleCenter
            };
            LecturersGridView.Columns.Add(new DataGridViewCheckBoxColumn()
            {
                Name = "Select"
            });

            LecturersGridView.Columns["Id"].Visible = false;
            LecturersGridView.Columns["Name"].Visible = false;
            LecturersGridView.Columns["Name"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            LecturersGridView.Columns["Name"].ReadOnly = true;

            LecturersGridView.Columns["Select"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            LecturersGridView.CellValueChanged += LecturersGridView_CellValueChanged;
            LecturersGridView.CellMouseUp += LecturersGridView_CellMouseUp;

            LecturersGridView.AllowUserToAddRows = false;
            LecturersGridView.AllowUserToDeleteRows = false;
            LecturersGridView.AllowUserToOrderColumns = false;
            LecturersGridView.AllowUserToResizeColumns = false;
            LecturersGridView.AllowUserToResizeRows = false;

            LecturersGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            LecturersGridView.MultiSelect = false;
        }

        private void LecturersGridView_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void LecturersGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
