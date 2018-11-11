namespace TimetableSchedulerWinform.CustomForm
{
    partial class LecturersOptionForm
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
            this.PreferredLecturersCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.PreferredFilter = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DeniedLecturersCheckedListBox = new System.Windows.Forms.CheckedListBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.DeniedFilter = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.CancelButton = new System.Windows.Forms.Button();
            this.OKButton = new System.Windows.Forms.Button();
            this.ResetButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // PreferredLecturersCheckedListBox
            // 
            this.PreferredLecturersCheckedListBox.CheckOnClick = true;
            this.PreferredLecturersCheckedListBox.FormattingEnabled = true;
            this.PreferredLecturersCheckedListBox.Location = new System.Drawing.Point(3, 34);
            this.PreferredLecturersCheckedListBox.Name = "PreferredLecturersCheckedListBox";
            this.PreferredLecturersCheckedListBox.Size = new System.Drawing.Size(141, 154);
            this.PreferredLecturersCheckedListBox.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.PreferredFilter);
            this.panel1.Controls.Add(this.PreferredLecturersCheckedListBox);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(149, 194);
            this.panel1.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Filter";
            // 
            // PreferredFilter
            // 
            this.PreferredFilter.Location = new System.Drawing.Point(38, 9);
            this.PreferredFilter.Name = "PreferredFilter";
            this.PreferredFilter.Size = new System.Drawing.Size(106, 20);
            this.PreferredFilter.TabIndex = 1;
            this.PreferredFilter.TextChanged += new System.EventHandler(this.PreferredFilter_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Preferred lecturers";
            // 
            // DeniedLecturersCheckedListBox
            // 
            this.DeniedLecturersCheckedListBox.CheckOnClick = true;
            this.DeniedLecturersCheckedListBox.FormattingEnabled = true;
            this.DeniedLecturersCheckedListBox.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.DeniedLecturersCheckedListBox.Location = new System.Drawing.Point(3, 34);
            this.DeniedLecturersCheckedListBox.Name = "DeniedLecturersCheckedListBox";
            this.DeniedLecturersCheckedListBox.Size = new System.Drawing.Size(141, 154);
            this.DeniedLecturersCheckedListBox.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.DeniedFilter);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.DeniedLecturersCheckedListBox);
            this.panel2.Location = new System.Drawing.Point(167, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(149, 194);
            this.panel2.TabIndex = 3;
            // 
            // DeniedFilter
            // 
            this.DeniedFilter.Location = new System.Drawing.Point(38, 9);
            this.DeniedFilter.Name = "DeniedFilter";
            this.DeniedFilter.Size = new System.Drawing.Size(106, 20);
            this.DeniedFilter.TabIndex = 3;
            this.DeniedFilter.TextChanged += new System.EventHandler(this.DeniedFilter_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Filter";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(170, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Denied lecturers";
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(75, 212);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 5;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // OKButton
            // 
            this.OKButton.Location = new System.Drawing.Point(237, 212);
            this.OKButton.Name = "OKButton";
            this.OKButton.Size = new System.Drawing.Size(75, 23);
            this.OKButton.TabIndex = 6;
            this.OKButton.Text = "OK";
            this.OKButton.UseVisualStyleBackColor = true;
            this.OKButton.Click += new System.EventHandler(this.OKButton_Click);
            // 
            // ResetButton
            // 
            this.ResetButton.Location = new System.Drawing.Point(156, 212);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(75, 23);
            this.ResetButton.TabIndex = 7;
            this.ResetButton.Text = "Reset";
            this.ResetButton.UseVisualStyleBackColor = true;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // LecturersOptionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 243);
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.OKButton);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "LecturersOptionForm";
            this.Text = "LecturersOptionForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckedListBox PreferredLecturersCheckedListBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckedListBox DeniedLecturersCheckedListBox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button OKButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox PreferredFilter;
        private System.Windows.Forms.TextBox DeniedFilter;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button ResetButton;
    }
}