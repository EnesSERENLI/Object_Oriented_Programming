using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    public class Mouse : Animal
    {
        //Polymorphism
        public override string Voice()
        {
            return "Mouse Voice: squeak squeak";
        }
    }
}
