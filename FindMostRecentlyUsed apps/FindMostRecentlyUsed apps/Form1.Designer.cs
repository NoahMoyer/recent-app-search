namespace FindMostRecentlyUsed_apps
{
    partial class Form1
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
            this.checkApps = new System.Windows.Forms.Button();
            this.currentMachineNameLabel = new System.Windows.Forms.Label();
            this.recentApplicationsLabel = new System.Windows.Forms.Label();
            this.machineNameTextBox = new System.Windows.Forms.TextBox();
            this.changeMachineNameButton = new System.Windows.Forms.Button();
            this.resetMachineNameButton = new System.Windows.Forms.Button();
            this.addAppsButton = new System.Windows.Forms.Button();
            this.appsListBox = new System.Windows.Forms.ListBox();
            this.removeApp = new System.Windows.Forms.Button();
            this.loadDefaultAppsBasedOnMachineName = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // checkApps
            // 
            this.checkApps.Location = new System.Drawing.Point(498, 233);
            this.checkApps.Name = "checkApps";
            this.checkApps.Size = new System.Drawing.Size(150, 23);
            this.checkApps.TabIndex = 1;
            this.checkApps.Text = "Check Selected Apps";
            this.checkApps.UseVisualStyleBackColor = true;
            this.checkApps.Click += new System.EventHandler(this.button1_Click);
            // 
            // currentMachineNameLabel
            // 
            this.currentMachineNameLabel.AutoSize = true;
            this.currentMachineNameLabel.Location = new System.Drawing.Point(495, 91);
            this.currentMachineNameLabel.Name = "currentMachineNameLabel";
            this.currentMachineNameLabel.Size = new System.Drawing.Size(119, 13);
            this.currentMachineNameLabel.TabIndex = 2;
            this.currentMachineNameLabel.Text = "Current machine name: ";
            this.currentMachineNameLabel.Click += new System.EventHandler(this.currentMachineName_Click);
            // 
            // recentApplicationsLabel
            // 
            this.recentApplicationsLabel.AutoSize = true;
            this.recentApplicationsLabel.Location = new System.Drawing.Point(86, 51);
            this.recentApplicationsLabel.Name = "recentApplicationsLabel";
            this.recentApplicationsLabel.Size = new System.Drawing.Size(102, 13);
            this.recentApplicationsLabel.TabIndex = 3;
            this.recentApplicationsLabel.Text = "Recent Applications";
            // 
            // machineNameTextBox
            // 
            this.machineNameTextBox.Location = new System.Drawing.Point(498, 119);
            this.machineNameTextBox.Name = "machineNameTextBox";
            this.machineNameTextBox.Size = new System.Drawing.Size(150, 20);
            this.machineNameTextBox.TabIndex = 4;
            // 
            // changeMachineNameButton
            // 
            this.changeMachineNameButton.Location = new System.Drawing.Point(654, 119);
            this.changeMachineNameButton.Name = "changeMachineNameButton";
            this.changeMachineNameButton.Size = new System.Drawing.Size(142, 23);
            this.changeMachineNameButton.TabIndex = 5;
            this.changeMachineNameButton.Text = "Change machine name";
            this.changeMachineNameButton.UseVisualStyleBackColor = true;
            this.changeMachineNameButton.Click += new System.EventHandler(this.changeMachineNameButton_Click);
            // 
            // resetMachineNameButton
            // 
            this.resetMachineNameButton.Location = new System.Drawing.Point(802, 119);
            this.resetMachineNameButton.Name = "resetMachineNameButton";
            this.resetMachineNameButton.Size = new System.Drawing.Size(126, 23);
            this.resetMachineNameButton.TabIndex = 6;
            this.resetMachineNameButton.Text = "Reset machine name";
            this.resetMachineNameButton.UseVisualStyleBackColor = true;
            this.resetMachineNameButton.Click += new System.EventHandler(this.resetMachineNameButton_Click);
            // 
            // addAppsButton
            // 
            this.addAppsButton.Location = new System.Drawing.Point(498, 146);
            this.addAppsButton.Name = "addAppsButton";
            this.addAppsButton.Size = new System.Drawing.Size(75, 23);
            this.addAppsButton.TabIndex = 7;
            this.addAppsButton.Text = "Add apps";
            this.addAppsButton.UseVisualStyleBackColor = true;
            this.addAppsButton.Click += new System.EventHandler(this.addAppsButton_Click);
            // 
            // appsListBox
            // 
            this.appsListBox.FormattingEnabled = true;
            this.appsListBox.Location = new System.Drawing.Point(60, 91);
            this.appsListBox.Name = "appsListBox";
            this.appsListBox.Size = new System.Drawing.Size(365, 186);
            this.appsListBox.TabIndex = 8;
            // 
            // removeApp
            // 
            this.removeApp.Location = new System.Drawing.Point(498, 175);
            this.removeApp.Name = "removeApp";
            this.removeApp.Size = new System.Drawing.Size(93, 23);
            this.removeApp.TabIndex = 9;
            this.removeApp.Text = "Remove App";
            this.removeApp.UseVisualStyleBackColor = true;
            this.removeApp.Click += new System.EventHandler(this.removeApp_Click);
            // 
            // loadDefaultAppsBasedOnMachineName
            // 
            this.loadDefaultAppsBasedOnMachineName.Location = new System.Drawing.Point(498, 204);
            this.loadDefaultAppsBasedOnMachineName.Name = "loadDefaultAppsBasedOnMachineName";
            this.loadDefaultAppsBasedOnMachineName.Size = new System.Drawing.Size(161, 23);
            this.loadDefaultAppsBasedOnMachineName.TabIndex = 10;
            this.loadDefaultAppsBasedOnMachineName.Text = "Load default apps based on machine name";
            this.loadDefaultAppsBasedOnMachineName.UseVisualStyleBackColor = true;
            this.loadDefaultAppsBasedOnMachineName.Click += new System.EventHandler(this.loadDefaultAppsBasedOnMachineName_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1134, 719);
            this.Controls.Add(this.loadDefaultAppsBasedOnMachineName);
            this.Controls.Add(this.removeApp);
            this.Controls.Add(this.appsListBox);
            this.Controls.Add(this.addAppsButton);
            this.Controls.Add(this.resetMachineNameButton);
            this.Controls.Add(this.changeMachineNameButton);
            this.Controls.Add(this.machineNameTextBox);
            this.Controls.Add(this.recentApplicationsLabel);
            this.Controls.Add(this.currentMachineNameLabel);
            this.Controls.Add(this.checkApps);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button checkApps;
        private System.Windows.Forms.Label currentMachineNameLabel;
        private System.Windows.Forms.Label recentApplicationsLabel;
        private System.Windows.Forms.TextBox machineNameTextBox;
        private System.Windows.Forms.Button changeMachineNameButton;
        private System.Windows.Forms.Button resetMachineNameButton;
        private System.Windows.Forms.Button addAppsButton;
        private System.Windows.Forms.ListBox appsListBox;
        private System.Windows.Forms.Button removeApp;
        private System.Windows.Forms.Button loadDefaultAppsBasedOnMachineName;
    }
}

