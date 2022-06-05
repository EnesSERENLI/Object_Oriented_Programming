using OOP_Example_Ecommerce.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Example_Ecommerce.Forms
{
    public partial class ErkekGiyimYonetimi : Form
    {
        public ErkekGiyimYonetimi()
        {
            InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            Giyim erkekGiyim = new Giyim();
            erkekGiyim.UrunEkle(txtKategori.Text, txtMarka.Text, nudFiyat.Value);
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            Giyim erkekGiyim = new Giyim();
            erkekGiyim.UrunSil(txtKategoriSil.Text, txtMarkaSil.Text);
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            Giyim erkekGiyim = new Giyim();
            erkekGiyim.UrunGuncelle(txtEskiKategori.Text, txtEskiMarka.Text, txtYeniKategori.Text, txtYeniMarka.Text, nudFiyat.Value);
        }
    }
}
