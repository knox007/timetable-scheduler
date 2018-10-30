namespace Timetable_Scheduler_Winform.User_Control
{
    partial class Selector_Control<T>
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
            this.Select_What_Label = new System.Windows.Forms.Label();
            this.Objects_Combobox = new System.Windows.Forms.ComboBox();
            this.New_Button = new System.Windows.Forms.Button();
            this.Edit_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Select_What_Label
            // 
            this.Select_What_Label.AutoSize = true;
            this.Select_What_Label.Location = new System.Drawing.Point(-3, 3);
            this.Select_What_Label.Name = "Select_What_Label";
            this.Select_What_Label.Size = new System.Drawing.Size(46, 13);
            this.Select_What_Label.TabIndex = 0;
            this.Select_What_Label.Text = "Select ?";
            // 
            // Objects_Combobox
            // 
            this.Objects_Combobox.FormattingEnabled = true;
            this.Objects_Combobox.Location = new System.Drawing.Point(101, 0);
            this.Objects_Combobox.Name = "Objects_Combobox";
            this.Objects_Combobox.Size = new System.Drawing.Size(121, 21);
            this.Objects_Combobox.TabIndex = 1;
            // 
            // New_Button
            // 
            this.New_Button.Location = new System.Drawing.Point(144, 27);
            this.New_Button.Name = "New_Button";
            this.New_Button.Size = new System.Drawing.Size(75, 23);
            this.New_Button.TabIndex = 2;
            this.New_Button.Text = "New";
            this.New_Button.UseVisualStyleBackColor = true;
            // 
            // Edit_Button
            // 
            this.Edit_Button.Location = new System.Drawing.Point(63, 27);
            this.Edit_Button.Name = "Edit_Button";
            this.Edit_Button.Size = new System.Drawing.Size(75, 23);
            this.Edit_Button.TabIndex = 3;
            this.Edit_Button.Text = "Edit";
            this.Edit_Button.UseVisualStyleBackColor = true;
            // 
            // Selector_Control
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Edit_Button);
            this.Controls.Add(this.New_Button);
            this.Controls.Add(this.Objects_Combobox);
            this.Controls.Add(this.Select_What_Label);
            this.Name = "Selector_Control";
            this.Size = new System.Drawing.Size(222, 51);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Select_What_Label;
        private System.Windows.Forms.ComboBox Objects_Combobox;
        private System.Windows.Forms.Button New_Button;
        private System.Windows.Forms.Button Edit_Button;
    }
}
