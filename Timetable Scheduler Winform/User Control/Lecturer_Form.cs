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
    public partial class Lecturer_Form : Form, GenericForm<Lecturer>
    {
        private Lecturer_Controller controller;
        private Lecturer lecturer, deep_copy;
        private List<Lecturer> inserted_lecturers;
        private bool new_value, updated, deleted;
        public bool New
        {
            get { return new_value; }
            set
            {
                if(value)
                {
                    Accept_Button.Text = "New";
                    Decline_Button.Text = "Reset";
                }
                else
                {
                    Accept_Button.Text = "Update";
                    Decline_Button.Text = "Delete";
                }

                new_value = value;
            }
        }

        public Lecturer_Form(Lecturer lecturer)
        {
            InitializeComponent();
            
            SetModel(lecturer);
            controller = new Lecturer_Controller();
            inserted_lecturers = new List<Lecturer>();
            
            updated = false;
            deleted = false;

            FormClosed += Check_On_Closed;
        }

        private void Check_On_Closed(object sender, FormClosedEventArgs e)
        {
            if(!updated && //not updated
                !deleted && //not deleted
                inserted_lecturers.Count == 0) //not inserted
            {
                lecturer.Name = deep_copy.Name; //revert changes
            }
        }

        public Lecturer_Form() : this(new Lecturer())
        {
            
        }

        public void SetModel(Lecturer model)
        {
            lecturer = model;

            deep_copy = new Lecturer()
            {
                Id = model.Id,
                Name = model.Name
            };

            New = (lecturer.Id == 0);

            Name_Textbox.DataBindings.Clear();
            Name_Textbox.DataBindings.Add("Text",
                lecturer, "Name", false,
                DataSourceUpdateMode.OnPropertyChanged);
        }

        public Lecturer GetModel()
        {
            return lecturer;
        }

        public int InsertModel()
        {
            int id = (int)controller.Insert(lecturer);
            inserted_lecturers.Add(lecturer);
            if (MessageBox.Show(this, "The lecturer has been added. " +
                "Do you want to continue?", "Success. Continue?",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                SetModel(new Lecturer());
            else
                Close();
            return id;
        }

        public bool DeleteModel()
        {
            if (MessageBox.Show("Do you really want to delete this?",
                "Warning!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                return (deleted = controller.Delete(lecturer));
            }

            return false;
        }

        public bool UpdateModel()
        {
            if (updated = controller.Update(lecturer))
                MessageBox.Show(this, "The lecturer has been updated.", "Caption",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            return updated;
        }

        private void Accept_Button_Click(object sender, EventArgs e)
        {
            if (New)
                InsertModel();
            else
                UpdateModel();
        }

        private void Decline_Button_Click(object sender, EventArgs e)
        {
            if (New)
                Name_Textbox.Text = "";
            else if(DeleteModel())
                Close();
        }

        public List<Lecturer> InsertedModels()
        {
            return inserted_lecturers;
        }

        public bool Updated => updated;

        public bool Deleted => deleted;
    }
}
