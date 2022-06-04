using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    public class Duck:Animal
    {
        //Polymorphism
        public override string Voice() // Override => The virtual defined voice method is crushed by override here.
        {
            return "Duck Voice: quack quack";
        }
    }
}
