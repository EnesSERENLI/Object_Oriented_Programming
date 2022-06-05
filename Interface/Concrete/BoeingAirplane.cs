using Interface.Abstract;
using Interface.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface.Concrete
{
    public class BoeingAirplane : Vehicle, IVehicle, IAirPlane
    {
        public string Fly()
        {
            return Brand + " " + Model + " started flying";
        }

        public override string MaxSpeed()
        {
            return Brand + " " + Model + " It speeds up to 1000 km/h.";
        }

        public string Start()
        {
            return Brand + " " + Model + " worked.";
        }

        public string Stop()
        {
            return Brand + " " + Model + " stopped.";
        }
    }
}
