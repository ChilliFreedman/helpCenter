using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace helpCenter
{
    internal class BringsSupplies : EmergencyTeams
    {

        internal BringsSupplies(string name, string region, bool availableFlag)
        : base(name, region, availableFlag) { }
        internal override string Checking(EmergencyReport report)
        {

            if (this.availableFlag == true && this.region == report.AreaOfTheCity && this.name == report.TypeOfIncident)
            {
                return "yes";
            }
            return "no";

        }

        internal override void RespondCheck()
        {
            Console.WriteLine($"{this.name} team are on the way");
        }
    }
}