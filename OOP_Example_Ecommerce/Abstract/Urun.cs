using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Example_Ecommerce.Abstract
{
    public abstract class Urun
    {
        public decimal Fiyat { get; set; }       
        public decimal Adet { get; set; }
        public decimal KDVFiyat
        {
            get => ToplamTutar * 1.18m;
        }
        public decimal ToplamTutar { get; set; }
    }
}
