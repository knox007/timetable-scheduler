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
    public partial class LectureHallForm : Form
    {
        LectureHall hall, deep_copy;
        LectureHallController controller;

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
        public List<LectureHall> InsertedHalls { get; private set; }

        public LectureHallForm()
        {
            InitializeComponent();
            controller = new LectureHallController();
            InsertedHalls = new List<LectureHall>();

            FormClosed += LectureHallForm_Closed;
        }

        private void LectureHallForm_Closed(object sender, FormClosedEventArgs e)
        {
            if(!Deleted
                && InsertedHalls.Count == 0)
            { //revert changes
                hall.Building = deep_copy.Building;
                hall.Floor = deep_copy.Floor;
                hall.Room = deep_copy.Room;
            }
        }

        public void SetHall(LectureHall hall)
        {
            this.hall = hall;
            deep_copy = new LectureHall(hall);
            New = (hall.Id == 0);

            BuildingTextbox.DataBindings.Clear();
            FloorNumericUpdown.DataBindings.Clear();
            RoomTextbox.DataBindings.Clear();

            BuildingTextbox.DataBindings.Add("Text",
                hall, "Building", false, 
                DataSourceUpdateMode.OnPropertyChanged);
            FloorNumericUpdown.DataBindings.Add("Value",
                hall, "Floor", false,
                DataSourceUpdateMode.OnPropertyChanged);
            RoomTextbox.DataBindings.Add("Text",
                hall, "Room", false,
                DataSourceUpdateMode.OnPropertyChanged);
        }

        private void AcceptButton_Click(object sender, EventArgs e)
        {
            if(New)
            {
                if(controller.Insert(hall) > 0)
                {
                    InsertedHalls.Add(hall);
                    if (CustomMessages.YesNoNext(this, "lecture hall"))
                        SetHall(new LectureHall());
                    else
                        Close();
                }
            }
            else
            {
                if(controller.Update(hall))
                {
                    CustomMessages.Updated(this, "lecture hall");
                    SetHall(hall);
                }
            }
        }

        private void DeclineButton_Click(object sender, EventArgs e)
        {
            if(New)
            {
                BuildingTextbox.Text = "";
                FloorNumericUpdown.Value = 0;
                RoomTextbox.Text = "";
            }
            else if(CustomMessages.YesNoDelete(this))
            {
                Deleted = controller.Delete(hall);
                Close();
            }
        }
    }
}
