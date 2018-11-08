using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimetableSchedulerWinform.CustomControl
{
    public class CustomMessages
    {
        public static bool YesNoDelete(IWin32Window owner)
        {
            return MessageBox.Show(owner, "Do you want to delete this?", "Delete?",
                MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation,
                MessageBoxDefaultButton.Button2)
                == DialogResult.Yes;
        }

        public static bool YesNoNext(IWin32Window owner, string object_name)
        {
            return MessageBox.Show(owner, "The " + object_name + " has been added. " +
                "Do you want to continue?", "Continue?",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2)
                == DialogResult.Yes;
        }

        public static void Updated(IWin32Window owner, string object_name)
        {
            MessageBox.Show(owner, "The " + object_name + " has been updated. ",
                "Updated",
                MessageBoxButtons.OK, MessageBoxIcon.Asterisk,
                MessageBoxDefaultButton.Button1);
        }

        public static void Deleted(IWin32Window owner, string object_name)
        {
            MessageBox.Show(owner, "The " + object_name + " has been deleted. ",
                "Deleted",
                MessageBoxButtons.OK, MessageBoxIcon.Asterisk,
                MessageBoxDefaultButton.Button1);
        }

        public static void Inserted(IWin32Window owner, string object_name)
        {
            MessageBox.Show(owner, "The " + object_name + " has been created. ",
                "Created",
                MessageBoxButtons.OK, MessageBoxIcon.Asterisk,
                MessageBoxDefaultButton.Button1);
        }
    }
}
