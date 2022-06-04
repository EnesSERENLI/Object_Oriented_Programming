using System.Windows.Forms;

namespace Class_Intro
{
    public class Computer //Create a class
    {
        //Class Creation Rules
        /*
        1- Class names must be defined in PascalCase.
        2- Class names cannot start with special characters and numbers.
        */

        /*
         Access Modifiers => Erişim belirteçleri
        -private
        -internal
        -public
        -protected
        -protected internal
         */

        //Field => Variables defined inside the class
        internal string monitor;
        internal string displayCard;

        //Property
        internal string Processor { get; set; }
        public int RAM { get; set; }


        public Computer() //Constructor 1
        {
            MessageBox.Show("No definition made");
        }
        public Computer(string monitor) //Constructor 2
        {
            this.monitor = monitor;
        }

        public Computer(string monitor,string displayCard) //Constructor 3
        {
            this.monitor=monitor;
            this.displayCard=displayCard;
        }
        public Computer(string monitor, string displayCard, string processor) //Constructor 4
        {
            this.monitor = monitor;
            this.displayCard = displayCard;
            this.Processor = processor;
        }
        public Computer(string monitor, string displayCard, string processor, int ram) //Constructor 5
        {
            this.monitor = monitor;
            this.displayCard = displayCard;
            Processor = processor;
            RAM = ram;
        }
    }
}
