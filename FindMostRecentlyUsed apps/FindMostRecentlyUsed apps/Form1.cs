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
        public Form1()
        {
            InitializeComponent();
            
        }

        //check selected apps
        private void button1_Click(object sender, EventArgs e)
        {
            FileInfo file = new FileInfo();
            foreach (string app in appsListBox.Items)
            {

            }
        }

        private void currentMachineName_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
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
    }
    }

