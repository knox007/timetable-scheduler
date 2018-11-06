namespace TimetableSchedulerWinform
{
    partial class New_Selection_Form
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
            this.timetable_Control2 = new TimetableSchedulerWinform.Timetable_Control();
            this.SuspendLayout();
            // 
            // timetable_Control2
            // 
            this.timetable_Control2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.timetable_Control2.Location = new System.Drawing.Point(228, 12);
            this.timetable_Control2.Name = "timetable_Control2";
            this.timetable_Control2.Size = new System.Drawing.Size(633, 348);
            this.timetable_Control2.TabIndex = 7;
            // 
            // New_Selection_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1080, 540);
            this.Controls.Add(this.timetable_Control2);
            this.Name = "New_Selection_Form";
            this.Text = "New_Selection_Form";
            this.ResumeLayout(false);

        }

        #endregion

        private Timetable_Control timetable_Control1;
        private Timetable_Control timetable_Control2;
    }
}