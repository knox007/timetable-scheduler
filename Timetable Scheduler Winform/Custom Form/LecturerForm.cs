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
    public partial class LecturerForm : Form
    {
        public Lecturer lecturer, deep_copy;
        LecturerController controller;

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
        public List<Lecturer> InsertedLecturers;

        public LecturerForm()
        {
            InitializeComponent();
            controller = new LecturerController();
            InsertedLecturers = new List<Lecturer>();

            FormClosed += LecturerForm_Closed;
        }

        private void LecturerForm_Closed(object sender, FormClosedEventArgs e)
        {
            if(!Deleted
                && InsertedLecturers.Count == 0)
            {
                lecturer.Name = deep_copy.Name;
            }
        }
        
        public void SetLecturer(Lecturer lecturer)
        {
            this.lecturer = lecturer;
            deep_copy = new Lecturer(lecturer);
            New = (lecturer.Id == 0);

            NameTextbox.DataBindings.Clear();
            NameTextbox.DataBindings.Add("Text", 
                lecturer, "Name", false, 
                DataSourceUpdateMode.OnPropertyChanged);
        }

        private void DeclineButton_Click(object sender, EventArgs e)
        {
            if(New)
            {
                NameTextbox.Text = "";
            }
            else if(CustomMessages.YesNoDelete(this))
            {
                Deleted = controller.Delete(lecturer);
                
                Close();
            }
        }

        private void AcceptButton_Click(object sender, EventArgs e)
        {
            if(New)
            {
                if(controller.Insert(lecturer) > 0)
                {
                    InsertedLecturers.Add(lecturer);
                    if (CustomMessages.YesNoNext(this, "lecturer"))
                        SetLecturer(new Lecturer());
                    else
                        Close();
                }
            }
            else
            {
                if(controller.Update(lecturer))
                {
                    CustomMessages.Updated(this, "lecturer");
                    SetLecturer(lecturer);
                }
            }
        }
    }
}
