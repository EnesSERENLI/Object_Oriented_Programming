using Abstraction.Abstract;
using Abstraction.FakeDatabase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction.Concrete
{
    public class Supplier : BaseClass
    {
        public string CompanyName { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public override bool IsActive { get; set; }

        public override string Add(object obj)
        {
            Supplier s = (Supplier)obj;
            DataBase.supplierList.Add(s);
            return "Supplier Eklendi";
        }
    }
}
