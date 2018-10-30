namespace Timetable_Scheduler_Winform
{
    partial class Lecturer_Control
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
            this.Lecturer_Checked_List_Box = new System.Windows.Forms.CheckedListBox();
            this.Lecturer_Panel = new System.Windows.Forms.Panel();
            this.Delete_Button = new System.Windows.Forms.Button();
            this.Accept_Button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Name_Textbox = new System.Windows.Forms.TextBox();
            this.New_Lecturer_Checkbox = new System.Windows.Forms.CheckBox();
            this.Filter_Textbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Lecturer_Panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Lecturer_Checked_List_Box
            // 
            this.Lecturer_Checked_List_Box.CheckOnClick = true;
            this.Lecturer_Checked_List_Box.FormattingEnabled = true;
            this.Lecturer_Checked_List_Box.Location = new System.Drawing.Point(3, 29);
            this.Lecturer_Checked_List_Box.Name = "Lecturer_Checked_List_Box";
            this.Lecturer_Checked_List_Box.Size = new System.Drawing.Size(201, 94);
            this.Lecturer_Checked_List_Box.TabIndex = 0;
            this.Lecturer_Checked_List_Box.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.Lecturer_Checked_List_Box_ItemCheck);
            // 
            // Lecturer_Panel
            // 
            this.Lecturer_Panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Lecturer_Panel.Controls.Add(this.Delete_Button);
            this.Lecturer_Panel.Controls.Add(this.Accept_Button);
            this.Lecturer_Panel.Controls.Add(this.label1);
            this.Lecturer_Panel.Controls.Add(this.Name_Textbox);
            this.Lecturer_Panel.Location = new System.Drawing.Point(3, 138);
            this.Lecturer_Panel.Name = "Lecturer_Panel";
            this.Lecturer_Panel.Size = new System.Drawing.Size(201, 71);
            this.Lecturer_Panel.TabIndex = 1;
            // 
            // Delete_Button
            // 
            this.Delete_Button.Location = new System.Drawing.Point(40, 40);
            this.Delete_Button.Name = "Delete_Button";
            this.Delete_Button.Size = new System.Drawing.Size(75, 23);
            this.Delete_Button.TabIndex = 3;
            this.Delete_Button.Text = "Delete";
            this.Delete_Button.UseVisualStyleBackColor = true;
            this.Delete_Button.Click += new System.EventHandler(this.Delete_Button_Click);
            // 
            // Accept_Button
            // 
            this.Accept_Button.Location = new System.Drawing.Point(121, 40);
            this.Accept_Button.Name = "Accept_Button";
            this.Accept_Button.Size = new System.Drawing.Size(75, 23);
            this.Accept_Button.TabIndex = 2;
            this.Accept_Button.Text = "Save";
            this.Accept_Button.UseVisualStyleBackColor = true;
            this.Accept_Button.Click += new System.EventHandler(this.Accept_Button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name";
            // 
            // Name_Textbox
            // 
            this.Name_Textbox.Location = new System.Drawing.Point(44, 14);
            this.Name_Textbox.Name = "Name_Textbox";
            this.Name_Textbox.Size = new System.Drawing.Size(152, 20);
            this.Name_Textbox.TabIndex = 0;
            // 
            // New_Lecturer_Checkbox
            // 
            this.New_Lecturer_Checkbox.AutoSize = true;
            this.New_Lecturer_Checkbox.Location = new System.Drawing.Point(7, 130);
            this.New_Lecturer_Checkbox.Name = "New_Lecturer_Checkbox";
            this.New_Lecturer_Checkbox.Size = new System.Drawing.Size(92, 17);
            this.New_Lecturer_Checkbox.TabIndex = 0;
            this.New_Lecturer_Checkbox.Text = "New lecturer?";
            this.New_Lecturer_Checkbox.UseVisualStyleBackColor = true;
            this.New_Lecturer_Checkbox.CheckedChanged += new System.EventHandler(this.New_Lecturer_Checkbox_CheckedChanged);
            // 
            // Filter_Textbox
            // 
            this.Filter_Textbox.Location = new System.Drawing.Point(90, 3);
            this.Filter_Textbox.Name = "Filter_Textbox";
            this.Filter_Textbox.Size = new System.Drawing.Size(110, 20);
            this.Filter_Textbox.TabIndex = 2;
            this.Filter_Textbox.TextChanged += new System.EventHandler(this.Filter_Textbox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Filtering lecturer";
            // 
            // Lecturer_Control
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Filter_Textbox);
            this.Controls.Add(this.New_Lecturer_Checkbox);
            this.Controls.Add(this.Lecturer_Panel);
            this.Controls.Add(this.Lecturer_Checked_List_Box);
            this.Name = "Lecturer_Control";
            this.Size = new System.Drawing.Size(208, 213);
            this.Load += new System.EventHandler(this.Lecturer_Control_Load);
            this.Lecturer_Panel.ResumeLayout(false);
            this.Lecturer_Panel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox Lecturer_Checked_List_Box;
        private System.Windows.Forms.Panel Lecturer_Panel;
        private System.Windows.Forms.CheckBox New_Lecturer_Checkbox;
        private System.Windows.Forms.TextBox Name_Textbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Delete_Button;
        private System.Windows.Forms.Button Accept_Button;
        private System.Windows.Forms.TextBox Filter_Textbox;
        private System.Windows.Forms.Label label2;
    }
}
