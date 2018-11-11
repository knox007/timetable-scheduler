using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimetableSchedulerWinform.CustomForm
{
    public partial class TimesOptionForm : Form
    {
        public TimesOptionForm()
        {
            InitializeComponent();
        }

        private void addPreferredTimesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TimetableControl.SetPreferredLectureTimes();
        }

        private void addDeniedTimesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TimetableControl.SetDeniedLectureTimes();
        }

        private void resetAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TimetableControl.ResetLectureTimes();
        }

        private void resetSelectedTimesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TimetableControl.ResetSelectedTimes();
        }
    }
}
