using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace helpCenter
{
    internal class EmergencyReport
    {
        //Type of incident(like "Flood", "Injury", "Blockage")○ Area of the city(zone)
        //○ How serious it is ○ How long the problem might last ○ A short description
        internal string TypeOfIncident;
        internal string AreaOfTheCity;
        internal int HowSeriousItIs;
        internal string MightLast;
        internal string ShortDescription;

        internal EmergencyReport(string typeOfIncident,string areaOfTheCity,int howSeriousItIs,string mightLast,string shortDescription)
        {
            this.TypeOfIncident = typeOfIncident;
            this.AreaOfTheCity = areaOfTheCity;
            this.HowSeriousItIs = howSeriousItIs;
            this.MightLast = mightLast;
            this.ShortDescription = shortDescription;
        }




    }
}
