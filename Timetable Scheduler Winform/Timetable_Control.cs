using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Timetable_Scheduler_Winform
{
    public partial class Timetable_Control : UserControl
    {
        public void Init_Table(ref DataGridView Timetable)
        {
            foreach (DayOfWeek d in Enum.GetValues(typeof(DayOfWeek)))
                Timetable.Columns.Add(new DataGridViewTextBoxColumn
                {
                    AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells,
                    Resizable = DataGridViewTriState.False,
                    HeaderText = d.ToString()
                });

            for (int i = 1; i <= 16; ++i)
                Timetable.Rows.Add(new DataGridViewRow()
                {
                    Resizable = DataGridViewTriState.False,
                    HeaderCell = new DataGridViewRowHeaderCell()
                    {
                        Value = i.ToString()
                    }
                });
            Timetable.RowHeadersWidthSizeMode
                = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;

            Timetable.Dock = DockStyle.Fill;
        }

        public Timetable_Control()
        {
            InitializeComponent();
            Init_Table(ref Timetable);
            Dock = DockStyle.Fill;
        }
    }
}
