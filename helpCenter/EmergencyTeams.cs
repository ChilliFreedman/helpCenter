using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace helpCenter
{
    internal class EmergencyTeams
    {
        internal string name;
        internal string region;
        internal bool availableFlag;

        internal EmergencyTeams(string name, string region, bool availableFlag)
        {
            this.name = name;
            this.region = region;
            this.availableFlag = availableFlag;
        }
        internal virtual string Checking(EmergencyReport report)
        {
            return "no";
        }
        internal virtual void RespondCheck()
        {
            Console.WriteLine("cannot respond");
        }
    }


}
