using Inheritance.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.Concrete
{
    public class Computer : Product //Computer inherits from product. In other words, it contains all the features of the product.
    {
        public Processor Processor { get; set; }
        public DisplayCard DisplayCard { get; set; }
        public int RAM { get; set; }
    }
}
