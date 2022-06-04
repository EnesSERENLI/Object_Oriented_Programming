using Abstraction.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Category c = new Category();
            c.CategoryName = "Telefon";
            c.Description = "asdasd";
            string result1 = c.Add(c);

            Supplier supplier = new Supplier();
            supplier.CompanyName = "Asus";
            supplier.Address = "asdasd";
            supplier.PhoneNumber = "123871238";
            string result2 = supplier.Add(supplier);

            Product product = new Product();
            product.Category = c;
            product.Supplier = supplier;
            product.ProductName = "Zenfone";
            product.UnitPrice = 3000;
            product.UnitsInStock = 0;
            product.IsActive = true;

            string result3 = product.Add(product);

            Console.WriteLine(result1 + "\n" + result2 + "\n" + result3);

            Console.WriteLine(product.ProductName+" "+product.CreatedDate + " " + product.IsActive);
            Console.Read();
        }
    }
}
