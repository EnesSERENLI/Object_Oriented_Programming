using OOP_Example_Ecommerce.Abstract;
using OOP_Example_Ecommerce.Enum;
using OOP_Example_Ecommerce.Interface;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace OOP_Example_Ecommerce.Concrete
{
    public class Giyim : Urun, IUrun, IUrunYonetimi
    {
        public Giyim()
        {

        }
        public Giyim(string kategori, string marka, decimal fiyat)
        {
            Kategori = kategori;
            Marka = marka;
            Fiyat = fiyat;
        }
        public string Kategori { get; set; }
        public string Marka { get; set; }
        public KumasTipi KumasTipi { get; set; }
        public Beden Beden { get; set; }
        public Color Renk { get; set; }

        public override string ToString()
        {
            return Marka;
        }

        //Methods
        public decimal TutarHesapla(object obj)
        {
            Giyim giyim = (Giyim)obj;
            ToplamTutar = giyim.Fiyat * giyim.Adet;
            return ToplamTutar;
        }
        public ListViewItem SepeteEkle(object obj)
        {
            Giyim giyim = (Giyim)obj;
            ListViewItem lvi = new ListViewItem();
            lvi.UseItemStyleForSubItems = false;
            lvi.Text = giyim.Kategori;
            lvi.SubItems.Add(giyim.Marka);
            lvi.SubItems.Add(giyim.Beden.ToString());
            lvi.SubItems.Add(giyim.KumasTipi.ToString());
            lvi.SubItems.Add("");
            lvi.SubItems[4].BackColor = giyim.Renk;
            lvi.SubItems.Add(giyim.Adet.ToString());
            lvi.SubItems.Add(giyim.TutarHesapla(giyim).ToString("C2"));
            lvi.SubItems.Add(giyim.KDVFiyat.ToString("C2"));
            return lvi;
        }

        public void UrunEkle(string kategori, string marka, decimal fiyat)
        {
            Giyim erkekGiyim = new Giyim();
            erkekGiyim.Kategori = kategori;
            erkekGiyim.Marka = marka;
            erkekGiyim.Fiyat = fiyat;
            FakeDatabase.Database.erkekGiyimListesi.Add(erkekGiyim);
        }
        public void UrunEkle(decimal fiyat, string kategori, string marka)
        {
            Giyim kadinGiyim = new Giyim();
            kadinGiyim.Kategori = kategori;
            kadinGiyim.Marka = marka;
            kadinGiyim.Fiyat = fiyat;
            FakeDatabase.Database.kadinGiyimListesi.Add(kadinGiyim);
        }

        public void UrunSil(string kategori, string marka)
        {
            foreach (Giyim erkek in FakeDatabase.Database.erkekGiyimListesi)
            {
                if (erkek.Kategori == kategori && erkek.Marka == marka)
                {
                    FakeDatabase.Database.erkekGiyimListesi.Remove(erkek);
                    break;
                }
            }
            foreach (Giyim kadin in FakeDatabase.Database.kadinGiyimListesi)
            {
                if (kadin.Kategori == kategori && kadin.Marka == marka)
                {
                    FakeDatabase.Database.kadinGiyimListesi.Remove(kadin);
                    break;
                }
            }
        }

        public void UrunGuncelle(string eskiKategori, string eskiMarka, string yeniKategori, string yeniMarka, decimal fiyat)
        {
            foreach (Giyim erkek in FakeDatabase.Database.erkekGiyimListesi)
            {
                if (erkek.Kategori == eskiKategori && erkek.Marka == eskiMarka)
                {
                    erkek.Kategori = yeniKategori;
                    erkek.Marka = yeniMarka;
                    erkek.Fiyat = fiyat;
                }
            }
            foreach (Giyim kadin in FakeDatabase.Database.kadinGiyimListesi)
            {
                if (kadin.Kategori == eskiKategori && kadin.Marka == eskiMarka)
                {
                    kadin.Kategori = yeniKategori;
                    kadin.Marka = yeniMarka;
                    kadin.Fiyat = fiyat;
                }
            }
        }
    }
}
