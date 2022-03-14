using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMostRecentlyUsed_apps
{
    internal class AppGroup
    {
        public AppGroup(string newGroupName, List<defaultApp> listOfDefaultApps)
        {
            groupName = newGroupName;
            defaultApps = listOfDefaultApps;
        }
        public void addApp(defaultApp appToAdd)
        {
            defaultApps.Add(appToAdd);
        }
        public void removeApp(defaultApp appToRemove)
        {
            if (defaultApps.Contains(appToRemove))
            {
                defaultApps.Remove(appToRemove);
            }
        }
        private string groupName;
        private List<defaultApp> defaultApps = new List<defaultApp>();
    }
}
