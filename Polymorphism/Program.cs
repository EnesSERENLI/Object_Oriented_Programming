using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Duck duck = new Duck();
            duck.CanFly = false;
            duck.NumberOfFeet = 2;

            string duckVoice = duck.Voice();
            Console.WriteLine($"Duck => Canfly:{duck.CanFly} Feet:{duck.NumberOfFeet} {duckVoice}");
            Console.WriteLine("-------------------");

            Cat cat = new Cat();
            cat.CanFly = false;
            cat.NumberOfFeet = 4;

            string catVoice = cat.Voice();
            Console.WriteLine($"Cat => Canfly:{cat.CanFly} Feet:{cat.NumberOfFeet} {catVoice}");
            Console.WriteLine("-------------------");

            Mouse mouse = new Mouse();
            mouse.CanFly = false;
            mouse.NumberOfFeet = 4;

            string mouseVoice = mouse.Voice();
            Console.WriteLine($"Mouse => Canfly:{mouse.CanFly} Feet:{mouse.NumberOfFeet} {mouseVoice}");

            Console.Read();
        }
    }
}
