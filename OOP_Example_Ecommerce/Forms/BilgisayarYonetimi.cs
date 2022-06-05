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
    public partial class BilgisayarYonetimi : Form
    {
        public BilgisayarYonetimi()
        {
            InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (txtMarka.Text != null && txtModel.Text != null)
            {
                Computer pc = new Computer();
                pc.UrunEkle(txtMarka.Text, txtModel.Text, nudFiyat.Value); 
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            Computer pc = new Computer();
            pc.UrunSil(txtMarkaSil.Text, txtModelSil.Text);
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            Computer pc = new Computer();
            pc.UrunGuncelle(txtEskiMarka.Text, txtEskiModel.Text, txtYeniMarka.Text, txtYeniModel.Text, nudFiyat.Value);
        }
    }
}
