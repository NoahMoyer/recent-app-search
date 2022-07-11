using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindMostRecentlyUsed_apps
{
    internal class PrefetchParser
    {
        //default contructor
        public PrefetchParser()
        {

        }

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

    }
}
