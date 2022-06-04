using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_Classes
{
    public class Employee
    {
        public Employee()
        {
            PersonalQuantity++; // The number of personnel will increase with each instance taken. Since it is defined as static, it will continue to increase continuously.
            StartingDate = DateTime.Now;
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public DateTime StartingDate { get; set; }

        //Static Property
        public static int PersonalQuantity { get; set; }

        //Static List
        public static List<Employee> employeeList = new List<Employee>();
    }
}
