using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    public class Cat :Animal
    {
        //Polymorphism
        public override string Voice()
        {
            return "Cat Voice: Meow Meow";
        }
    }
}
