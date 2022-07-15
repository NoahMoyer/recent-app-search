namespace FindMostRecentlyUsed_apps
{
    partial class reportGeneratedPopUp
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
            this.reportGenerated = new System.Windows.Forms.Label();
            this.okayButton = new System.Windows.Forms.Button();
            this.reportNameLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // reportGenerated
            // 
            this.reportGenerated.AutoSize = true;
            this.reportGenerated.Location = new System.Drawing.Point(77, 33);
            this.reportGenerated.Name = "reportGenerated";
            this.reportGenerated.Size = new System.Drawing.Size(104, 13);
            this.reportGenerated.TabIndex = 0;
            this.reportGenerated.Text = "Report generated as";
            this.reportGenerated.Click += new System.EventHandler(this.reportGenerated_Click);
            // 
            // okayButton
            // 
            this.okayButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.okayButton.Location = new System.Drawing.Point(94, 82);
            this.okayButton.Name = "okayButton";
            this.okayButton.Size = new System.Drawing.Size(64, 23);
            this.okayButton.TabIndex = 1;
            this.okayButton.Text = "OK";
            this.okayButton.UseVisualStyleBackColor = true;
            this.okayButton.Click += new System.EventHandler(this.okayButton_Click);
            // 
            // reportNameLabel
            // 
            this.reportNameLabel.AutoSize = true;
            this.reportNameLabel.Location = new System.Drawing.Point(95, 56);
            this.reportNameLabel.Name = "reportNameLabel";
            this.reportNameLabel.Size = new System.Drawing.Size(63, 13);
            this.reportNameLabel.TabIndex = 2;
            this.reportNameLabel.Text = "report name";
            // 
            // reportGeneratedPopUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(274, 144);
            this.Controls.Add(this.reportNameLabel);
            this.Controls.Add(this.okayButton);
            this.Controls.Add(this.reportGenerated);
            this.Name = "reportGeneratedPopUp";
            this.Text = "reportGeneratedPopUp";
            this.Load += new System.EventHandler(this.reportGeneratedPopUp_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label reportGenerated;
        private System.Windows.Forms.Button okayButton;
        private System.Windows.Forms.Label reportNameLabel;
    }
}