namespace Timetable_Scheduler_Winform
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
            this.timetable_Control1 = new Timetable_Scheduler_Winform.Timetable_Control();
            this.SuspendLayout();
            // 
            // timetable_Control1
            // 
            this.timetable_Control1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.timetable_Control1.Location = new System.Drawing.Point(175, 12);
            this.timetable_Control1.Name = "timetable_Control1";
            this.timetable_Control1.Size = new System.Drawing.Size(632, 346);
            this.timetable_Control1.TabIndex = 0;
            // 
            // Subject_Selection_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 450);
            this.Controls.Add(this.timetable_Control1);
            this.Name = "Subject_Selection_Form";
            this.Text = "Subject_Selection_Form";
            this.ResumeLayout(false);

        }

        #endregion

        private Timetable_Control timetable_Control1;
    }
}