using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Encapsulation
{
    public class Shoe
    {
        public string Brand { get; set; }

        //Encapsulation
        private int _size;
        public int Size
        {
            get 
            { 
                return _size; 
            }
            set 
            {
                if (value >= 36 && value <= 44)
                {
                    _size = value;
                }
                else
                {
                    MessageBox.Show("This shoe size is not available!");
                }
            }
        }

        public decimal Price { get; set; }
        public decimal KDVPrice 
        {
            //Read Only => If the set part is deleted from a property, it cannot be assigned a value from outside.
            get
            {
                return Price * 1.18m;
            }
        }
    }
}
