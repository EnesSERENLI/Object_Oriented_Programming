using Inheritance.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.Concrete
{
    public class DisplayCard: Product //DisplayCard inherits from product
    {
        public string Capacity { get; set; }
    }
}
