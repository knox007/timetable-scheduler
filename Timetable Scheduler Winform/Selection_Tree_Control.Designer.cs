namespace Timetable_Scheduler_Winform
{
    partial class Selection_Tree_Control
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Selection_Tree_View = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // Selection_Tree_View
            // 
            this.Selection_Tree_View.Location = new System.Drawing.Point(17, 13);
            this.Selection_Tree_View.Name = "Selection_Tree_View";
            this.Selection_Tree_View.Size = new System.Drawing.Size(121, 97);
            this.Selection_Tree_View.TabIndex = 0;
            // 
            // Selection_Tree_Control
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Selection_Tree_View);
            this.Name = "Selection_Tree_Control";
            this.Size = new System.Drawing.Size(249, 196);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView Selection_Tree_View;
    }
}
