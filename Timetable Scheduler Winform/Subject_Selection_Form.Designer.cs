namespace TimetableSchedulerWinform
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
            this.SelectorsFlowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.LecturersPanel = new System.Windows.Forms.Panel();
            this.SelectLecturersLabel = new System.Windows.Forms.Label();
            this.TimetableControl = new TimetableSchedulerWinform.TableCustomControl();
            this.ApplyButton = new System.Windows.Forms.Button();
            this.AcceptButton = new System.Windows.Forms.Button();
            this.DeclineButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SelectorsFlowPanel
            // 
            this.SelectorsFlowPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SelectorsFlowPanel.Location = new System.Drawing.Point(13, 13);
            this.SelectorsFlowPanel.Name = "SelectorsFlowPanel";
            this.SelectorsFlowPanel.Size = new System.Drawing.Size(176, 170);
            this.SelectorsFlowPanel.TabIndex = 0;
            // 
            // LecturersPanel
            // 
            this.LecturersPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LecturersPanel.Location = new System.Drawing.Point(13, 200);
            this.LecturersPanel.Name = "LecturersPanel";
            this.LecturersPanel.Size = new System.Drawing.Size(176, 159);
            this.LecturersPanel.TabIndex = 2;
            // 
            // SelectLecturersLabel
            // 
            this.SelectLecturersLabel.AutoSize = true;
            this.SelectLecturersLabel.Location = new System.Drawing.Point(16, 194);
            this.SelectLecturersLabel.Name = "SelectLecturersLabel";
            this.SelectLecturersLabel.Size = new System.Drawing.Size(90, 13);
            this.SelectLecturersLabel.TabIndex = 3;
            this.SelectLecturersLabel.Text = "Select Lecturer(s)";
            // 
            // TimetableControl
            // 
            this.TimetableControl.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.TimetableControl.Location = new System.Drawing.Point(196, 13);
            this.TimetableControl.Name = "TimetableControl";
            this.TimetableControl.Size = new System.Drawing.Size(633, 346);
            this.TimetableControl.TabIndex = 1;
            // 
            // ApplyButton
            // 
            this.ApplyButton.Location = new System.Drawing.Point(672, 365);
            this.ApplyButton.Name = "ApplyButton";
            this.ApplyButton.Size = new System.Drawing.Size(75, 23);
            this.ApplyButton.TabIndex = 4;
            this.ApplyButton.Text = "Apply";
            this.ApplyButton.UseVisualStyleBackColor = true;
            this.ApplyButton.Click += new System.EventHandler(this.ApplyButton_Click);
            // 
            // AcceptButton
            // 
            this.AcceptButton.Location = new System.Drawing.Point(753, 365);
            this.AcceptButton.Name = "AcceptButton";
            this.AcceptButton.Size = new System.Drawing.Size(75, 23);
            this.AcceptButton.TabIndex = 5;
            this.AcceptButton.Text = "Accept";
            this.AcceptButton.UseVisualStyleBackColor = true;
            // 
            // DeclineButton
            // 
            this.DeclineButton.Location = new System.Drawing.Point(591, 365);
            this.DeclineButton.Name = "DeclineButton";
            this.DeclineButton.Size = new System.Drawing.Size(75, 23);
            this.DeclineButton.TabIndex = 6;
            this.DeclineButton.Text = "Decline";
            this.DeclineButton.UseVisualStyleBackColor = true;
            // 
            // Subject_Selection_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 450);
            this.Controls.Add(this.DeclineButton);
            this.Controls.Add(this.AcceptButton);
            this.Controls.Add(this.ApplyButton);
            this.Controls.Add(this.SelectLecturersLabel);
            this.Controls.Add(this.LecturersPanel);
            this.Controls.Add(this.TimetableControl);
            this.Controls.Add(this.SelectorsFlowPanel);
            this.Name = "Subject_Selection_Form";
            this.Text = "Subject_Selection_Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel SelectorsFlowPanel;
        private TableCustomControl TimetableControl;
        private System.Windows.Forms.Panel LecturersPanel;
        private System.Windows.Forms.Label SelectLecturersLabel;
        private System.Windows.Forms.Button ApplyButton;
        private System.Windows.Forms.Button AcceptButton;
        private System.Windows.Forms.Button DeclineButton;
    }
}