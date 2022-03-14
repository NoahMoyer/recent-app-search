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
            
            for (int i = 0; i < appsListBox.Items.Count; i++)
            {
                FileInfo file = new FileInfo(appsListBox.Items[i].ToString());
                DateTime lasAccessed = file.LastAccessTime;//gets time app was last accessed
                //lasAccessed.ToString();
                appsListBox.Items[i] = appsListBox.Items[i].ToString() + " Last accessed  " + lasAccessed.ToString();
               
            }
        }

        private void currentMachineName_Click(object sender, EventArgs e)
        {

        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            //update machine name to current machine when form loads
            currentMachineNameLabel.Text = "Current machine name: " + Environment.MachineName; //load current machine name
            
        }

        //change current machine to typed one
        private void changeMachineNameButton_Click(object sender, EventArgs e)
        {
            currentMachineNameLabel.Text = "Current machine name: " + machineNameTextBox.Text;
        }

        //reset machine name to current machine
        private void resetMachineNameButton_Click(object sender, EventArgs e)
        {
            currentMachineNameLabel.Text = "Current machine name: " + Environment.MachineName; //load current machine name
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
                            appsListBox.Items.Add(app.getAppLocation());
                        }
                    }
                }

            }
        }

        private void clearListButton_Click(object sender, EventArgs e)
        {
            appsListBox.Items.Clear();
        }
    }
    }

