using Abstraction.Abstract;
using Abstraction.FakeDatabase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction.Concrete
{
    public class Product : BaseClass
    {
        public string ProductName { get; set; }
        public decimal UnitPrice { get; set; }
        public short UnitsInStock { get; set; }
        public Category Category { get; set; }
        public Supplier Supplier { get; set; }

        //Encapsulation
        private bool _isActive;
        public override bool IsActive 
        {
            get
            {
                return _isActive;
            }
            set
            {
                if (UnitsInStock <= 0)
                {
                    value = false;
                    _isActive = value;
                }
                else
                {
                    value = true;
                    _isActive = value;
                }
            }
        }
        public override string Add(object obj)
        {
            Product p = (Product)obj;
            DataBase.productList.Add(p);
            return "Product eklendi.";
        }
    }
}
