namespace TimetableSchedulerWinform
{
    partial class MainForm
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
            this._MainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.dataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newSelectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetDatabaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.functionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nextChoiceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.previousChoiceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.floorsHeightPreferenceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lecturersOptionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timesOptionLectureTimesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.howToUseTheProgramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SubjectFilteringTextbox = new System.Windows.Forms.TextBox();
            this.FilterLabel = new System.Windows.Forms.Label();
            this.CompulsorySubjectsGridView = new System.Windows.Forms.DataGridView();
            this.TimetableControl = new TimetableSchedulerWinform.TableCustomControl();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.showSelectionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._MainMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CompulsorySubjectsGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // _MainMenuStrip
            // 
            this._MainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dataToolStripMenuItem,
            this.functionToolStripMenuItem,
            this.optionsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this._MainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this._MainMenuStrip.Name = "_MainMenuStrip";
            this._MainMenuStrip.Size = new System.Drawing.Size(816, 24);
            this._MainMenuStrip.TabIndex = 0;
            this._MainMenuStrip.Text = "menuStrip1";
            // 
            // dataToolStripMenuItem
            // 
            this.dataToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newSelectionToolStripMenuItem,
            this.showSelectionsToolStripMenuItem,
            this.resetDatabaseToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.dataToolStripMenuItem.Name = "dataToolStripMenuItem";
            this.dataToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.dataToolStripMenuItem.Text = "Data";
            // 
            // newSelectionToolStripMenuItem
            // 
            this.newSelectionToolStripMenuItem.Name = "newSelectionToolStripMenuItem";
            this.newSelectionToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.newSelectionToolStripMenuItem.Text = "New selection";
            this.newSelectionToolStripMenuItem.Click += new System.EventHandler(this.newSelectionToolStripMenuItem_Click);
            // 
            // resetDatabaseToolStripMenuItem
            // 
            this.resetDatabaseToolStripMenuItem.Name = "resetDatabaseToolStripMenuItem";
            this.resetDatabaseToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.resetDatabaseToolStripMenuItem.Text = "Reset database";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // functionToolStripMenuItem
            // 
            this.functionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.generateToolStripMenuItem,
            this.nextChoiceToolStripMenuItem,
            this.previousChoiceToolStripMenuItem});
            this.functionToolStripMenuItem.Name = "functionToolStripMenuItem";
            this.functionToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.functionToolStripMenuItem.Text = "Function";
            // 
            // generateToolStripMenuItem
            // 
            this.generateToolStripMenuItem.Name = "generateToolStripMenuItem";
            this.generateToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.generateToolStripMenuItem.Text = "Generate all choices";
            // 
            // nextChoiceToolStripMenuItem
            // 
            this.nextChoiceToolStripMenuItem.Name = "nextChoiceToolStripMenuItem";
            this.nextChoiceToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.nextChoiceToolStripMenuItem.Text = "Next choice";
            // 
            // previousChoiceToolStripMenuItem
            // 
            this.previousChoiceToolStripMenuItem.Name = "previousChoiceToolStripMenuItem";
            this.previousChoiceToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.previousChoiceToolStripMenuItem.Text = "Previous choice";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.floorsHeightPreferenceToolStripMenuItem,
            this.lecturersOptionToolStripMenuItem,
            this.timesOptionLectureTimesToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // floorsHeightPreferenceToolStripMenuItem
            // 
            this.floorsHeightPreferenceToolStripMenuItem.Name = "floorsHeightPreferenceToolStripMenuItem";
            this.floorsHeightPreferenceToolStripMenuItem.Size = new System.Drawing.Size(234, 22);
            this.floorsHeightPreferenceToolStripMenuItem.Text = "Floors\' height preference";
            this.floorsHeightPreferenceToolStripMenuItem.Click += new System.EventHandler(this.floorsHeightPreferenceToolStripMenuItem_Click);
            // 
            // lecturersOptionToolStripMenuItem
            // 
            this.lecturersOptionToolStripMenuItem.Name = "lecturersOptionToolStripMenuItem";
            this.lecturersOptionToolStripMenuItem.Size = new System.Drawing.Size(234, 22);
            this.lecturersOptionToolStripMenuItem.Text = "Preferred/denied lecturers";
            // 
            // timesOptionLectureTimesToolStripMenuItem
            // 
            this.timesOptionLectureTimesToolStripMenuItem.Name = "timesOptionLectureTimesToolStripMenuItem";
            this.timesOptionLectureTimesToolStripMenuItem.Size = new System.Drawing.Size(234, 22);
            this.timesOptionLectureTimesToolStripMenuItem.Text = "Preferred/denied lecture times";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.howToUseTheProgramToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // howToUseTheProgramToolStripMenuItem
            // 
            this.howToUseTheProgramToolStripMenuItem.Name = "howToUseTheProgramToolStripMenuItem";
            this.howToUseTheProgramToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.howToUseTheProgramToolStripMenuItem.Text = "How to use the program?";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // SubjectFilteringTextbox
            // 
            this.SubjectFilteringTextbox.Location = new System.Drawing.Point(686, 28);
            this.SubjectFilteringTextbox.Name = "SubjectFilteringTextbox";
            this.SubjectFilteringTextbox.Size = new System.Drawing.Size(116, 20);
            this.SubjectFilteringTextbox.TabIndex = 2;
            this.SubjectFilteringTextbox.TextChanged += new System.EventHandler(this.SubjectFilteringTextbox_TextChanged);
            // 
            // FilterLabel
            // 
            this.FilterLabel.AutoSize = true;
            this.FilterLabel.Location = new System.Drawing.Point(651, 31);
            this.FilterLabel.Name = "FilterLabel";
            this.FilterLabel.Size = new System.Drawing.Size(29, 13);
            this.FilterLabel.TabIndex = 4;
            this.FilterLabel.Text = "Filter";
            // 
            // CompulsorySubjectsGridView
            // 
            this.CompulsorySubjectsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CompulsorySubjectsGridView.Location = new System.Drawing.Point(654, 54);
            this.CompulsorySubjectsGridView.Name = "CompulsorySubjectsGridView";
            this.CompulsorySubjectsGridView.RowHeadersVisible = false;
            this.CompulsorySubjectsGridView.Size = new System.Drawing.Size(148, 319);
            this.CompulsorySubjectsGridView.TabIndex = 5;
            // 
            // TimetableControl
            // 
            this.TimetableControl.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.TimetableControl.Location = new System.Drawing.Point(12, 27);
            this.TimetableControl.Name = "TimetableControl";
            this.TimetableControl.Size = new System.Drawing.Size(633, 346);
            this.TimetableControl.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(408, 379);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Generate";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(489, 379);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Previous";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(570, 379);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 8;
            this.button3.Text = "Next";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(727, 379);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 9;
            this.button4.Text = "Refresh";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // showSelectionsToolStripMenuItem
            // 
            this.showSelectionsToolStripMenuItem.Name = "showSelectionsToolStripMenuItem";
            this.showSelectionsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.showSelectionsToolStripMenuItem.Text = "Show selections";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 414);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.CompulsorySubjectsGridView);
            this.Controls.Add(this.FilterLabel);
            this.Controls.Add(this.SubjectFilteringTextbox);
            this.Controls.Add(this.TimetableControl);
            this.Controls.Add(this._MainMenuStrip);
            this.Name = "MainForm";
            this.Text = "Timetable Scheduler";
            this._MainMenuStrip.ResumeLayout(false);
            this._MainMenuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CompulsorySubjectsGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip _MainMenuStrip;

        private System.Windows.Forms.ToolStripMenuItem dataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resetDatabaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem functionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nextChoiceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem previousChoiceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem floorsHeightPreferenceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lecturersOptionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem timesOptionLectureTimesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem howToUseTheProgramToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private TableCustomControl TimetableControl;
        private System.Windows.Forms.ToolStripMenuItem newSelectionToolStripMenuItem;
        private System.Windows.Forms.TextBox SubjectFilteringTextbox;
        private System.Windows.Forms.Label FilterLabel;
        private System.Windows.Forms.DataGridView CompulsorySubjectsGridView;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ToolStripMenuItem showSelectionsToolStripMenuItem;
    }
}

