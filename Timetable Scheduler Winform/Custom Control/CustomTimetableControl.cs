using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TimetableData.Model;

namespace TimetableSchedulerWinform
{
    public partial class TableCustomControl : UserControl
    {
        public void Init_Table(DataGridView Table)
        {
            foreach (DayOfWeek day in Enum.GetValues(typeof(DayOfWeek)))
                Table.Columns.Add(new DataGridViewColumn()
                {
                    CellTemplate = new DataGridViewTextBoxCell() { },
                    HeaderText = day.ToString(),
                    Width = 80,
                    Resizable = DataGridViewTriState.False
                });

            for (int i = 1; i <= 16; ++i)
                Table.Rows.Add(new DataGridViewRow()
                {
                    Resizable = DataGridViewTriState.False,
                    HeaderCell = new DataGridViewRowHeaderCell()
                    {
                        Value = i.ToString(),
                    },
                });

            //Table.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode;
            Table.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            Table.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            Table.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            Table.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            Table.ColumnHeadersDefaultCellStyle = new DataGridViewCellStyle()
             {
                 Alignment = DataGridViewContentAlignment.MiddleCenter
             };
            Table.AutoSize = true;
            
        }

        public TableCustomControl()
        {
            InitializeComponent();
            Init_Table(Table);
            //AutoSize = true;
            Width = Table.Width + 4;
            Height = Table.Height + 4;
            //Dock = DockStyle.Fill;
        }

        public void AddSubjectAndTimes(Subject subject, List<LectureTime> times)
        {
            foreach (LectureTime time in times)
                for (int i = time.Start_Period; i <= time.End_Period; ++i)
                    Table[(int)time.Day, i - 1].Value = subject.Codename;
        }

        public void AddSubjectSelection(SubjectSelection selection)
        {
            foreach (LectureTime time in selection.Times)
                for (int i = time.Start_Period; i <= time.End_Period; ++i)
                    Table[(int)time.Day, i - 1].Value = selection.Subject.Codename;
        }

        public void RemoveSubjectSelection(SubjectSelection selection)
        {
            foreach (LectureTime time in selection.Times)
                for (int i = time.Start_Period; i <= time.End_Period; ++i)
                    if (Table[(int)time.Day, i].Value.ToString()
                        == selection.Subject.Codename)
                        Table[(int)time.Day, i].Value = "";
        }

        public void ResetSubjectSelections()
        {
            for (int i = 0; i < Table.Columns.Count; ++i)
                for (int j = 0; j < Table.Rows.Count; ++j)
                    if (!string.IsNullOrEmpty(Table[i, j].Value.ToString()))
                        Table[i, j].Value = "";
        }

        public void SetDeniedLectureTimes()
        {
            foreach(DataGridViewCell cell in Table.SelectedCells)
                cell.Style.BackColor = Color.Red;
            
            Table.ClearSelection();
        }

        public void SetPreferredLectureTimes()
        {
            foreach (DataGridViewCell cell in Table.SelectedCells)
                cell.Style.BackColor = Color.Green;
            Table.ClearSelection();
        }

        public void ResetSelectedTimes()
        {
            foreach (DataGridViewCell cell in Table.SelectedCells)
                cell.Style.BackColor = Table.DefaultCellStyle.BackColor;
            Table.ClearSelection();
        }

        public void ResetLectureTimes()
        {
            for (int i = 0; i < Table.Columns.Count; ++i)
                for (int j = 0; j < Table.Rows.Count; ++j)
                {
                    if (Table[i, j].Style.BackColor != DefaultBackColor)
                        Table[i, j].Style.BackColor = Color.White;
                    Table[i, j].Value = "";
                }
        }

        public bool IsSelectedCell(DataGridViewCell cell)
        {
            return cell.Selected;
        }

        public bool IsPreferredCell(DataGridViewCell cell)
        {
            return cell.Style.BackColor == Color.Green;
        }

        public bool IsDeniedCell(DataGridViewCell cell)
        {
            return cell.Style.BackColor == Color.Red;
        }

        public List<LectureTime> GetLectureTimes(Func<DataGridViewCell, bool> CellCheckingCondition)
        {
            List<LectureTime> Times = new List<LectureTime>();

            for (int i = 0; i < Table.Columns.Count; ++i)
            {
                int j = 0, k;
                while (j < Table.Rows.Count)
                {
                    if (CellCheckingCondition(Table[i, j]))
                    {
                        for (k = j; k < Table.Rows.Count; ++k)
                            if (!CellCheckingCondition(Table[i, j]))
                                break;
                        Times.Add(new LectureTime((DayOfWeek)i, j + 1, k));
                        j = k + 1;
                    }
                    else
                        ++j;
                }
            }

            return Times;
        }
    }
}