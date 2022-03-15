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
            //TODO implement
            //throw new NotImplementedException();
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
                        listOfAppsToAdd.Add(new defaultApp(tempAppName, tempAppLocation));
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
        public string generateReport(List<string> report)
        {
            string fileReportName = DateTime.Now.ToString();
            fileReportName = fileReportName.Replace('/', '-');
            fileReportName = fileReportName.Replace(':', ';');
            File.WriteAllLines(fileReportName + ".txt", report);
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
    }
}
