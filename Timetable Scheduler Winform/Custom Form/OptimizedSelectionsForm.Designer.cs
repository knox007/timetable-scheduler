namespace TimetableSchedulerWinform.CustomForm
{
    partial class OptimizedSelectionsForm
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
            this.SelectionsGridView = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.SelectionFilteringTextbox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.SelectionsGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // SelectionsGridView
            // 
            this.SelectionsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SelectionsGridView.Location = new System.Drawing.Point(11, 38);
            this.SelectionsGridView.Name = "SelectionsGridView";
            this.SelectionsGridView.Size = new System.Drawing.Size(486, 252);
            this.SelectionsGridView.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Filter";
            // 
            // SelectionFilteringTextbox
            // 
            this.SelectionFilteringTextbox.Location = new System.Drawing.Point(47, 12);
            this.SelectionFilteringTextbox.Name = "SelectionFilteringTextbox";
            this.SelectionFilteringTextbox.Size = new System.Drawing.Size(100, 20);
            this.SelectionFilteringTextbox.TabIndex = 5;
            this.SelectionFilteringTextbox.TextChanged += new System.EventHandler(this.SelectionFilteringTextbox_TextChanged);
            // 
            // OptimizedSelectionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(510, 304);
            this.Controls.Add(this.SelectionFilteringTextbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SelectionsGridView);
            this.Name = "OptimizedSelectionsForm";
            this.Text = "SelectionListForm";
            ((System.ComponentModel.ISupportInitialize)(this.SelectionsGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView SelectionsGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox SelectionFilteringTextbox;
    }
}