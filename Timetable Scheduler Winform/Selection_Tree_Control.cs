using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Timetable_Scheduler_Winform
{
    public partial class Selection_Tree_Control : UserControl
    {
        public Selection_Tree_Control()
        {
            InitializeComponent();
            Selection_Tree_View.CheckBoxes = true;
            TreeNode tn = new TreeNode("Base");
            tn.Nodes.Add(new TreeNode("Child 1"));
            tn.Nodes.Add(new TreeNode("Child 2"));
            tn.Nodes.Add(new TreeNode("Child 3"));
            Selection_Tree_View.Nodes.Add(tn);
        }
    }
}
