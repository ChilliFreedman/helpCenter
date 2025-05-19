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
            BringsSupplies bringsSupplies = new BringsSupplies("bringsSupplies", "jerusalim", true);

            EmergencyReport FirstReport = new EmergencyReport("bringsSupplies", "jerusalim", 8, "week", "no supplies left");
            EmergencyReport secondReport = new EmergencyReport("bringsSupplies", "jerusalim", 9, "2 weeks", "no supplies left");

            List<EmergencyTeams> list = new List<EmergencyTeams>() { flood ,injuries ,blockages,bringsSupplies };

            DispatchCenter.ChecksGroup(list, FirstReport);
            DispatchCenter.ChecksGroup(list, secondReport);


        }
    }
}
