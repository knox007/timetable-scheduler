namespace Timetable_Scheduler_Winform
{
    partial class Subject_Control
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
            this.Subject_Panel = new System.Windows.Forms.Panel();
            this.Delete_Button = new System.Windows.Forms.Button();
            this.Accept_Button = new System.Windows.Forms.Button();
            this.Codename_Textbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Name_Textbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.New_Subject_Checkbox = new System.Windows.Forms.CheckBox();
            this.Subject_Combobox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Subject_Panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Subject_Panel
            // 
            this.Subject_Panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Subject_Panel.Controls.Add(this.Delete_Button);
            this.Subject_Panel.Controls.Add(this.Accept_Button);
            this.Subject_Panel.Controls.Add(this.Codename_Textbox);
            this.Subject_Panel.Controls.Add(this.label3);
            this.Subject_Panel.Controls.Add(this.Name_Textbox);
            this.Subject_Panel.Controls.Add(this.label2);
            this.Subject_Panel.Location = new System.Drawing.Point(3, 40);
            this.Subject_Panel.Name = "Subject_Panel";
            this.Subject_Panel.Size = new System.Drawing.Size(202, 98);
            this.Subject_Panel.TabIndex = 0;
            // 
            // Delete_Button
            // 
            this.Delete_Button.Location = new System.Drawing.Point(36, 67);
            this.Delete_Button.Name = "Delete_Button";
            this.Delete_Button.Size = new System.Drawing.Size(75, 23);
            this.Delete_Button.TabIndex = 6;
            this.Delete_Button.Text = "Delete";
            this.Delete_Button.UseVisualStyleBackColor = true;
            this.Delete_Button.Click += new System.EventHandler(this.button2_Click);
            // 
            // Accept_Button
            // 
            this.Accept_Button.Location = new System.Drawing.Point(117, 68);
            this.Accept_Button.Name = "Accept_Button";
            this.Accept_Button.Size = new System.Drawing.Size(75, 23);
            this.Accept_Button.TabIndex = 5;
            this.Accept_Button.Text = "Save";
            this.Accept_Button.UseVisualStyleBackColor = true;
            this.Accept_Button.Click += new System.EventHandler(this.button1_Click);
            // 
            // Codename_Textbox
            // 
            this.Codename_Textbox.Location = new System.Drawing.Point(73, 41);
            this.Codename_Textbox.Name = "Codename_Textbox";
            this.Codename_Textbox.Size = new System.Drawing.Size(120, 20);
            this.Codename_Textbox.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Codename";
            // 
            // Name_Textbox
            // 
            this.Name_Textbox.Location = new System.Drawing.Point(73, 14);
            this.Name_Textbox.Name = "Name_Textbox";
            this.Name_Textbox.Size = new System.Drawing.Size(120, 20);
            this.Name_Textbox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            // 
            // New_Subject_Checkbox
            // 
            this.New_Subject_Checkbox.AutoSize = true;
            this.New_Subject_Checkbox.Location = new System.Drawing.Point(7, 31);
            this.New_Subject_Checkbox.Name = "New_Subject_Checkbox";
            this.New_Subject_Checkbox.Size = new System.Drawing.Size(91, 18);
            this.New_Subject_Checkbox.TabIndex = 2;
            this.New_Subject_Checkbox.Text = "New subject?";
            this.New_Subject_Checkbox.UseCompatibleTextRendering = true;
            this.New_Subject_Checkbox.UseVisualStyleBackColor = true;
            // 
            // Subject_Combobox
            // 
            this.Subject_Combobox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.Subject_Combobox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.Subject_Combobox.FormattingEnabled = true;
            this.Subject_Combobox.Location = new System.Drawing.Point(83, 4);
            this.Subject_Combobox.Name = "Subject_Combobox";
            this.Subject_Combobox.Size = new System.Drawing.Size(121, 21);
            this.Subject_Combobox.TabIndex = 1;
            this.Subject_Combobox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Select subject";
            // 
            // Subject_Control
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.New_Subject_Checkbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Subject_Combobox);
            this.Controls.Add(this.Subject_Panel);
            this.Name = "Subject_Control";
            this.Size = new System.Drawing.Size(208, 141);
            this.Subject_Panel.ResumeLayout(false);
            this.Subject_Panel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Subject_Panel;
        private System.Windows.Forms.Button Delete_Button;
        private System.Windows.Forms.Button Accept_Button;
        private System.Windows.Forms.TextBox Codename_Textbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Name_Textbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox Subject_Combobox;
        private System.Windows.Forms.CheckBox New_Subject_Checkbox;
        private System.Windows.Forms.Label label1;
    }
}
