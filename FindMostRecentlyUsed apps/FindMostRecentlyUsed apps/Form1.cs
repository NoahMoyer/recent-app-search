using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace FindMostRecentlyUsed_apps
{
    public partial class Form1 : Form
    {
        OpenFileDialog openFileDialog = new OpenFileDialog(); //file dialog for selecting applications to look at
        CSVeditor csveditor = new CSVeditor();//editor for file containing app groups
        List<string> fileReport = new List<string>();
        public string machineName;
        string prefetchReportName = "prefetchReport.csv";
        AppGroup selectedAppGroup;
        public Form1()
        {
            InitializeComponent();
            //on load we want to open a file that contains default app groups
            if (File.Exists("defaultAppGroups.csv"))
            {
                csveditor.readCSVFile();
                foreach (AppGroup group in csveditor.AppGroups)
                {
                    defaultAppsSelectionBox.Items.Add(group.getGroupName());
                }
            }
            else if (!File.Exists("defaultAppGroups.csv"))
            {
                File.Create("defaultAppGroups.csv");
            }

            //need to generate report from WinPrefetchView on prefetch files and parse the data
            csveditor.runPrefetchReportCommand(prefetchReportName);

            


        }

        //check selected apps
        private void button1_Click(object sender, EventArgs e)
        {
            this.AcceptButton = generateReportButton;
            string tempValue;
            //string appLocaiton;
            FileInfo file = null;
            DateTime lastAccessed = DateTime.Parse("6/12/1997 9:00:00 AM");//set initial value
            string runCount = "";
            string lastRunDate = "";

            //getting data from prefetch report
            csveditor.readPrefetcCSVFile(prefetchReportName, ref selectedAppGroup.defaultApps);
            //selecting app group
            foreach (AppGroup group in csveditor.AppGroups)
            {
                if (defaultAppsSelectionBox.Text == group.getGroupName())
                {
                    selectedAppGroup = group;
                }
            }

            string appNameInList;
            //loop through apps in display
            for (int i = 0; i < appsGridView.Rows.Count - 1; i++)
            {
                tempValue = "";
                //appNameInList = appsGridView.Rows[i].Cells[0].Value.ToString();
                    if (selectedAppGroup == null)
                    {
                        break;
                    }
                    //loop through defaultApps list in selected group
                    foreach(defaultApp app in selectedAppGroup.defaultApps)
                    {
                        //do this once we get to the app in the display that mathces the app in the group
                        if (appsGridView.Rows[i].Cells[0].Value.ToString() == app.appName) 
                        {
                            file = new FileInfo(app.appLocation);
                            if (file.Exists)
                            {
                                lastAccessed = file.LastAccessTime;//gets time app was last accessed
                                
                            }
                            else if (!file.Exists)
                            {
                                lastAccessed = DateTime.Parse("6/12/1400 9:00:00 AM");
                            }
                        //TODO: need to get data from prefetchCSVfile
                        runCount = app.runCount;
                        lastRunDate = app.lastRunTime;
                    }
                    }
                
                

                //using gridViewBox for better data veiwing
                               
                if (lastAccessed.ToString() == "6/12/1400 9:00:00 AM")
                {
                    appsGridView.Rows[i].Cells[2].Value = "App not installed/not accessible";
                }
                else
                {
                    appsGridView.Rows[i].Cells[2].Value = lastAccessed.ToString();
                    appsGridView.Rows[i].Cells[4].Value = runCount;
                    appsGridView.Rows[i].Cells[5].Value = lastRunDate;

                }


                //chandge entry to add access time to the end of the line displaying the app
                tempValue = appsGridView.Rows[i].Cells[0].Value + ",Last accessed," + appsGridView.Rows[i].Cells[2].Value.ToString() + ",Run count," + runCount + ",Last run dates," + lastRunDate;
                //add the same line from the display to the report
                fileReport.Add(tempValue); //add string to file report list so we can generate report later when the button is clicked
            }
            //allow report to be generated
            generateReportButton.Enabled = true;
        }

        private void currentMachineName_Click(object sender, EventArgs e)
        {

        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            //update machine name to current machine when form loads
            machineName = Environment.MachineName;
            currentMachineNameLabel.Text = "Current machine name: " + machineName; //load current machine name

            //TODO
            //when form loads we want to select the app group based on the prefix of the computer name
            foreach (AppGroup group in csveditor.AppGroups)
            {

                if (machineName.StartsWith(group.getGroupName()) /*&& defaultAppsSelectionBox.Items.Contains(Environment.MachineName.StartsWith(group.getGroupName()))*/)
                {

                    //defaultAppsSelectionBox.SelectedItem = defaultAppsSelectionBox.FindString(group.getGroupName());
                    defaultAppsSelectionBox.Text = group.getGroupName();
                    selectedAppGroup = group;
                }

            }

            generateReportButton.Enabled = false;   

        }


        //TODO: need to make the prefetch file report able to access prefetch files over the network
        //change current machine to typed one
        private void changeMachineNameButton_Click(object sender, EventArgs e)
        {
            machineName = machineNameTextBox.Text;
            currentMachineNameLabel.Text = "Current machine name: " + machineName;

            
            //when the name is changed we will want to update the app group based on the name
            foreach (AppGroup group in csveditor.AppGroups)
            {

                if (machineName.StartsWith(group.getGroupName()) /*&& defaultAppsSelectionBox.Items.Contains(Environment.MachineName.StartsWith(group.getGroupName()))*/)
                {

                //defaultAppsSelectionBox.SelectedItem = defaultAppsSelectionBox.FindString(group.getGroupName());
                     defaultAppsSelectionBox.Text = group.getGroupName();
                     selectedAppGroup = group;
                }
               
            }

            //would like to be able to check computers over the network. Will attempt that here by changing location from C: to \\machinename\location
            appsListBox.Items.Clear();
            appsGridView.Rows.Clear();
            foreach(AppGroup group in csveditor.AppGroups)
            {
                if (group.getGroupName() == defaultAppsSelectionBox.Text)
                {
                    foreach (defaultApp app in group.defaultApps)
                    {
                        app.appLocation = "\\\\" + machineName + "\\C$" + app.appLocation.Substring(2);
                        //appsListBox.Items.Add(app.getAppName() + " " + app.getAppLocation());
                    }
                }
            }
            //this should change the locations to the network based location of another machine
        }

        //reset machine name to current machine
        private void resetMachineNameButton_Click(object sender, EventArgs e)
        {
            //we will want to reset the app locations and list
            appsListBox.Items.Clear();
            appsGridView.Rows.Clear();
            refreshGroups();

            machineName = Environment.MachineName;
            currentMachineNameLabel.Text = "Current machine name: " + machineName; //load current machine name
            
            //when the name is changed we will want to update the app group based on the name
            foreach (AppGroup group in csveditor.AppGroups)
            {

                if (machineName.StartsWith(group.getGroupName()) /*&& defaultAppsSelectionBox.Items.Contains(Environment.MachineName.StartsWith(group.getGroupName()))*/)
                {

                    //defaultAppsSelectionBox.SelectedItem = defaultAppsSelectionBox.FindString(group.getGroupName());
                    defaultAppsSelectionBox.Text = group.getGroupName();
                    selectedAppGroup = group;
                }

            }
        }

        //allow user to add apps to look at
        private void addAppsButton_Click(object sender, EventArgs e)
        {
            //fileDialog options
            openFileDialog.InitialDirectory = @"C:\";
            //openFileDialog.Multiselect = true;
            openFileDialog.Filter = "Apps (*.EXE)|*.EXE|" +
                                    "All files (*.*)|*.*";
            //open fileDialog
            openFileDialog.ShowDialog();

            //add selected app to list to view
            //if (openFileDialog.ShowDialog() == DialogResult.OK)
            //{
                //foreach (string app in openFileDialog.FileNames)
                //{
                    appsListBox.Items.Add(openFileDialog.FileName);
                   
            //}
            //}

        }

        private void removeApp_Click(object sender, EventArgs e)
        {
            //remove selected item
            appsListBox.Items.Remove(appsListBox.SelectedItem);
        }

        private void loadDefaultAppsBasedOnMachineName_Click(object sender, EventArgs e)
        {
            //TODO: implement based on department names
        }

        private void populateListButton_Click(object sender, EventArgs e)
        {
            this.AcceptButton = checkApps;
            //populate app list based on selected group name
            if (defaultAppsSelectionBox.SelectedItem != null)
            {
                foreach (AppGroup group in csveditor.AppGroups)
                {
                    if (group.getGroupName() == defaultAppsSelectionBox.SelectedItem.ToString())
                    {
                        
                        foreach (defaultApp app in group.getAppsList())
                        {
                            appsListBox.Items.Add(app.appName + " " + app.appLocation);
                            
                            //using gridViewBox for better data veiwing
                            int n = appsGridView.Rows.Add();
                            appsGridView.Rows[n].Cells[0].Value = app.appName;
                            appsGridView.Rows[n].Cells[1].Value = app.appLocation;
                            appsGridView.Rows[n].Cells[3].Value = app.prefetchName;
                        }
                    }
                }

            }

            
        }

        private void clearListButton_Click(object sender, EventArgs e)
        {
            appsListBox.Items.Clear();
            appsGridView.Rows.Clear();
            fileReport.Clear();
            generateReportButton.Enabled = false;   
        }

        private void refreshGroupsButton_Click(object sender, EventArgs e)
        {
            refreshGroups();
        }

        public void refreshGroups()
        {
            //clear list before remaking it
            defaultAppsSelectionBox.Items.Clear();
            csveditor.AppGroups.Clear();
            //refresh groups list
            if (File.Exists("defaultAppGroups.csv"))
            {
                csveditor.readCSVFile();
                foreach (AppGroup group in csveditor.AppGroups)
                {
                    defaultAppsSelectionBox.Items.Add(group.getGroupName());
                }
            }
            else if (!File.Exists("defaultAppGroups.csv"))
            {
                File.Create("defaultAppGroups.csv");
            }

            //need to generate report from WinPrefetchView on prefetch files and parse the data
            csveditor.runPrefetchReportCommand(prefetchReportName);
        }

        //kind of janky way to copy output to clipboard
        private void appsListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            System.Text.StringBuilder copy_buffer = new System.Text.StringBuilder();
            foreach (object item in appsListBox.Items)
                copy_buffer.AppendLine(item.ToString());
            if (copy_buffer.Length > 0)
                Clipboard.SetText(copy_buffer.ToString());
        }

        public static string reportName;
        //generate report based on apps generated
        private void generateReportButton_Click(object sender, EventArgs e)
        {
            reportName = csveditor.generateReport(fileReport);
            reportGeneratedPopUp popUp = new reportGeneratedPopUp();
            DialogResult result = popUp.ShowDialog();
            if (result == DialogResult.OK)
            {
                popUp.Dispose();
            }
        }

        private void machineNameTextBox_TextChanged(object sender, EventArgs e)
        {
            this.AcceptButton = changeMachineNameButton;
        }

        private void defaultAppsSelectionBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.AcceptButton = populateListButton;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
    }

