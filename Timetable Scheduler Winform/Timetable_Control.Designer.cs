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
            this.iGrid1 = new TenTec.Windows.iGridLib.iGrid();
            ((System.ComponentModel.ISupportInitialize)(this.Timetable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iGrid1)).BeginInit();
            this.SuspendLayout();
            // 
            // Timetable
            // 
            this.Timetable.AllowUserToAddRows = false;
            this.Timetable.AllowUserToDeleteRows = false;
            this.Timetable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Timetable.Location = new System.Drawing.Point(3, 3);
            this.Timetable.Name = "Timetable";
            this.Timetable.ReadOnly = true;
            this.Timetable.Size = new System.Drawing.Size(283, 249);
            this.Timetable.TabIndex = 0;
            // 
            // iGrid1
            // 
            this.iGrid1.Header.Height = 18;
            this.iGrid1.Location = new System.Drawing.Point(0, 0);
            this.iGrid1.Name = "iGrid1";
            this.iGrid1.TabIndex = 0;
            // 
            // Timetable_Control
            // 
            this.Controls.Add(this.Timetable);
            this.Name = "Timetable_Control";
            this.Size = new System.Drawing.Size(463, 337);
            ((System.ComponentModel.ISupportInitialize)(this.Timetable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iGrid1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        
        private System.Windows.Forms.DataGridView Timetable;
        private TenTec.Windows.iGridLib.iGrid iGrid1;
    }
}
