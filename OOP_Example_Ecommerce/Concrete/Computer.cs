using OOP_Example_Ecommerce.Abstract;
using OOP_Example_Ecommerce.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Example_Ecommerce.Concrete
{
    public class Computer : Urun, IUrun, IUrunYonetimi
    {
        public Computer()
        {

        }
        public Computer(string marka, string model, decimal fiyat)
        {
            Marka = marka;
            Model = model;
            Fiyat = fiyat;
        }
        public string Marka { get; set; }
        public string Model { get; set; }
        public RAM RAM { get; set; }
        public EkranKarti EkranKarti { get; set; }

        public override string ToString()
        {
            return Model;
        }

        //Methods
        public ListViewItem SepeteEkle(object obj)
        {
            Computer bilgisayar = (Computer)obj;
            ListViewItem lvi = new ListViewItem();
            lvi.Text = bilgisayar.Marka;
            lvi.SubItems.Add(bilgisayar.Model);
            lvi.SubItems.Add(bilgisayar.RAM.ToString());
            lvi.SubItems.Add(bilgisayar.EkranKarti.ToString());
            lvi.SubItems.Add(bilgisayar.Adet.ToString());
            lvi.SubItems.Add(bilgisayar.TutarHesapla(bilgisayar).ToString("C2"));
            lvi.SubItems.Add(bilgisayar.KDVFiyat.ToString("C2"));
            return lvi;
        }

        public decimal TutarHesapla(object obj)
        {
            Computer bilgisayar = (Computer)obj;
            bilgisayar.ToplamTutar = bilgisayar.Adet * (bilgisayar.Fiyat + bilgisayar.RAM.Fiyat + bilgisayar.EkranKarti.Fiyat);
            return bilgisayar.ToplamTutar;
        }

        public void UrunEkle(string marka, string model, decimal fiyat)
        {
            Computer pc = new Computer();
            pc.Marka = marka;
            pc.Model = model;
            pc.Fiyat = fiyat;
            FakeDatabase.Database.computerList.Add(pc);
        }

        public void UrunSil(string marka, string model)
        {
            foreach (Computer pc in FakeDatabase.Database.computerList)
            {
                if (pc.Marka == marka && pc.Model == model)
                {
                    FakeDatabase.Database.computerList.Remove(pc);
                    break;
                }
            }
        }

        public void UrunGuncelle(string eskiMarka, string eskiModel, string yeniMarka, string yeniModel, decimal fiyat)
        {
            foreach (Computer pc in FakeDatabase.Database.computerList)
            {
                if (pc.Marka == eskiMarka && pc.Model == eskiModel)
                {
                    pc.Marka = yeniMarka;
                    pc.Model = yeniModel;
                    pc.Fiyat = fiyat;
                }
            }
        }
    }
}
