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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        void Settings(Form childform)
        {
            this.Width = childform.Width + 5;
            this.Height = childform.Height + 30;
            bool durum = false;
            foreach (Form _child in this.MdiChildren)
            {
                if (_child.Text == childform.Text)
                {
                    _child.Activate();
                    durum = true;
                }
                else
                {
                    _child.Close();
                }
            }
            if (durum == false)
            {
                childform.MdiParent = this;
                childform.StartPosition = FormStartPosition.Manual;
                childform.FormBorderStyle = FormBorderStyle.None;
                childform.Show();
            }
        }
        public static void Reset(GroupBox grp)
        {
            foreach (Control ctrl in grp.Controls)
            {
                if (ctrl is ComboBox)
                {
                    ComboBox cmb = (ComboBox)ctrl;
                    cmb.SelectedIndex = -1;
                }
                else if (ctrl is NumericUpDown)
                {
                    NumericUpDown nud = (NumericUpDown)ctrl;
                    nud.Value = 1;
                }
            }
        }
        private void computerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Settings(new Bilgisayar());
        }

        private void erkekGiyimToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Settings(new ErkekGiyim());
        }

        private void kadınGiyimToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Settings(new KadinGiyim()); 
        }

        private void sepetimToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Settings(new Sepetim());
        }

        private void bilgisayarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Settings(new BilgisayarYonetimi());
        }

        private void erkekGiyimToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Settings(new ErkekGiyimYonetimi());
        }

        private void kadınGiyimToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Settings(new KadinGiyimYonetimi());
        }
    }
}
