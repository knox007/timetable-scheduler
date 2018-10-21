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
    public partial class Subject_Control : UserControl
    {
        Subject_Controller controller;
        Subject current_selected_subject;

        public Subject_Control()
        {
            InitializeComponent();
            controller = new Subject_Controller();
            current_selected_subject = new Subject();
            
            foreach (Subject subject in controller.Get_All())
                Subject_Combobox.Items.Add(subject);
            Subject_Combobox.DisplayMember = "Name";
            Subject_Combobox.ValueMember = "Id";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            current_selected_subject = (Subject)Subject_Combobox.SelectedItem;
            Name_Textbox.Text = current_selected_subject.Name;
            Codename_Textbox.Text = current_selected_subject.Codename;
        }

        private bool Selected_Subject_Combobox()
        {
            if (string.IsNullOrEmpty(Subject_Combobox.Text))
            {
                MessageBox.Show("You did not select a subject to do this action!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (New_Subject_Checkbox.Checked)
            {
                Subject_Combobox.Enabled = false;
                Accept_Button.Text = "Create";
                Delete_Button.Text = "Reset";
            }
            else
            {
                Subject_Combobox.Enabled = true;
                Accept_Button.Text = "Save Changes";
                Delete_Button.Text = "Delete";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Name_Textbox.Text = "";
            Codename_Textbox.Text = "";

            if (!New_Subject_Checkbox.Checked) //Reset
            {
                if (!Selected_Subject_Combobox()) return;
                controller.Delete(current_selected_subject);
                Subject_Combobox.Items.Remove(current_selected_subject);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (New_Subject_Checkbox.Checked) //Create
            {
                Subject new_subject = new Subject(Name_Textbox.Text, Codename_Textbox.Text);
                new_subject.Id = (int)controller.Insert(new_subject);
                Subject_Combobox.Items.Add(new_subject);
                Subject_Combobox.SelectedItem = new_subject;

                New_Subject_Checkbox.Checked = false;
                checkBox1_CheckedChanged(sender, e);
            }
            else //Save Changes
            {
                if (!Selected_Subject_Combobox()) return;

                current_selected_subject.Name = Name_Textbox.Text;
                current_selected_subject.Codename = Codename_Textbox.Text;
                Subject_Combobox.SelectedItem = current_selected_subject;
                
                Subject_Combobox.DisplayMember = "Id";
                Subject_Combobox.DisplayMember = "Name";

                controller.Update(current_selected_subject);
            }
        }
    }
}
