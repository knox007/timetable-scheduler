using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TimetableData.Control;

namespace TimetableSchedulerWinform.CustomControl
{
    public partial class SelectorControl<Model, CustomForm> : UserControl
    {
        private CustomForm form;
        private Model model;
        private Base_Controller<Model> controller;
        private BindingList<Model> all_models;

        public SelectorControl()
        {
            InitializeComponent();
            model = new Model();
            controller = new Base_Controller<Model>();
            SelectWhatLabel.Text = String.Format("Select {0}", model.GetType().Name);
            SelectWhatLabel.BringToFront();
            all_models = new BindingList<Model>(controller.Get_All());
            

            Models_Combobox.DataSource = all_models;
        }

        private void Action_After_Closing(object sender,
            FormClosedEventArgs e)
        {
            CustomForm form = (CustomForm)sender;
            if (form.InsertedModels().Count > 0)
            {
                foreach (Model model in form.InsertedModels())
                    all_models.Add(model); //add every insert item
                Models_Combobox.SelectedItem = form.GetModel();
                //set the last inserted item as the selected
            }
            else if (form.Deleted)
                all_models.Remove(form.GetModel());
        }

        private void New_Button_Click(object sender, EventArgs e)
        {
            form = new CustomForm();
            form.SetModel(new Model());
            form.Visible = true;

            form.FormClosed += Action_After_Closing;
        }

        private void Edit_Button_Click(object sender, EventArgs e)
        {
            if(Models_Combobox.SelectedIndex >= 0)
            {
                form = new CustomForm();
                form.SetModel((Model)Models_Combobox.SelectedItem);
                form.Visible = true;

                form.FormClosed += Action_After_Closing;
            }
            else
                MessageBox.Show(this, "You have not selected an item!", "Error!",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            
        }
    }
}