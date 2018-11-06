namespace TimetableSchedulerWinform
{
    partial class Subject_Selection_Form
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
            this.SelectorsFlowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.timetable_Control1 = new TimetableSchedulerWinform.Timetable_Control();
            this.SuspendLayout();
            // 
            // SelectorsFlowPanel
            // 
            this.SelectorsFlowPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SelectorsFlowPanel.Location = new System.Drawing.Point(13, 13);
            this.SelectorsFlowPanel.Name = "SelectorsFlowPanel";
            this.SelectorsFlowPanel.Size = new System.Drawing.Size(176, 170);
            this.SelectorsFlowPanel.TabIndex = 0;
            // 
            // timetable_Control1
            // 
            this.timetable_Control1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.timetable_Control1.Location = new System.Drawing.Point(196, 13);
            this.timetable_Control1.Name = "timetable_Control1";
            this.timetable_Control1.Size = new System.Drawing.Size(633, 346);
            this.timetable_Control1.TabIndex = 1;
            // 
            // Subject_Selection_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 450);
            this.Controls.Add(this.timetable_Control1);
            this.Controls.Add(this.SelectorsFlowPanel);
            this.Name = "Subject_Selection_Form";
            this.Text = "Subject_Selection_Form";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel SelectorsFlowPanel;
        private Timetable_Control timetable_Control1;
    }
}