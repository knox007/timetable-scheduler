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

namespace TimetableSchedulerWinform.CustomForm
{
    public partial class SelectionForm : Form
    {
        public SelectionForm()
        {
            InitializeComponent();
            InitializeSubjects();
            InitializeHalls();
            InitializeLecturers();

            InitializeSelection();
        }

        private void SelectionForm_Load(object sender, EventArgs e)
        {
            //If I try to put it somewhere else, it will not work.
            LoadSelectedLecturers();
        }
    }
}
