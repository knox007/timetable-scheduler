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

namespace TimetableSchedulerWinform.CustomForm
{
    public partial class LecturersOptionForm : Form
    {
        DataTable preferred_lecturers,
            denied_lecturers;
        HashSet<int> preferred_lecturers_id,
            denied_lectrers_id;

        public LecturersOptionForm()
        {
            InitializeComponent();
            LoadData();
        }

        public List<Lecturer> GetPreferredLecturers()
        {
            List<Lecturer> lecturers = new List<Lecturer>();

            return lecturers;
        }

        public List<Lecturer> GetDeniedLecturers()
        {
            throw new Exception("Not implementated yet.");
        }

        private void PreferredFilter_TextChanged(object sender, EventArgs e)
        {
            preferred_lecturers.DefaultView.RowFilter 
                = string.Format("Name LIKE '%{0}%'", PreferredFilter.Text);
        }

        private void DeniedFilter_TextChanged(object sender, EventArgs e)
        {
            denied_lecturers.DefaultView.RowFilter
                = string.Format("Name LIKE '%{0}%'", DeniedFilter.Text);
        }

        private void LoadData()
        {
            preferred_lecturers = new DataTable();
            denied_lecturers = new DataTable();

            List<Lecturer> all_lecturers = new LecturerController().GetAll();
            using (var reader = ObjectReader.Create(all_lecturers))
                preferred_lecturers.Load(reader);
            using (var reader = ObjectReader.Create(all_lecturers))
                denied_lecturers.Load(reader);

            PreferredLecturersCheckedListBox.DataSource = preferred_lecturers;
            PreferredLecturersCheckedListBox.DisplayMember = "Name";
            PreferredLecturersCheckedListBox.ValueMember = "Id";
            DeniedLecturersCheckedListBox.DataSource = denied_lecturers;
            DeniedLecturersCheckedListBox.DisplayMember = "Name";
            DeniedLecturersCheckedListBox.ValueMember = "Id";
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
        }
    }
}
