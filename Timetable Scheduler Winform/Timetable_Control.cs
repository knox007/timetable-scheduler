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
        public void Init_Table(TenTec.Windows.iGridLib.iGrid Timetable)
        {
            /*foreach(DayOfWeek day in Enum.GetValues(typeof(DayOfWeek)))
                Timetable.Columns.Add(new DataGridViewTextBoxColumn()
                {
                    HeaderText = day.ToString(),
                    Name = day.ToString(),
                    AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                });

            /*for (int i = 1; i <= 16; ++i)
                Timetable.Rows.Add(new DataGridViewRow()
                {
                    Resizable = DataGridViewTriState.False,
                    HeaderCell = new DataGridViewRowHeaderCell()
                    {
                        Value = i.ToString()
                    }
                });
            Timetable.RowHeadersWidthSizeMode
                = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;*/
            
            Timetable.Dock = DockStyle.Fill;
        }

        public Timetable_Control()
        {
            InitializeComponent();
            Init_Table(iGrid1);
            Dock = DockStyle.Fill;
            Timetable.Visible = false;
            
        }
        
    }
}
