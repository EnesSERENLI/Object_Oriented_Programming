using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Encapsulation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void AddList(Shoe shoe)
        {
            ListViewItem lvi = new ListViewItem();
            lvi.Text = shoe.Brand;
            lvi.SubItems.Add(shoe.Size.ToString()); 
            lvi.SubItems.Add(shoe.Price.ToString("C2"));
            lvi.SubItems.Add(shoe.KDVPrice.ToString("C2"));

            listView1.Items.Add(lvi);
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            Shoe shoe = new Shoe();
            shoe.Brand = txtBrand.Text;
            shoe.Size = Convert.ToInt32(nudSize.Value);
            shoe.Price = Convert.ToInt32(nudPrice.Value);
            //shoe.KDVPrice = shoe.Price * 1.18m; => We gave this in class. Value assignment cannot be made externally.

            MessageBox.Show(shoe.KDVPrice.ToString());

            AddList(shoe);
        }
    }
}
