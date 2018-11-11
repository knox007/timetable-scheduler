namespace TimetableSchedulerWinform.CustomForm
{
    partial class TimesOptionForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.TimesContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.setPreferredTimesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setDeniedTimesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetSelectedTimesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OkayButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.TimetableControl = new TimetableSchedulerWinform.TableCustomControl();
            this.TimesContextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // TimesContextMenuStrip
            // 
            this.TimesContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.setPreferredTimesToolStripMenuItem,
            this.setDeniedTimesToolStripMenuItem,
            this.resetSelectedTimesToolStripMenuItem,
            this.resetAllToolStripMenuItem});
            this.TimesContextMenuStrip.Name = "TimesContextMenuStrip";
            this.TimesContextMenuStrip.Size = new System.Drawing.Size(181, 114);
            // 
            // setPreferredTimesToolStripMenuItem
            // 
            this.setPreferredTimesToolStripMenuItem.Name = "setPreferredTimesToolStripMenuItem";
            this.setPreferredTimesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.setPreferredTimesToolStripMenuItem.Text = "Set preferred times";
            this.setPreferredTimesToolStripMenuItem.Click += new System.EventHandler(this.addPreferredTimesToolStripMenuItem_Click);
            // 
            // setDeniedTimesToolStripMenuItem
            // 
            this.setDeniedTimesToolStripMenuItem.Name = "setDeniedTimesToolStripMenuItem";
            this.setDeniedTimesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.setDeniedTimesToolStripMenuItem.Text = "Set denied times";
            this.setDeniedTimesToolStripMenuItem.Click += new System.EventHandler(this.addDeniedTimesToolStripMenuItem_Click);
            // 
            // resetSelectedTimesToolStripMenuItem
            // 
            this.resetSelectedTimesToolStripMenuItem.Name = "resetSelectedTimesToolStripMenuItem";
            this.resetSelectedTimesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.resetSelectedTimesToolStripMenuItem.Text = "Reset selected times";
            this.resetSelectedTimesToolStripMenuItem.Click += new System.EventHandler(this.resetSelectedTimesToolStripMenuItem_Click);
            // 
            // resetAllToolStripMenuItem
            // 
            this.resetAllToolStripMenuItem.Name = "resetAllToolStripMenuItem";
            this.resetAllToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.resetAllToolStripMenuItem.Text = "Reset all";
            this.resetAllToolStripMenuItem.Click += new System.EventHandler(this.resetAllToolStripMenuItem_Click);
            // 
            // OkayButton
            // 
            this.OkayButton.Location = new System.Drawing.Point(570, 364);
            this.OkayButton.Name = "OkayButton";
            this.OkayButton.Size = new System.Drawing.Size(75, 23);
            this.OkayButton.TabIndex = 6;
            this.OkayButton.Text = "OK";
            this.OkayButton.UseVisualStyleBackColor = true;
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(489, 364);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 7;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            // 
            // TimetableControl
            // 
            this.TimetableControl.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.TimetableControl.ContextMenuStrip = this.TimesContextMenuStrip;
            this.TimetableControl.Location = new System.Drawing.Point(12, 12);
            this.TimetableControl.Name = "TimetableControl";
            this.TimetableControl.Size = new System.Drawing.Size(633, 346);
            this.TimetableControl.TabIndex = 2;
            // 
            // TimesOptionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 398);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.OkayButton);
            this.Controls.Add(this.TimetableControl);
            this.Name = "TimesOptionForm";
            this.Text = "TimesOptionForm";
            this.TimesContextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TableCustomControl TimetableControl;
        private System.Windows.Forms.Button OkayButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.ContextMenuStrip TimesContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem setPreferredTimesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setDeniedTimesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetSelectedTimesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetAllToolStripMenuItem;
    }
}