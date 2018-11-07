namespace TimetableSchedulerWinform.CustomControl
{
    partial class LecturerForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.Name_Textbox = new System.Windows.Forms.TextBox();
            this.Decline_Button = new System.Windows.Forms.Button();
            this.Accept_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // Name_Textbox
            // 
            this.Name_Textbox.Location = new System.Drawing.Point(54, 10);
            this.Name_Textbox.Name = "Name_Textbox";
            this.Name_Textbox.Size = new System.Drawing.Size(118, 20);
            this.Name_Textbox.TabIndex = 1;
            // 
            // Decline_Button
            // 
            this.Decline_Button.Location = new System.Drawing.Point(16, 36);
            this.Decline_Button.Name = "Decline_Button";
            this.Decline_Button.Size = new System.Drawing.Size(75, 23);
            this.Decline_Button.TabIndex = 2;
            this.Decline_Button.Text = "Reset";
            this.Decline_Button.UseVisualStyleBackColor = true;
            this.Decline_Button.Click += new System.EventHandler(this.Decline_Button_Click);
            // 
            // Accept_Button
            // 
            this.Accept_Button.Location = new System.Drawing.Point(97, 36);
            this.Accept_Button.Name = "Accept_Button";
            this.Accept_Button.Size = new System.Drawing.Size(75, 23);
            this.Accept_Button.TabIndex = 3;
            this.Accept_Button.Text = "New";
            this.Accept_Button.UseVisualStyleBackColor = true;
            this.Accept_Button.Click += new System.EventHandler(this.Accept_Button_Click);
            // 
            // Lecturer_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(184, 67);
            this.Controls.Add(this.Accept_Button);
            this.Controls.Add(this.Decline_Button);
            this.Controls.Add(this.Name_Textbox);
            this.Controls.Add(this.label1);
            this.Name = "Lecturer_Form";
            this.Text = "Lecturer_Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Name_Textbox;
        private System.Windows.Forms.Button Decline_Button;
        private System.Windows.Forms.Button Accept_Button;
    }
}