﻿namespace TimetableSchedulerWinform.CustomForm
{
    partial class LectureHallForm
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
            this.BuildingTextbox = new System.Windows.Forms.TextBox();
            this.RoomTextbox = new System.Windows.Forms.TextBox();
            this.FloorNumericUpdown = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.DeclineButton = new System.Windows.Forms.Button();
            this.AcceptButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.FloorNumericUpdown)).BeginInit();
            this.SuspendLayout();
            // 
            // BuildingTextbox
            // 
            this.BuildingTextbox.Location = new System.Drawing.Point(62, 13);
            this.BuildingTextbox.Name = "BuildingTextbox";
            this.BuildingTextbox.Size = new System.Drawing.Size(109, 20);
            this.BuildingTextbox.TabIndex = 1;
            // 
            // RoomTextbox
            // 
            this.RoomTextbox.Location = new System.Drawing.Point(62, 65);
            this.RoomTextbox.Name = "RoomTextbox";
            this.RoomTextbox.Size = new System.Drawing.Size(109, 20);
            this.RoomTextbox.TabIndex = 3;
            // 
            // FloorNumericUpdown
            // 
            this.FloorNumericUpdown.Location = new System.Drawing.Point(62, 39);
            this.FloorNumericUpdown.Name = "FloorNumericUpdown";
            this.FloorNumericUpdown.Size = new System.Drawing.Size(39, 20);
            this.FloorNumericUpdown.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Building";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Floor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Room";
            // 
            // DeclineButton
            // 
            this.DeclineButton.Location = new System.Drawing.Point(15, 91);
            this.DeclineButton.Name = "DeclineButton";
            this.DeclineButton.Size = new System.Drawing.Size(75, 23);
            this.DeclineButton.TabIndex = 4;
            this.DeclineButton.Text = "Decline";
            this.DeclineButton.UseVisualStyleBackColor = true;
            this.DeclineButton.Click += new System.EventHandler(this.DeclineButton_Click);
            // 
            // AcceptButton
            // 
            this.AcceptButton.Location = new System.Drawing.Point(96, 91);
            this.AcceptButton.Name = "AcceptButton";
            this.AcceptButton.Size = new System.Drawing.Size(75, 23);
            this.AcceptButton.TabIndex = 5;
            this.AcceptButton.Text = "Accept";
            this.AcceptButton.UseVisualStyleBackColor = true;
            this.AcceptButton.Click += new System.EventHandler(this.AcceptButton_Click);
            // 
            // LectureHallForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(184, 125);
            this.Controls.Add(this.AcceptButton);
            this.Controls.Add(this.DeclineButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FloorNumericUpdown);
            this.Controls.Add(this.RoomTextbox);
            this.Controls.Add(this.BuildingTextbox);
            this.Name = "LectureHallForm";
            this.Text = "LectureHallForm";
            ((System.ComponentModel.ISupportInitialize)(this.FloorNumericUpdown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox BuildingTextbox;
        private System.Windows.Forms.TextBox RoomTextbox;
        private System.Windows.Forms.NumericUpDown FloorNumericUpdown;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button DeclineButton;
        private System.Windows.Forms.Button AcceptButton;
    }
}