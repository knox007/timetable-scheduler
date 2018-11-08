namespace TimetableSchedulerWinform.CustomForm
{
    partial class SelectionForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.SubjectCombobox = new System.Windows.Forms.ComboBox();
            this.SubjectAcceptButton = new System.Windows.Forms.Button();
            this.SubjectDeclineButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.HallCombobox = new System.Windows.Forms.ComboBox();
            this.HallNewButton = new System.Windows.Forms.Button();
            this.HallEditButton = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.LecturersGridView = new System.Windows.Forms.DataGridView();
            this.FilterLabel = new System.Windows.Forms.Label();
            this.LecturerFilteringTextbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SelectionAcceptButton = new System.Windows.Forms.Button();
            this.SelectionDeclineButton = new System.Windows.Forms.Button();
            this.SelectionApplyButton = new System.Windows.Forms.Button();
            this.TimetableControl = new TimetableSchedulerWinform.TableCustomControl();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LecturersGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.SubjectCombobox);
            this.panel1.Controls.Add(this.SubjectAcceptButton);
            this.panel1.Controls.Add(this.SubjectDeclineButton);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(171, 70);
            this.panel1.TabIndex = 3;
            // 
            // SubjectCombobox
            // 
            this.SubjectCombobox.FormattingEnabled = true;
            this.SubjectCombobox.Location = new System.Drawing.Point(6, 14);
            this.SubjectCombobox.Name = "SubjectCombobox";
            this.SubjectCombobox.Size = new System.Drawing.Size(156, 21);
            this.SubjectCombobox.TabIndex = 1;
            // 
            // SubjectAcceptButton
            // 
            this.SubjectAcceptButton.Location = new System.Drawing.Point(87, 40);
            this.SubjectAcceptButton.Name = "SubjectAcceptButton";
            this.SubjectAcceptButton.Size = new System.Drawing.Size(75, 23);
            this.SubjectAcceptButton.TabIndex = 3;
            this.SubjectAcceptButton.Text = "New";
            this.SubjectAcceptButton.UseVisualStyleBackColor = true;
            this.SubjectAcceptButton.Click += new System.EventHandler(this.SubjectAcceptButton_Click);
            // 
            // SubjectDeclineButton
            // 
            this.SubjectDeclineButton.Location = new System.Drawing.Point(6, 40);
            this.SubjectDeclineButton.Name = "SubjectDeclineButton";
            this.SubjectDeclineButton.Size = new System.Drawing.Size(75, 23);
            this.SubjectDeclineButton.TabIndex = 2;
            this.SubjectDeclineButton.Text = "Edit";
            this.SubjectDeclineButton.UseVisualStyleBackColor = true;
            this.SubjectDeclineButton.Click += new System.EventHandler(this.SubjectDeclineButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Choose subject";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Choose lecture hall";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.HallCombobox);
            this.panel2.Controls.Add(this.HallNewButton);
            this.panel2.Controls.Add(this.HallEditButton);
            this.panel2.Location = new System.Drawing.Point(12, 93);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(171, 70);
            this.panel2.TabIndex = 6;
            // 
            // HallCombobox
            // 
            this.HallCombobox.FormattingEnabled = true;
            this.HallCombobox.Location = new System.Drawing.Point(6, 14);
            this.HallCombobox.Name = "HallCombobox";
            this.HallCombobox.Size = new System.Drawing.Size(156, 21);
            this.HallCombobox.TabIndex = 4;
            // 
            // HallNewButton
            // 
            this.HallNewButton.Location = new System.Drawing.Point(87, 40);
            this.HallNewButton.Name = "HallNewButton";
            this.HallNewButton.Size = new System.Drawing.Size(75, 23);
            this.HallNewButton.TabIndex = 6;
            this.HallNewButton.Text = "New";
            this.HallNewButton.UseVisualStyleBackColor = true;
            this.HallNewButton.Click += new System.EventHandler(this.HallNewButton_Click);
            // 
            // HallEditButton
            // 
            this.HallEditButton.Location = new System.Drawing.Point(6, 40);
            this.HallEditButton.Name = "HallEditButton";
            this.HallEditButton.Size = new System.Drawing.Size(75, 23);
            this.HallEditButton.TabIndex = 5;
            this.HallEditButton.Text = "Edit";
            this.HallEditButton.UseVisualStyleBackColor = true;
            this.HallEditButton.Click += new System.EventHandler(this.HallEditButton_Click);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.LecturersGridView);
            this.panel3.Controls.Add(this.FilterLabel);
            this.panel3.Controls.Add(this.LecturerFilteringTextbox);
            this.panel3.Location = new System.Drawing.Point(12, 180);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(171, 178);
            this.panel3.TabIndex = 8;
            // 
            // LecturersGridView
            // 
            this.LecturersGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.LecturersGridView.Location = new System.Drawing.Point(11, 35);
            this.LecturersGridView.Name = "LecturersGridView";
            this.LecturersGridView.RowHeadersVisible = false;
            this.LecturersGridView.Size = new System.Drawing.Size(148, 133);
            this.LecturersGridView.TabIndex = 8;
            // 
            // FilterLabel
            // 
            this.FilterLabel.AutoSize = true;
            this.FilterLabel.Location = new System.Drawing.Point(8, 12);
            this.FilterLabel.Name = "FilterLabel";
            this.FilterLabel.Size = new System.Drawing.Size(29, 13);
            this.FilterLabel.TabIndex = 11;
            this.FilterLabel.Text = "Filter";
            // 
            // LecturerFilteringTextbox
            // 
            this.LecturerFilteringTextbox.Location = new System.Drawing.Point(43, 9);
            this.LecturerFilteringTextbox.Name = "LecturerFilteringTextbox";
            this.LecturerFilteringTextbox.Size = new System.Drawing.Size(116, 20);
            this.LecturerFilteringTextbox.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Select lecturers";
            // 
            // SelectionAcceptButton
            // 
            this.SelectionAcceptButton.Location = new System.Drawing.Point(744, 364);
            this.SelectionAcceptButton.Name = "SelectionAcceptButton";
            this.SelectionAcceptButton.Size = new System.Drawing.Size(75, 23);
            this.SelectionAcceptButton.TabIndex = 12;
            this.SelectionAcceptButton.Text = "Accept";
            this.SelectionAcceptButton.UseVisualStyleBackColor = true;
            // 
            // SelectionDeclineButton
            // 
            this.SelectionDeclineButton.Location = new System.Drawing.Point(663, 364);
            this.SelectionDeclineButton.Name = "SelectionDeclineButton";
            this.SelectionDeclineButton.Size = new System.Drawing.Size(75, 23);
            this.SelectionDeclineButton.TabIndex = 11;
            this.SelectionDeclineButton.Text = "Decline";
            this.SelectionDeclineButton.UseVisualStyleBackColor = true;
            // 
            // SelectionApplyButton
            // 
            this.SelectionApplyButton.Location = new System.Drawing.Point(582, 364);
            this.SelectionApplyButton.Name = "SelectionApplyButton";
            this.SelectionApplyButton.Size = new System.Drawing.Size(75, 23);
            this.SelectionApplyButton.TabIndex = 10;
            this.SelectionApplyButton.Text = "Apply";
            this.SelectionApplyButton.UseVisualStyleBackColor = true;
            // 
            // TimetableControl
            // 
            this.TimetableControl.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.TimetableControl.Location = new System.Drawing.Point(189, 12);
            this.TimetableControl.Name = "TimetableControl";
            this.TimetableControl.Size = new System.Drawing.Size(633, 346);
            this.TimetableControl.TabIndex = 9;
            // 
            // SelectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 396);
            this.Controls.Add(this.SelectionApplyButton);
            this.Controls.Add(this.SelectionDeclineButton);
            this.Controls.Add(this.SelectionAcceptButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.TimetableControl);
            this.Name = "SelectionForm";
            this.Text = "SelectionForm";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LecturersGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TableCustomControl TimetableControl;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox SubjectCombobox;
        private System.Windows.Forms.Button SubjectAcceptButton;
        private System.Windows.Forms.Button SubjectDeclineButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox HallCombobox;
        private System.Windows.Forms.Button HallNewButton;
        private System.Windows.Forms.Button HallEditButton;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView LecturersGridView;
        private System.Windows.Forms.Label FilterLabel;
        private System.Windows.Forms.TextBox LecturerFilteringTextbox;
        private System.Windows.Forms.Button SelectionAcceptButton;
        private System.Windows.Forms.Button SelectionDeclineButton;
        private System.Windows.Forms.Button SelectionApplyButton;
    }
}