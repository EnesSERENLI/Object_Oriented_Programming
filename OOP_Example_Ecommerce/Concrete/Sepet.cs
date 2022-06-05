using OOP_Example_Ecommerce.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Example_Ecommerce.Concrete
{
    public class Sepet
    {
        public static List<Urun> sepetim = new List<Urun>();

        //Methods
        public decimal SepetSettings(ListView lst)
        {
            decimal toplamSepetTutari = 0;
            foreach (Urun urun in sepetim)
            {
                ListViewItem lvi = new ListViewItem();
                if (urun is Computer)
                {
                    Computer bilgisayar = (Computer)urun;
                    lvi.Text = "Bilgisayar";
                    lvi.SubItems.Add("Elektronik");
                    lvi.SubItems.Add(bilgisayar.Adet.ToString());
                    lvi.SubItems.Add(bilgisayar.TutarHesapla(bilgisayar).ToString("C2"));
                    lvi.SubItems.Add(bilgisayar.KDVFiyat.ToString("C2"));
                    lst.Items.Add(lvi);
                    toplamSepetTutari += bilgisayar.TutarHesapla(bilgisayar);
                }
                if (urun is Giyim)
                {
                    Giyim giyim = (Giyim)urun;
                    lvi.Text = giyim.Kategori;
                    lvi.SubItems.Add("Giyim");
                    lvi.SubItems.Add(giyim.Adet.ToString());
                    lvi.SubItems.Add(giyim.TutarHesapla(giyim).ToString("C2"));
                    lvi.SubItems.Add(giyim.KDVFiyat.ToString("C2"));
                    lst.Items.Add(lvi);
                    toplamSepetTutari += giyim.TutarHesapla(giyim);
                }
            }
            return toplamSepetTutari * 1.18m;
        }
    }
}
