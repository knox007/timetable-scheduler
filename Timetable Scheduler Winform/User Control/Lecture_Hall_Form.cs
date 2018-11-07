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
using TimetableData.Control;

namespace TimetableSchedulerWinform.CustomControl
{
    public partial class LectureHallForm : Form, GenericForm<LectureHall>
    {
        private LectureHallController controller;
        private LectureHall hall, deep_copy;
        private List<LectureHall> inserted_halls;
        private bool new_value;
        public bool New
        {
            get
            {
                return new_value;
            }
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

        public LectureHallForm()
        {
            InitializeComponent();

            inserted_halls = new List<LectureHall>();
            controller = new LectureHallController();
            FloorNumericUpdown.Maximum = 100;
            FloorNumericUpdown.Minimum = 0;

            FormClosed += CheckOnClosed;
        }

        private void CheckOnClosed(object sender, FormClosedEventArgs e)
        {
            if (!updated && //not updated
                !deleted && //not deleted
                inserted_halls.Count == 0) //not inserted
            {
                hall.Building = deep_copy.Building;
                hall.Floor = deep_copy.Floor;
                hall.Room = deep_copy.Room;
            }
        }

        private bool updated;
        public bool Updated => updated;

        private bool deleted;
        public bool Deleted => deleted;

        public bool DeleteModel()
        {
            if (MessageBox.Show("Do you really want to delete this?",
                "Warning!", MessageBoxButtons.YesNo) == DialogResult.Yes)
                return (deleted = controller.Delete(hall));
            return false;
        }

        public LectureHall GetModel()
        {
            return hall;
        }

        public List<LectureHall> InsertedModels()
        {
            return inserted_halls;
        }

        public int InsertModel()
        {
            int id = (int)controller.Insert(hall);
            inserted_halls.Add(hall);
            if (MessageBox.Show(this, "The lecturer has been added. " +
                "Do you want to continue?", "Success. Continue?",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                SetModel(new LectureHall());
            else
                Close();
            return id;
        }

        public void SetModel(LectureHall model)
        {
            New = (model.Id == 0);

            deep_copy = new LectureHall()
            {
                Id = model.Id,
                Building = model.Building,
                Floor = model.Floor,
                Room = model.Room
            };

            hall = model;

            BuildingTextbox.DataBindings.Clear();
            FloorNumericUpdown.DataBindings.Clear();
            RoomTextbox.DataBindings.Clear();

            BuildingTextbox.DataBindings.Add("Text",
                hall, "Building", false, DataSourceUpdateMode.OnPropertyChanged);
            FloorNumericUpdown.DataBindings.Add("Value",
                hall, "Floor", false, DataSourceUpdateMode.OnPropertyChanged);
            RoomTextbox.DataBindings.Add("Text",
                hall, "Room", false, DataSourceUpdateMode.OnPropertyChanged);
        }

        public bool UpdateModel()
        {
            if(updated = controller.Update(hall))
            {
                MessageBox.Show(this, "The lecturer has been updated.", "Caption",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                updated = false;
                deep_copy = new LectureHall()
                {
                    Id = hall.Id,
                    Building = hall.Building,
                    Floor = hall.Floor,
                    Room = hall.Room
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

        private void DeclineButton_Click(object sender, EventArgs e)
        {
            if (New)
            {
                BuildingTextbox.Text = "";
                FloorNumericUpdown.Value = 1;
                RoomTextbox.Text = "";
            }
            else if (DeleteModel())
                Close();
        }
    }
}
