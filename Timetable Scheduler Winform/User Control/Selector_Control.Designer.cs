namespace TimetableSchedulerWinform.CustomControl
{
    partial class SelectorControl<Model, CustomForm>
        where Model : class, new()
        where CustomForm : System.Windows.Forms.Form, GenericForm<Model>, new()
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
            this.SelectWhatLabel = new System.Windows.Forms.Label();
            this.Models_Combobox = new System.Windows.Forms.ComboBox();
            this.New_Button = new System.Windows.Forms.Button();
            this.Edit_Button = new System.Windows.Forms.Button();
            this.OuterPanel = new System.Windows.Forms.Panel();
            this.OuterPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // SelectWhatLabel
            // 
            this.SelectWhatLabel.AutoSize = true;
            this.SelectWhatLabel.Location = new System.Drawing.Point(5, 3);
            this.SelectWhatLabel.Name = "SelectWhatLabel";
            this.SelectWhatLabel.Size = new System.Drawing.Size(46, 13);
            this.SelectWhatLabel.TabIndex = 0;
            this.SelectWhatLabel.Text = "Select ?";
            // 
            // Models_Combobox
            // 
            this.Models_Combobox.FormattingEnabled = true;
            this.Models_Combobox.Location = new System.Drawing.Point(38, 11);
            this.Models_Combobox.Name = "Models_Combobox";
            this.Models_Combobox.Size = new System.Drawing.Size(121, 21);
            this.Models_Combobox.TabIndex = 1;
            // 
            // New_Button
            // 
            this.New_Button.Location = new System.Drawing.Point(84, 38);
            this.New_Button.Name = "New_Button";
            this.New_Button.Size = new System.Drawing.Size(75, 23);
            this.New_Button.TabIndex = 2;
            this.New_Button.Text = "New";
            this.New_Button.UseVisualStyleBackColor = true;
            this.New_Button.Click += new System.EventHandler(this.New_Button_Click);
            // 
            // Edit_Button
            // 
            this.Edit_Button.Location = new System.Drawing.Point(3, 38);
            this.Edit_Button.Name = "Edit_Button";
            this.Edit_Button.Size = new System.Drawing.Size(75, 23);
            this.Edit_Button.TabIndex = 3;
            this.Edit_Button.Text = "Edit";
            this.Edit_Button.UseVisualStyleBackColor = true;
            this.Edit_Button.Click += new System.EventHandler(this.Edit_Button_Click);
            // 
            // OuterPanel
            // 
            this.OuterPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.OuterPanel.Controls.Add(this.Edit_Button);
            this.OuterPanel.Controls.Add(this.Models_Combobox);
            this.OuterPanel.Controls.Add(this.New_Button);
            this.OuterPanel.Location = new System.Drawing.Point(1, 9);
            this.OuterPanel.Name = "OuterPanel";
            this.OuterPanel.Size = new System.Drawing.Size(164, 66);
            this.OuterPanel.TabIndex = 4;
            // 
            // SelectorControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.OuterPanel);
            this.Controls.Add(this.SelectWhatLabel);
            this.Name = "SelectorControl";
            this.Size = new System.Drawing.Size(168, 77);
            this.OuterPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label SelectWhatLabel;
        private System.Windows.Forms.ComboBox Models_Combobox;
        private System.Windows.Forms.Button New_Button;
        private System.Windows.Forms.Button Edit_Button;
        private System.Windows.Forms.Panel OuterPanel;
    }
}
