namespace Timetable_Scheduler_Winform
{
    partial class Timetable_Control
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
            this.Timetable = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.Timetable)).BeginInit();
            this.SuspendLayout();
            // 
            // Timetable
            // 
            this.Timetable.AllowUserToAddRows = false;
            this.Timetable.AllowUserToDeleteRows = false;
            this.Timetable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Timetable.Location = new System.Drawing.Point(4, 4);
            this.Timetable.Name = "Timetable";
            this.Timetable.ReadOnly = true;
            this.Timetable.Size = new System.Drawing.Size(393, 393);
            this.Timetable.TabIndex = 0;
            // 
            // Timetable_Control
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Timetable);
            this.Name = "Timetable_Control";
            this.Size = new System.Drawing.Size(400, 400);
            ((System.ComponentModel.ISupportInitialize)(this.Timetable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView Timetable;
    }
}
