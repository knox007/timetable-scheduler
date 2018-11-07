namespace TimetableSchedulerWinform.CustomControl
{
    partial class LecturerUserControl
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
            this.components = new System.ComponentModel.Container();
            this.LecturersCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.EditLecturerMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.NewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.UpdateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EditLecturerMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // LecturersCheckedListBox
            // 
            this.LecturersCheckedListBox.ContextMenuStrip = this.EditLecturerMenuStrip;
            this.LecturersCheckedListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LecturersCheckedListBox.FormattingEnabled = true;
            this.LecturersCheckedListBox.Location = new System.Drawing.Point(0, 0);
            this.LecturersCheckedListBox.Name = "LecturersCheckedListBox";
            this.LecturersCheckedListBox.Size = new System.Drawing.Size(150, 150);
            this.LecturersCheckedListBox.TabIndex = 0;
            this.LecturersCheckedListBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LecturersCheckedListBox_MouseDown);
            // 
            // EditLecturerMenuStrip
            // 
            this.EditLecturerMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewToolStripMenuItem,
            this.UpdateToolStripMenuItem,
            this.DeleteToolStripMenuItem});
            this.EditLecturerMenuStrip.Name = "EditLecturerMenuStrip";
            this.EditLecturerMenuStrip.Size = new System.Drawing.Size(113, 70);
            // 
            // NewToolStripMenuItem
            // 
            this.NewToolStripMenuItem.Name = "NewToolStripMenuItem";
            this.NewToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.NewToolStripMenuItem.Text = "New";
            this.NewToolStripMenuItem.Click += new System.EventHandler(this.NewToolStripMenuItem_Click);
            // 
            // UpdateToolStripMenuItem
            // 
            this.UpdateToolStripMenuItem.Name = "UpdateToolStripMenuItem";
            this.UpdateToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.UpdateToolStripMenuItem.Text = "Update";
            this.UpdateToolStripMenuItem.Click += new System.EventHandler(this.UpdateToolStripMenuItem_Click);
            // 
            // DeleteToolStripMenuItem
            // 
            this.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem";
            this.DeleteToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.DeleteToolStripMenuItem.Text = "Delete";
            this.DeleteToolStripMenuItem.Click += new System.EventHandler(this.DeleteToolStripMenuItem_Click);
            // 
            // LecturerUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.LecturersCheckedListBox);
            this.Name = "LecturerUserControl";
            this.EditLecturerMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox LecturersCheckedListBox;
        private System.Windows.Forms.ContextMenuStrip EditLecturerMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem NewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem UpdateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DeleteToolStripMenuItem;
    }
}
