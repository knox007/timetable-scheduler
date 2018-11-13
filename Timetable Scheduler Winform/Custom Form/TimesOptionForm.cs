using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TimetableData.Model;
using TimetableSchedulerWinform.CustomControl;

namespace TimetableSchedulerWinform.CustomForm
{
    public partial class TimesOptionForm : Form
    {
        public TimesOptionForm()
        {
            InitializeComponent();
        }

        public List<LectureTime> preferred_times,
            denied_times;

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

        private void OkayButton_Click(object sender, EventArgs e)
        {
            preferred_times = TimetableControl.GetLectureTimes(TimetableControl.IsPreferredCell);
            denied_times = TimetableControl.GetLectureTimes(TimetableControl.IsDeniedCell);
            if(preferred_times.Count > 0 || denied_times.Count > 0)
                CustomMessages.OptionsSaved(this);
            Hide();
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            TimetableControl.ResetLectureTimes();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Hide();
        }
    }
}
