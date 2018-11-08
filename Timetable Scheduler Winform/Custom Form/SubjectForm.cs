using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TimetableData.Controller;
using TimetableData.Model;
using TimetableSchedulerWinform.CustomControl;

namespace TimetableSchedulerWinform.CustomForm
{
    public partial class SubjectForm : Form
    {
        Subject subject, deep_copy;
        SubjectController controller;

        private bool new_value;
        public bool New
        {
            get
            {
                return new_value;
            }
            set
            {
                if(value)
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
        
        public bool Deleted { get; private set; }
        public List<Subject> InsertedSubjects { get; private set; }

        public SubjectForm()
        {
            InitializeComponent();
            controller = new SubjectController();
            InsertedSubjects = new List<Subject>();

            FormClosed += SubjectForm_Closed;
        }

        private void SubjectForm_Closed(object sender, FormClosedEventArgs e)
        {
            if (!Deleted //not deleted
                && InsertedSubjects.Count == 0) //not inserted
            {
                subject.Name = deep_copy.Name;
                subject.Codename = deep_copy.Codename;
            }
        }

        public void SetSubject(Subject subject)
        {
            this.subject = subject;
            deep_copy = new Subject(subject);
            New = (subject.Id == 0);

            NameTextbox.DataBindings.Clear();
            CodenameTextbox.DataBindings.Clear();

            NameTextbox.DataBindings.Add("Text", this.subject, "Name",
                false, DataSourceUpdateMode.OnPropertyChanged);
            CodenameTextbox.DataBindings.Add("Text", this.subject, "Codename",
                false, DataSourceUpdateMode.OnPropertyChanged);
        }

        private void DeclineButton_Click(object sender, EventArgs e)
        {
            if(New)
            {
                NameTextbox.Text = "";
                CodenameTextbox.Text = "";
            }
            else if(CustomMessages.YesNoDelete(this))
            {
                Deleted = controller.Delete(subject);
                Close();
            }
        }

        private void AcceptButton_Click(object sender, EventArgs e)
        {
            if (New) //creating new subject
            {
                if (controller.Insert(subject) > 0)
                {
                    InsertedSubjects.Add(subject);
                    if (CustomMessages.YesNoNext(this, "subject"))
                        SetSubject(new Subject());
                    else
                        Close();
                }
            }
            else //updating existed subject
            {
                if (controller.Update(subject))
                {
                    CustomMessages.Updated(this, "subject");
                    SetSubject(subject);
                }
            }
        }
    }
}
