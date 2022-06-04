using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //The number will automatically increase with each personnel we add.

            Employee employee1 = new Employee();
            employee1.FirstName = "Enes";
            employee1.LastName = "Serenli";

            Console.WriteLine("Personal Quantity: "+Employee.PersonalQuantity);

            Employee employee2 = new Employee();
            employee2.FirstName = "Semih";
            employee2.LastName = "Serenli";

            Console.WriteLine("Personal Quantity: " + Employee.PersonalQuantity);

            Employee employee3 = new Employee();
            employee3.FirstName = "Fatih";
            employee3.LastName = "Serenli";

            Console.WriteLine("Personal Quantity: " + Employee.PersonalQuantity);

            //Static values can be reached without taking instances.
            Employee.employeeList.Add(employee1);
            Employee.employeeList.Add(employee2);
            Employee.employeeList.Add(employee3);


            foreach (Employee employee in Employee.employeeList)
            {
                Console.WriteLine(employee.FirstName + " " + employee.LastName);
            }
            Console.Read();
        }
    }
}
