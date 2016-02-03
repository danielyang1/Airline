using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AwesomeAirlinesLogic
{
    public class AirPlaneHanger
    {
        Plane Marionette = new Plane(true, 3000);
        Plane Veromos = new Plane(true, 3500);
        Plane Luhen = new Plane(true, 3300);
        Plane Mangel = new Plane(true, 3500);

        List<Plane> ILikePlanes = new List<Plane>();

        public void addPlanesToHanger()
        {
            ILikePlanes.Add(Luhen);
            ILikePlanes.Add(Marionette);
            ILikePlanes.Add(Mangel);
            ILikePlanes.Add(Veromos);
        }
    }
}
