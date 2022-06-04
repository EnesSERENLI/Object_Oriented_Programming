using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction.Abstract
{
    public abstract class BaseClass
    {
        public BaseClass() //Constructor
        {
            CreatedDate = DateTime.Now;
        }
        //Custom Properties
        public DateTime CreatedDate { get; set; }
        public abstract bool IsActive { get; set; }

        //Methods

        public abstract string Add(object obj);
    }
}
