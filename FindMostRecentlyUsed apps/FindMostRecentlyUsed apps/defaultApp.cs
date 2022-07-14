using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMostRecentlyUsed_apps
{
    internal class defaultApp
    {
        public defaultApp(string newAppName, string newAppLocation, string newPrefetchName)
        {
            appName = newAppName;
            appLocation = newAppLocation;
            prefetchName = newPrefetchName;
        }

        public string appName { get; private set; }
       public string appLocation { get; set; }
        public string prefetchName { get; set; }
        public string runCount { get; set; }
        public string lastRunTime { get; set; }

    }
}
