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
            this.defaultAppsSelectionBox = new System.Windows.Forms.ComboBox();
            this.defaultAppGroupsLabel = new System.Windows.Forms.Label();
            this.populateListButton = new System.Windows.Forms.Button();
            this.clearListButton = new System.Windows.Forms.Button();
            this.refreshGroupsButton = new System.Windows.Forms.Button();
            this.generateReportButton = new System.Windows.Forms.Button();
            this.appsGridView = new System.Windows.Forms.DataGridView();
            this.NameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LocationColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastAccessedColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prefetchname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Runcounter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lastruntime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.appsGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // checkApps
            // 
            this.checkApps.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.checkApps.Location = new System.Drawing.Point(60, 463);
            this.checkApps.Name = "checkApps";
            this.checkApps.Size = new System.Drawing.Size(150, 23);
            this.checkApps.TabIndex = 1;
            this.checkApps.Text = "Check Selected Apps";
            this.checkApps.UseVisualStyleBackColor = true;
            this.checkApps.Click += new System.EventHandler(this.button1_Click);
            // 
            // currentMachineNameLabel
            // 
            this.currentMachineNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.currentMachineNameLabel.AutoSize = true;
            this.currentMachineNameLabel.Location = new System.Drawing.Point(57, 349);
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
            this.machineNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.machineNameTextBox.Location = new System.Drawing.Point(60, 377);
            this.machineNameTextBox.Name = "machineNameTextBox";
            this.machineNameTextBox.Size = new System.Drawing.Size(150, 20);
            this.machineNameTextBox.TabIndex = 4;
            this.machineNameTextBox.TextChanged += new System.EventHandler(this.machineNameTextBox_TextChanged);
            // 
            // changeMachineNameButton
            // 
            this.changeMachineNameButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.changeMachineNameButton.Location = new System.Drawing.Point(215, 374);
            this.changeMachineNameButton.Name = "changeMachineNameButton";
            this.changeMachineNameButton.Size = new System.Drawing.Size(142, 23);
            this.changeMachineNameButton.TabIndex = 5;
            this.changeMachineNameButton.Text = "Change machine name";
            this.changeMachineNameButton.UseVisualStyleBackColor = true;
            this.changeMachineNameButton.Click += new System.EventHandler(this.changeMachineNameButton_Click);
            // 
            // resetMachineNameButton
            // 
            this.resetMachineNameButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.resetMachineNameButton.Location = new System.Drawing.Point(363, 374);
            this.resetMachineNameButton.Name = "resetMachineNameButton";
            this.resetMachineNameButton.Size = new System.Drawing.Size(126, 23);
            this.resetMachineNameButton.TabIndex = 6;
            this.resetMachineNameButton.Text = "Reset machine name";
            this.resetMachineNameButton.UseVisualStyleBackColor = true;
            this.resetMachineNameButton.Click += new System.EventHandler(this.resetMachineNameButton_Click);
            // 
            // addAppsButton
            // 
            this.addAppsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.addAppsButton.Enabled = false;
            this.addAppsButton.Location = new System.Drawing.Point(60, 405);
            this.addAppsButton.Name = "addAppsButton";
            this.addAppsButton.Size = new System.Drawing.Size(150, 23);
            this.addAppsButton.TabIndex = 7;
            this.addAppsButton.Text = "Add apps";
            this.addAppsButton.UseVisualStyleBackColor = true;
            this.addAppsButton.Visible = false;
            this.addAppsButton.Click += new System.EventHandler(this.addAppsButton_Click);
            // 
            // appsListBox
            // 
            this.appsListBox.Enabled = false;
            this.appsListBox.FormattingEnabled = true;
            this.appsListBox.Location = new System.Drawing.Point(60, 520);
            this.appsListBox.Name = "appsListBox";
            this.appsListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.appsListBox.Size = new System.Drawing.Size(991, 186);
            this.appsListBox.TabIndex = 8;
            this.appsListBox.Visible = false;
            this.appsListBox.SelectedIndexChanged += new System.EventHandler(this.appsListBox_SelectedIndexChanged);
            // 
            // removeApp
            // 
            this.removeApp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.removeApp.Enabled = false;
            this.removeApp.Location = new System.Drawing.Point(60, 434);
            this.removeApp.Name = "removeApp";
            this.removeApp.Size = new System.Drawing.Size(150, 23);
            this.removeApp.TabIndex = 9;
            this.removeApp.Text = "Remove App";
            this.removeApp.UseVisualStyleBackColor = true;
            this.removeApp.Visible = false;
            this.removeApp.Click += new System.EventHandler(this.removeApp_Click);
            // 
            // defaultAppsSelectionBox
            // 
            this.defaultAppsSelectionBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.defaultAppsSelectionBox.FormattingEnabled = true;
            this.defaultAppsSelectionBox.Location = new System.Drawing.Point(532, 376);
            this.defaultAppsSelectionBox.Name = "defaultAppsSelectionBox";
            this.defaultAppsSelectionBox.Size = new System.Drawing.Size(121, 21);
            this.defaultAppsSelectionBox.TabIndex = 11;
            this.defaultAppsSelectionBox.SelectedIndexChanged += new System.EventHandler(this.defaultAppsSelectionBox_SelectedIndexChanged);
            // 
            // defaultAppGroupsLabel
            // 
            this.defaultAppGroupsLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.defaultAppGroupsLabel.AutoSize = true;
            this.defaultAppGroupsLabel.Location = new System.Drawing.Point(532, 349);
            this.defaultAppGroupsLabel.Name = "defaultAppGroupsLabel";
            this.defaultAppGroupsLabel.Size = new System.Drawing.Size(97, 13);
            this.defaultAppGroupsLabel.TabIndex = 12;
            this.defaultAppGroupsLabel.Text = "Default app groups";
            // 
            // populateListButton
            // 
            this.populateListButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.populateListButton.Location = new System.Drawing.Point(532, 407);
            this.populateListButton.Name = "populateListButton";
            this.populateListButton.Size = new System.Drawing.Size(97, 23);
            this.populateListButton.TabIndex = 13;
            this.populateListButton.Text = "Populate List";
            this.populateListButton.UseVisualStyleBackColor = true;
            this.populateListButton.Click += new System.EventHandler(this.populateListButton_Click);
            // 
            // clearListButton
            // 
            this.clearListButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.clearListButton.Location = new System.Drawing.Point(532, 436);
            this.clearListButton.Name = "clearListButton";
            this.clearListButton.Size = new System.Drawing.Size(97, 23);
            this.clearListButton.TabIndex = 14;
            this.clearListButton.Text = "Clear List";
            this.clearListButton.UseVisualStyleBackColor = true;
            this.clearListButton.Click += new System.EventHandler(this.clearListButton_Click);
            // 
            // refreshGroupsButton
            // 
            this.refreshGroupsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.refreshGroupsButton.Location = new System.Drawing.Point(669, 376);
            this.refreshGroupsButton.Name = "refreshGroupsButton";
            this.refreshGroupsButton.Size = new System.Drawing.Size(95, 23);
            this.refreshGroupsButton.TabIndex = 15;
            this.refreshGroupsButton.Text = "Refresh Groups";
            this.refreshGroupsButton.UseVisualStyleBackColor = true;
            this.refreshGroupsButton.Click += new System.EventHandler(this.refreshGroupsButton_Click);
            // 
            // generateReportButton
            // 
            this.generateReportButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.generateReportButton.Location = new System.Drawing.Point(532, 465);
            this.generateReportButton.Name = "generateReportButton";
            this.generateReportButton.Size = new System.Drawing.Size(97, 23);
            this.generateReportButton.TabIndex = 16;
            this.generateReportButton.Text = "Generate Report";
            this.generateReportButton.UseVisualStyleBackColor = true;
            this.generateReportButton.Click += new System.EventHandler(this.generateReportButton_Click);
            // 
            // appsGridView
            // 
            this.appsGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.appsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.appsGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NameColumn,
            this.LocationColumn,
            this.LastAccessedColumn,
            this.Prefetchname,
            this.Runcounter,
            this.Lastruntime});
            this.appsGridView.Location = new System.Drawing.Point(60, 91);
            this.appsGridView.Name = "appsGridView";
            this.appsGridView.Size = new System.Drawing.Size(1003, 218);
            this.appsGridView.TabIndex = 17;
            this.appsGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // NameColumn
            // 
            this.NameColumn.HeaderText = "Name";
            this.NameColumn.Name = "NameColumn";
            // 
            // LocationColumn
            // 
            this.LocationColumn.HeaderText = "Location";
            this.LocationColumn.Name = "LocationColumn";
            // 
            // LastAccessedColumn
            // 
            this.LastAccessedColumn.HeaderText = "Last Accessed";
            this.LastAccessedColumn.Name = "LastAccessedColumn";
            // 
            // Prefetchname
            // 
            this.Prefetchname.HeaderText = "Prefetch Name";
            this.Prefetchname.Name = "Prefetchname";
            // 
            // Runcounter
            // 
            this.Runcounter.HeaderText = "Run Counter";
            this.Runcounter.Name = "Runcounter";
            // 
            // Lastruntime
            // 
            this.Lastruntime.HeaderText = "Last Run Time";
            this.Lastruntime.Name = "Lastruntime";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 561);
            this.Controls.Add(this.appsGridView);
            this.Controls.Add(this.generateReportButton);
            this.Controls.Add(this.refreshGroupsButton);
            this.Controls.Add(this.clearListButton);
            this.Controls.Add(this.populateListButton);
            this.Controls.Add(this.defaultAppGroupsLabel);
            this.Controls.Add(this.defaultAppsSelectionBox);
            this.Controls.Add(this.removeApp);
            this.Controls.Add(this.appsListBox);
            this.Controls.Add(this.addAppsButton);
            this.Controls.Add(this.resetMachineNameButton);
            this.Controls.Add(this.changeMachineNameButton);
            this.Controls.Add(this.machineNameTextBox);
            this.Controls.Add(this.recentApplicationsLabel);
            this.Controls.Add(this.currentMachineNameLabel);
            this.Controls.Add(this.checkApps);
            this.MinimumSize = new System.Drawing.Size(1200, 600);
            this.Name = "Form1";
            this.Text = "Recent Application Usage Analyzer";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.appsGridView)).EndInit();
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
        private System.Windows.Forms.ComboBox defaultAppsSelectionBox;
        private System.Windows.Forms.Label defaultAppGroupsLabel;
        private System.Windows.Forms.Button populateListButton;
        private System.Windows.Forms.Button clearListButton;
        private System.Windows.Forms.Button refreshGroupsButton;
        private System.Windows.Forms.Button generateReportButton;
        private System.Windows.Forms.DataGridView appsGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn LocationColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastAccessedColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prefetchname;
        private System.Windows.Forms.DataGridViewTextBoxColumn Runcounter;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lastruntime;
    }
}

