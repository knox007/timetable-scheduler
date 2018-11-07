using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TimetableData.Control;
using TimetableData.Model;

namespace TimetableSchedulerWinform.CustomControl
{
    public partial class LecturerUserControl : UserControl
    {
        LecturerController controller;
        BindingList<Lecturer> all_lecturers;
        public LecturerUserControl()
        {
            InitializeComponent();

            controller = new LecturerController();
            all_lecturers = new BindingList<Lecturer>(controller.Get_All());
            LecturersCheckedListBox.DataSource = all_lecturers;
        }

        private void LecturersCheckedListBox_MouseDown(object sender, MouseEventArgs e)
        {
            LecturersCheckedListBox.SelectedIndex
                = LecturersCheckedListBox.IndexFromPoint(e.X, e.Y);
        }

        private void NewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LecturerForm form = new LecturerForm();
            form.SetModel(new Lecturer());
            form.Show();

            form.FormClosed += CheckOnClosed;
        }

        private void CheckOnClosed(object sender, FormClosedEventArgs e)
        {
            LecturerForm form = (LecturerForm)sender;
            Lecturer lecturer = (Lecturer)LecturersCheckedListBox.SelectedItem;

            if (form.Deleted)
                all_lecturers.Remove(lecturer);
            else if (form.InsertedModels().Count > 0)
            {
                foreach (Lecturer new_lecturer in form.InsertedModels())
                    all_lecturers.Add(new_lecturer);
                LecturersCheckedListBox.SelectedIndex
                    = LecturersCheckedListBox.Items.Count - 1;
            }
                
        }

        private void UpdateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LecturerForm form = new LecturerForm();
            form.SetModel((Lecturer)LecturersCheckedListBox.SelectedItem);
            form.Show();

            form.FormClosed += CheckOnClosed;
        }

        private void DeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Lecturer lecturer = (Lecturer)LecturersCheckedListBox.SelectedItem;
            all_lecturers.Remove(lecturer);
            controller.Delete(lecturer);
        }

        public List<Lecturer> GetSelectedLecturers()
        {
            return LecturersCheckedListBox.SelectedItems
                .Cast<Lecturer>().ToList();
        }
    }
}
