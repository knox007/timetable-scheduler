using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TimetableData.Control;
using TimetableData.Model;

namespace TimetableSchedulerWinform.CustomControl
{
    public partial class SubjectForm : Form, GenericForm<Subject>
    {
        private SubjectController controller;
        private Subject subject, deep_copy;
        private List<Subject> inserted_subjects;

        public SubjectForm()
        {
            InitializeComponent();

            inserted_subjects = new List<Subject>();
            controller = new SubjectController();

            FormClosed += CheckOnClosed;
        }

        private void CheckOnClosed(object sender, FormClosedEventArgs e)
        {
            if (!updated //not updated
                && !deleted //not deleted
                && inserted_subjects.Count == 0) //not inserted
            { //revert changes
                subject.Name = deep_copy.Name;
                subject.Codename = deep_copy.Codename;
            }
        }

        private bool new_value, updated, deleted;
        public bool New
        {
            get { return new_value; }
            set
            {
                if (value)
                {
                    AcceptButton.Text = "New";
                    DeclineButton.Text = "Reset";
                }
                else
                {
                    AcceptButton.Text = "Update";
                    DeclineButton.Text = "Delete";
                }

                new_value = value;
            }
        }

        public bool Updated => updated;
        public bool Deleted => deleted;

        public bool DeleteModel()
        {
            return deleted = ((MessageBox.Show("Do you really want to delete this?",
                "Warning!", MessageBoxButtons.YesNo) == DialogResult.Yes)
                && controller.Delete(subject));
        }

        public Subject GetModel()
        {
            return subject;
        }

        public List<Subject> InsertedModels()
        {
            return inserted_subjects;
        }

        public int InsertModel()
        {
            int id = (int)controller.Insert(subject);
            inserted_subjects.Add(subject);
            if (MessageBox.Show(this, "The lecturer has been added. " +
                "Do you want to continue?", "Success. Continue?",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                SetModel(new Subject());
            else
                Close();
            return id;
        }

        private void DeclineButton_Click(object sender, EventArgs e)
        {
            if (New)
            {
                NameTextbox.Text = "";
                CodenameTextbox.Text = "";
            }
            else if (DeleteModel()) //done deleting
                Close();
        }

        public void SetModel(Subject model)
        {
            New = (model.Id == 0);
            deep_copy = new Subject()
            {
                Id = model.Id,
                Name = model.Name,
                Codename = model.Codename
            };

            subject = model;

            NameTextbox.DataBindings.Clear();
            CodenameTextbox.DataBindings.Clear();
            NameTextbox.DataBindings.Add("Text", subject, "Name", false, DataSourceUpdateMode.OnPropertyChanged);
            CodenameTextbox.DataBindings.Add("Text", subject, "Codename", false, DataSourceUpdateMode.OnPropertyChanged);
        }

        public bool UpdateModel()
        {
            if (updated = controller.Update(subject))
            {
                MessageBox.Show(this, "The lecturer has been updated.", "Caption",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                //updated = false;
                deep_copy = new Subject()
                {
                    Id = subject.Id,
                    Name = subject.Name,
                    Codename = subject.Codename
                };
            }

            return updated;
        }

        private void AcceptButton_Click(object sender, EventArgs e)
        {
            if (New)
                InsertModel();
            else
                UpdateModel();
        }
    }
}
