using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace helpCenter
{
    internal class DispatchCenter
    {
        
        static internal void ChecksGroup(List<EmergencyTeams> ListOfTeams, EmergencyReport report)
        {
            foreach (EmergencyTeams team in ListOfTeams)
                if (team.Checking(report) == "yes")
                {
                    team.RespondCheck();
                    team.availableFlag = false;
                    return;
                }
                
            Console.WriteLine("no one can help.");




        }
    }
}
