using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Timetable_Data.Control;
using Timetable_Data.Model;

namespace Timetable_Scheduler_Winform
{
    public partial class Lecturer_Control : UserControl
    {
        Lecturer_Controller controller;
        Lecturer current_selected_lecturer;
        public List<Lecturer> Selected_Lecturers { get; }
        private List<Lecturer> All_Lecturers;

        public Lecturer_Control()
        {
            InitializeComponent();
            controller = new Lecturer_Controller();
            current_selected_lecturer = new Lecturer();
            Selected_Lecturers = new List<Lecturer>();
            All_Lecturers = controller.Get_All();

            foreach (Lecturer lecturer in All_Lecturers)
                Lecturer_Checked_List_Box.Items.Add(lecturer);

            Lecturer_Checked_List_Box.ValueMember = "Id";
            Lecturer_Checked_List_Box.DisplayMember = "Name";
        }

        private void Lecturer_Control_Load(object sender, EventArgs e)
        {

        }

        private void New_Lecturer_Checkbox_CheckedChanged(object sender, EventArgs e)
        {
            if(New_Lecturer_Checkbox.Checked)
            {
                Accept_Button.Text = "Create";
                Delete_Button.Text = "Reset";
            }
            else
            {
                Accept_Button.Text = "Save";
                Delete_Button.Text = "Delete";
            }
        }

        private void Accept_Button_Click(object sender, EventArgs e)
        {
            if(New_Lecturer_Checkbox.Checked) //Create
            {
                Lecturer new_lecturer = new Lecturer(Name_Textbox.Text);
                new_lecturer.Id = (int)controller.Insert(new_lecturer);
                current_selected_lecturer = new_lecturer;

                //All_Lecturers.Add(new_lecturer);
                Lecturer_Checked_List_Box.Items.Add(new_lecturer);
                Lecturer_Checked_List_Box.SelectedItem = new_lecturer;
                Lecturer_Checked_List_Box.SetItemChecked(Lecturer_Checked_List_Box.Items.Count - 1, true);
            }
            else //Save changes
            {
                if (!Selected_Lecturer_Checked_List_Box()) return;

                //save changes
                current_selected_lecturer.Name = Name_Textbox.Text;
                Lecturer_Checked_List_Box.SelectedItem = current_selected_lecturer;
                controller.Update(current_selected_lecturer);

                //reset view
                Lecturer_Checked_List_Box.DisplayMember = "Id";
                Lecturer_Checked_List_Box.DisplayMember = "Name";
            }
        }

        private void Lecturer_Checked_List_Box_SelectedIndexChanged(object sender, EventArgs e)
        {
            current_selected_lecturer = (Lecturer)Lecturer_Checked_List_Box.SelectedItem;
            Name_Textbox.Text = current_selected_lecturer.Name;
        }

        private void Lecturer_Checked_List_Box_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            Lecturer_Checked_List_Box_SelectedIndexChanged(sender, e);

            if(e.NewValue == CheckState.Checked)
                Selected_Lecturers.Add(current_selected_lecturer);
            else if(e.NewValue == CheckState.Unchecked)
                Selected_Lecturers.Remove(current_selected_lecturer);
        }

        private bool Selected_Lecturer_Checked_List_Box()
        {
            if (Lecturer_Checked_List_Box.SelectedIndex >= 0)
                return true;
            else
                MessageBox.Show("You did not select a subject to do this action!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return false;
        }

        private void Delete_Button_Click(object sender, EventArgs e)
        {
            //Reset
            Name_Textbox.Text = "";

            if(!New_Lecturer_Checkbox.Checked) //Delete
            {
                if (!Selected_Lecturer_Checked_List_Box()) return;

                Selected_Lecturers.Remove(current_selected_lecturer);
                Lecturer_Checked_List_Box.Items.Remove(current_selected_lecturer);
                controller.Delete(current_selected_lecturer);
            }
        }

        private void Filter_Textbox_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
