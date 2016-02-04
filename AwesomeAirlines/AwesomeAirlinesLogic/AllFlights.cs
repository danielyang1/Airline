using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AwesomeAirlinesLogic
{
    public class AllFlights
    {
        FlightPlan TenAMChicago = new FlightPlan("Chicago", "154", "10:00 am", "10:46 am");
        FlightPlan TwelvePMChicago = new FlightPlan("Detroit", "155", "12:00 pm", "1:22 pm");
        FlightPlan TwoPMOmaha = new FlightPlan("Omaha", "156", "2:00 pm", "6:33 pm");
        FlightPlan FiveFifftyNineSanDiego = new FlightPlan("San Diego", "157", "5:59 pm", "12:20 am");

        List<string> ILikePlans;

        public void appendAllFlights()
        {
            ILikePlans.Add(TenAMChicago.ToString());
            ILikePlans.Add(TwelvePMChicago.ToString());
            ILikePlans.Add(TwoPMOmaha.ToString());
            ILikePlans.Add(FiveFifftyNineSanDiego.ToString());
        }
    }
}
