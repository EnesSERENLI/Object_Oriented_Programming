using OOP_Example_Ecommerce.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Example_Ecommerce.Concrete
{
    public class EkranKarti:Urun
    {
        public EkranKarti(string marka, decimal fiyat)
        {
            Marka = marka;
            Fiyat = fiyat;
        }
        public string Marka { get; set; }
        public override string ToString()
        {
            return Marka;
        }
    }
}
