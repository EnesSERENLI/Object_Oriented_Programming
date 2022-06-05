using Interface.Abstract;
using Interface.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface.Concrete
{
    public class Audi : Vehicle,IVehicle
    {
        public override string MaxSpeed()
        {
            return Brand+" "+Model + " It speeds up to 320 km/h.";
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
