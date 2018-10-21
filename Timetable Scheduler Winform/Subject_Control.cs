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
        Subject_Controller sc;

        public Subject_Control()
        {
            InitializeComponent();
            sc = new Subject_Controller();

            New_Subject_Panel.Enabled = false;
            New_.Enabled = true;
            foreach(Subject s in sc.Get_All())
                comboBox1.Items.Add(s);
            
            comboBox1.DisplayMember = "Name";
            comboBox1.ValueMember = "Id";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(New_.Checked)
            {
                comboBox1.Enabled = false;
                New_Subject_Panel.Enabled = true;
            }
            else
            {
                comboBox1.Enabled = true;
                New_Subject_Panel.Enabled = false;
                New_.Enabled = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Subject s = new Timetable_Data.Model.Subject(textBox1.Text, textBox2.Text);
            sc.Insert(s);
            comboBox1.Items.Add(s);
        }
    }
}
