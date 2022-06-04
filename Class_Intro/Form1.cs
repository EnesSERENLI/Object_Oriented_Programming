using System;
using System.Windows.Forms;

namespace Class_Intro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            Computer pc1 = new Computer();
            pc1.monitor = "Asus";
            pc1.displayCard = "Gforce";
            pc1.Processor = "I7";
            pc1.RAM = 8;

            MessageBox.Show($"Mobitor: {pc1.monitor} Display Card: {pc1.displayCard} Processor: {pc1.Processor} RAM: {pc1.RAM}");
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            Computer pc2 = new Computer("LG");
            pc2.RAM = 4;
            pc2.Processor = "I5";
            pc2.displayCard = "NVdia";

            MessageBox.Show($"Mobitor: {pc2.monitor} Display Card: {pc2.displayCard} Processor: {pc2.Processor} RAM: {pc2.RAM}");

        }

        private void btn3_Click(object sender, EventArgs e)
        {
            Computer pc3 = new Computer("ViewSonic", "RTX 3080", "I9", 16);
            MessageBox.Show($"Mobitor: {pc3.monitor} Display Card: {pc3.displayCard} Processor: {pc3.Processor} RAM: {pc3.RAM}");
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            //Initializer => We can create the object while getting the instance without needing the constructor.
            Computer pc4 = new Computer
            {
                monitor = "Rampage",
                displayCard = "RTX2060",
                Processor = "I7",
                RAM = 32
            };
            MessageBox.Show($"Mobitor: {pc4.monitor} Display Card: {pc4.displayCard} Processor: {pc4.Processor} RAM: {pc4.RAM}");
        }
    }
}
