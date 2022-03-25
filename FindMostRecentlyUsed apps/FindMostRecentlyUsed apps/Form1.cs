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


            
        }

        //check selected apps
        private void button1_Click(object sender, EventArgs e)
        {
            string tempValue;
            for (int i = 0; i < appsListBox.Items.Count; i++)
            {
                tempValue = "";
                FileInfo file = new FileInfo(appsListBox.Items[i].ToString());
                DateTime lasAccessed = file.LastAccessTime;//gets time app was last accessed
                //lasAccessed.ToString();
                tempValue = appsListBox.Items[i].ToString() + " Last accessed  " + lasAccessed.ToString();
                appsListBox.Items[i] = tempValue; //add string to list box
                fileReport.Add(tempValue); //add string to file report list so we can generate report later when the button is clicked
            }
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
                }

            }

            generateReportButton.Enabled = false;   

        }

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
                }
               
            }
        }

        //reset machine name to current machine
        private void resetMachineNameButton_Click(object sender, EventArgs e)
        {
            machineName = Environment.MachineName;
            currentMachineNameLabel.Text = "Current machine name: " + machineName; //load current machine name
            
            //when the name is changed we will want to update the app group based on the name
            foreach (AppGroup group in csveditor.AppGroups)
            {

                if (machineName.StartsWith(group.getGroupName()) /*&& defaultAppsSelectionBox.Items.Contains(Environment.MachineName.StartsWith(group.getGroupName()))*/)
                {

                    //defaultAppsSelectionBox.SelectedItem = defaultAppsSelectionBox.FindString(group.getGroupName());
                    defaultAppsSelectionBox.Text = group.getGroupName();
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
            //populate app list based on selected group name
            if (defaultAppsSelectionBox.SelectedItem != null)
            {
                foreach (AppGroup group in csveditor.AppGroups)
                {
                    if (group.getGroupName() == defaultAppsSelectionBox.SelectedItem.ToString())
                    {
                        foreach(defaultApp app in group.getAppsList())
                        {
                            appsListBox.Items.Add(app.getAppName() + " " + app.getAppLocation());
                        }
                    }
                }

            }
        }

        private void clearListButton_Click(object sender, EventArgs e)
        {
            appsListBox.Items.Clear();
            fileReport.Clear();
            generateReportButton.Enabled = false;   
        }

        private void refreshGroupsButton_Click(object sender, EventArgs e)
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
    }
    }

