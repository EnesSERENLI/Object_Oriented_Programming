using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Example_Ecommerce.Interface
{
    public interface IUrun
    {
        ListViewItem SepeteEkle(object obj);

        decimal TutarHesapla(object obj);
    }
}
