using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface.Abstract
{
    public abstract class Vehicle
    {
        public string Brand { get; set; }
        public string Model { get; set; }

        public abstract string MaxSpeed();
    }
}
