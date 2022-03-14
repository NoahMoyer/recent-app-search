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
        public string getAppLocation()
        {
            return appLocation;
        }
        public string getAppName()
        {
            return appName;
        }
       public string appName;
       public string appLocation;
        
    }
}
