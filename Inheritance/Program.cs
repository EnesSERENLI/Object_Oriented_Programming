using Inheritance.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Processor processor = new Processor();
            processor.ID = 1;
            processor.Brand = "Intel I7";
            processor.UnitPrice = 5000;

            DisplayCard displayCard = new DisplayCard();
            displayCard.ID = 1;
            displayCard.Brand = "GForce RTX 2060";
            displayCard.Capacity = "6GB";
            displayCard.UnitPrice = 10000;

            Computer computer = new Computer();
            computer.ID = 1;
            computer.Brand = "Monster";
            computer.RAM = 16;
            computer.DisplayCard = displayCard;
            computer.Processor = processor;
            computer.UnitPrice =5000 + displayCard.UnitPrice + processor.UnitPrice;

            Console.WriteLine("ID: "+computer.ID+" Brand: "+computer.Brand+" Price "+computer.UnitPrice +" Processor "+computer.Processor.Brand+" DisplayCard "+computer.DisplayCard.Brand);

            Console.ReadKey();
        }
    }
}
