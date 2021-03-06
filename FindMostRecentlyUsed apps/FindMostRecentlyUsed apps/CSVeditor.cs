using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.FileIO; 

namespace FindMostRecentlyUsed_apps
{
    internal class CSVeditor
    {
        public List<AppGroup> AppGroups = new List<AppGroup>();
        string defaultAppsListFilePath = "defaultAppGroups.csv";
        //default constructor
        public CSVeditor()
        {

        }
        //reads csv to get default app groups
        public void readCSVFile()
        {
            using (TextFieldParser csvParser = new TextFieldParser(defaultAppsListFilePath))
            {
                csvParser.CommentTokens = new string[] { "#" };
                csvParser.SetDelimiters(new string[] { "," });
                csvParser.HasFieldsEnclosedInQuotes = true;

                // Skip the row with the column names
                csvParser.ReadLine();
                string tempGroupName;
                string tempAppName;
                string tempAppLocation;
                string tempPrefetchName;
                List<defaultApp> listOfAppsToAdd; 
                while (!csvParser.EndOfData)
                {
                    //read line and add each field to a entry in the array
                    string[] fields = csvParser.ReadFields();
                    //create list of apps for new default 
                    listOfAppsToAdd = new List<defaultApp>(); //create new list of apps for each group
                    for (int i = 1; i < fields.Length; i++)
                    {
                        tempAppName = fields[i];
                        i++;
                        tempAppLocation = fields[i];
                        i++;
                        tempPrefetchName = fields[i];
                        listOfAppsToAdd.Add(new defaultApp(tempAppName, tempAppLocation, tempPrefetchName));
                        //tempGroupName = null;
                        //tempAppName = null;
                        //tempAppLocation = null;
                    }
                    //create group with new list that was just created
                    tempGroupName = fields[0];
                    //tempAppGroup = new AppGroup(tempGroupName, listOfAppsToAdd);
                    AppGroups.Add(new AppGroup(tempGroupName, listOfAppsToAdd));
                }
            }
        }

        //generate report based on list presented
        public string generateReport(List<string> report, string machineName)
        {
            string fileReportName = DateTime.Now.ToString();
            fileReportName = fileReportName.Replace('/', '-');
            fileReportName = fileReportName.Replace(':', ';');
            fileReportName = machineName + " " + fileReportName;
            File.WriteAllLines(fileReportName + ".csv", report);
            return fileReportName;


        }

        //add new app group
        public void addAppGroup(string newGroupName, List<defaultApp> listOfDefaultApps)
        {
            AppGroups.Add(new AppGroup(newGroupName, listOfDefaultApps));
        }

        //delete group
        public void deleteAppGroup(AppGroup group)
        {
            if (AppGroups.Contains(group))
            {
                AppGroups.Remove(group);
            }
        }

        //add app to group
        public void addAppToGroup(AppGroup group, defaultApp appToAdd)
        {
            for (int i = 0; i < AppGroups.Count; i++)
            {
                if(AppGroups[i] == group)
                {
                    AppGroups[i].addApp(appToAdd);
                }
            }
        }

        //delete app to group
        public void deleteAppFromGroup(AppGroup group, defaultApp appToRemove)
        {
            for (int i = 0; i < AppGroups.Count; i++)
            {
                if (AppGroups[i] == group)
                {
                    AppGroups[i].removeApp(appToRemove);
                }
            }
        }

        //calls WinPrefetchView.exe to generate a report on the prefetch files on the current system
        public void runPrefetchReportCommand(string reportFileName)
        {
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            startInfo.FileName = "cmd.exe";
            const string quote = "\"";
            startInfo.Arguments = "/C WinPrefetchView.exe /scomma " + quote + reportFileName + quote + " /sort " + quote + "Filename" + quote;
            startInfo.Verb = "runas";
            process.StartInfo = startInfo;
            process.Start();
        }

        //calls WinPrefetchView.exe to generate a report on the prefetch files on the current system
        public void runPrefetchReportCommandOverNetwork(string reportFileName, string machineName)
        {
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            startInfo.FileName = "cmd.exe";
            const string quote = "\"";
            string arg = "/C WinPrefetchView.exe /folder \\\\" + machineName + "\\C$\\Windows\\prefetch /scomma " + quote + reportFileName + quote + " /sort " + quote + "Filename" + quote;
            startInfo.Arguments = arg;
            startInfo.Verb = "runas";
            process.StartInfo = startInfo;
            process.Start();
        }

        //reads preftch file generated by WinPrefetchView.exe
        //TODO: needs access to list of apps for the specific group it's looking at
        public void readPrefetcCSVFile(string reportFileName, ref List<defaultApp> defaultApps)
        {
            using (TextFieldParser csvParser = new TextFieldParser(reportFileName))
            {
                csvParser.CommentTokens = new string[] { "#" };
                csvParser.SetDelimiters(new string[] { "," });
                csvParser.HasFieldsEnclosedInQuotes = true;

                while (!csvParser.EndOfData)
                {
                    //read line and add each field to a entry in the array
                    string[] fields = csvParser.ReadFields();

                    //check first field to see if the prefetch file is in the defaultApps list
                    //if it is get the fields with the run count and last run dates/times
                    //Run count field is index 6
                    //last run dates/times are index 7
                    foreach (defaultApp app in defaultApps)
                    {
                        if (fields[0] == app.prefetchName)
                        {
                            app.runCount = fields[6];
                            app.lastRunTime = fields[7];
                        }
                    }

                }
            }
        }
    }
}
