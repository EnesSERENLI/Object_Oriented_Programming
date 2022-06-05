using Interface.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Interface
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Audi audi = new Audi();
            audi.Brand = "Audi";
            audi.Model = "A3";
            Console.WriteLine(audi.Start());
            Console.WriteLine(audi.Stop());

            Console.ReadLine();

            BoeingAirplane boeingAirplane = new BoeingAirplane();
            boeingAirplane.Brand = "Boeing";
            boeingAirplane.Model = "747";
            Console.WriteLine(boeingAirplane.Start());
            Console.WriteLine(boeingAirplane.Fly());
            Thread.Sleep(2000);
            Console.WriteLine(boeingAirplane.Stop());

            Console.WriteLine("----------------");
            
            Tesla tesla = new Tesla();
            tesla.Brand = "Tesla";
            tesla.Model = "Model S";
            Console.WriteLine(tesla.Start());
            Console.WriteLine(tesla.Autopilot());
            Console.WriteLine(tesla.Stop());    

            Console.ReadKey();
        }
    }
}
