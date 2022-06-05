using OOP_Example_Ecommerce.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Example_Ecommerce.Concrete
{
    public class RAM:Urun
    {
        public RAM(string kapasite, decimal fiyat)
        {
            Kapasite = kapasite;
            Fiyat = fiyat;
        }
        public string Kapasite { get; set; }
        
        public override string ToString()
        {
            return Kapasite;
        }
    }
}
