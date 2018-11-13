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
            return MessageBox.Show(owner, "Do you want to delete this?", "Delete",
                MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation,
                MessageBoxDefaultButton.Button2)
                == DialogResult.Yes;
        }

        public static bool YesNoNext(IWin32Window owner, string object_name)
        {
            return MessageBox.Show(owner, "The " + object_name + " has been created. " +
                "Do you want to continue?", "Continue?",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1)
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

        public static bool YesNoReset(IWin32Window owner)
        {
            return MessageBox.Show(owner, "A lot of data will be deleted." + Environment.NewLine 
                + "Do you really want to do this?", "Reset",
                MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation,
                MessageBoxDefaultButton.Button2)
                == DialogResult.Yes;
        }

        public static void DeleteFail(IWin32Window owner, string object_name)
        {
            MessageBox.Show(owner, "The " + object_name + " cannot be deleted since it is being used. " +
                "Please delete something else first.",
                "Delete fail",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation,
                MessageBoxDefaultButton.Button1);
        }

        public static void SelectFail(IWin32Window owner)
        {
            MessageBox.Show(owner, "You did not select anything to perform this action!",
                "Perform fail",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation,
                MessageBoxDefaultButton.Button1);
        }

        public static void ChooseBeforeCarryOn(IWin32Window owner, string object_name)
        {
            MessageBox.Show(owner, "Please choose " + object_name +
                " before you carry on this action.", "Select", MessageBoxButtons.OK,
                MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
        }

        public static void NoSelectionAvailable(IWin32Window owner)
        {
            MessageBox.Show(owner, "No choice available with current data. " + Environment.NewLine +
                "Maybe the chosen subjects have too little selection or too many subjects have been chosen.", "No choice available",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation, 
                MessageBoxDefaultButton.Button1);
        }

        public static void OptionsSaved(IWin32Window owner)
        {
            MessageBox.Show(owner, "The options have been saved!",
                    "Success", MessageBoxButtons.OK, MessageBoxIcon.Information,
                    MessageBoxDefaultButton.Button1);
        }
    }
}
