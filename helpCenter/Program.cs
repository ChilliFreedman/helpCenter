using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace helpCenter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Floods flood = new Floods("Floods","jerusalim",true);
            Injuries injuries = new Injuries("Injuries", "jerusalim", true);
            Blockages blockages = new Blockages("Blockages", "jerusalim", true);

            EmergencyReport FirstReport = new EmergencyReport("Floods", "jerusalim", 8, "week", "big floof");

            List<EmergencyTeams> list = new List<EmergencyTeams>() { flood ,injuries ,blockages };

            DispatchCenter.ChecksGroup(list, FirstReport);


        }
    }
}
