using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    public class Animal
    {
        public bool CanFly { get; set; }
        public int NumberOfFeet { get; set; }

        public virtual string Voice() //virtual => represents that it can optionally be crushed.
        {
            return "Animal Voice";
        }
    }
}
