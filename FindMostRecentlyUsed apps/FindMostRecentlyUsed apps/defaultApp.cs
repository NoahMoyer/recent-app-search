using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMostRecentlyUsed_apps
{
    internal class defaultApp
    {
        public defaultApp(string newAppName, string newAppLocation)
        {
            appName = newAppName;
            appLocation = newAppLocation;
        }
        public void setAppLocation(string newLocation)
        {
            appLocation = newLocation;
        }
        public string getAppLocation()
        {
            return appLocation;
        }
        public string getAppName()
        {
            return appName;
        }
        public string getprefetchName()
        {
            return prefetchName;
        }
        public string getrunCount()
        {
            return runCount;
        }
        public string getlastRunTime()
        {
            return lastRunTime;
        }
        public string appName;
       public string appLocation;
        public string prefetchName;
        public string runCount;
        public string lastRunTime;
        
    }
}
