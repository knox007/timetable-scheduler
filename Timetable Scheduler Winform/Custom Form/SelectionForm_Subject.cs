using System;
using System.Collections.Generic;
using System.Data;
using FastMember;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TimetableData.Controller;
using TimetableData.Model;
using System.ComponentModel;

namespace TimetableSchedulerWinform.CustomForm
{
    partial class SelectionForm
    {
        BindingList<Subject> all_subjects;
        private void InitializeSubjects()
        {
            all_subjects = new BindingList<Subject>(new SubjectController().GetAll());
            SubjectCombobox.DataSource = all_subjects;
        }

        private void SubjectAcceptButton_Click(object sender, EventArgs e)
        {
            SubjectForm form = new SubjectForm();
            form.SetSubject(new Subject());
            form.Show();

            form.FormClosed += SubjectForm_FormClosed;
        }

        private void SubjectDeclineButton_Click(object sender, EventArgs e)
        {
            SubjectForm form = new SubjectForm();
            form.SetSubject((Subject)SubjectCombobox.SelectedItem);
            form.Show();

            form.FormClosed += SubjectForm_FormClosed;
        }

        private void SubjectForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            SubjectForm form = (SubjectForm)sender;
            if (form.InsertedSubjects.Count > 0)
            {
                foreach (Subject subject in form.InsertedSubjects)
                    all_subjects.Add(subject);
                SubjectCombobox.SelectedIndex = SubjectCombobox.Items.Count - 1;
            }
                
            else if (form.Deleted)
                all_subjects.RemoveAt(SubjectCombobox.SelectedIndex);
        }
    }
}
