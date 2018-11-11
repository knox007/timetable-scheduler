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
            LecturersGridView.Columns["Name"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            LecturersGridView.Columns["Name"].ReadOnly = true;

            LecturersGridView.Columns["Select"].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            LecturersGridView.CellValueChanged += LecturersGridView_CellValueChanged;
            LecturersGridView.CellMouseUp += LecturersGridView_CellMouseUp;
            LecturersGridView.CellMouseDown += LecturersGridView_CellMouseDown;

            LecturersGridView.AllowUserToAddRows = false;
            LecturersGridView.AllowUserToDeleteRows = false;
            LecturersGridView.AllowUserToOrderColumns = false;
            LecturersGridView.AllowUserToResizeColumns = false;
            LecturersGridView.AllowUserToResizeRows = false;

            LecturersGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            LecturersGridView.MultiSelect = false;
        }

        private void LecturersGridView_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
        }

        private void LecturersGridView_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.ColumnIndex == 0)
                LecturersGridView.EndEdit();
        }

        private void LecturersGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == 0)
            {
                bool id_checked = (bool)LecturersGridView["Select", e.RowIndex].Value;
                int id = (int)LecturersGridView["Id", e.RowIndex].Value;
                if (id_checked)
                    checked_lecturers_id.Add(id);
                else
                    checked_lecturers_id.Remove(id);
            }
        }

        private void LecturerFilteringTextbox_TextChanged(object sender, EventArgs e)
        {
            all_lecturers.DefaultView.RowFilter
                = String.Format("Name LIKE '%{0}%'", LecturerFilteringTextbox.Text);
            int id;
            for(int i = 0; i < LecturersGridView.Rows.Count; ++i)
            {
                id = (int)LecturersGridView["Id", i].Value;
                if (checked_lecturers_id.Contains(id))
                    LecturersGridView["Select", i].Value = true;
            }   
        }
        
        private void newLecturerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LecturerForm form = new LecturerForm();
            form.SetLecturer(new Lecturer());
            form.Show(this);

            form.FormClosed += LecturerForm_Closed;
        }

        private void editLecturerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LecturerForm form = new LecturerForm();
            int index = LecturersGridView.CurrentCell.RowIndex;
            form.SetLecturer(new Lecturer()
            {
                Id = (int)LecturersGridView["Id", index].Value,
                Name = LecturersGridView["Name", index].Value.ToString()
            });
            form.Show(this);

            form.FormClosed += LecturerForm_Closed;
        }

        private void deleteLecturerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!CustomMessages.YesNoDelete(this)) return;

            int index = LecturersGridView.CurrentCell.RowIndex,
                id = (int)LecturersGridView["Id", index].Value;

            //delete from database
            new LecturerController().Delete(new Lecturer()
            {
                Id = id,
                Name = LecturersGridView["Name", index].Value.ToString()
            });

            //remove from datatable
            foreach (DataRow row in all_lecturers.Rows)
            {
                if (Convert.ToInt32(row["Id"]) == id)
                {
                    all_lecturers.Rows.Remove(row);
                    break;
                }
            }
        }

        private void LecturerForm_Closed(object sender, FormClosedEventArgs e)
        {
            LecturerForm form = (LecturerForm)sender;
            if (form.InsertedLecturers.Count > 0)
            {
                foreach (Lecturer lecturer in form.InsertedLecturers)
                    all_lecturers.Rows.Add(lecturer.Id, lecturer.Name);
                LecturersGridView["Select", LecturersGridView.Rows.Count - 1].Selected = true;
            }
            else if(!form.New)
            {
                int index = LecturersGridView.CurrentCell.RowIndex;
                foreach(DataRow row in all_lecturers.Rows)
                {
                    if (Convert.ToInt32(row["Id"])
                        == Convert.ToInt32(LecturersGridView["Id", index].Value))
                    {
                        if (form.Deleted)
                            all_lecturers.Rows.Remove(row);
                        else
                            row["Name"] = form.deep_copy.Name;
                        break;
                    }
                }
            }
        }

        
    }
}
