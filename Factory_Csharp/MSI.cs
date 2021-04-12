using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Factory_Csharp
{
    public partial class MSI : Form, ILaptop
    {
        public MSI()
        {
            InitializeComponent();
        }

        string processor = "i7 10750h";
        string Ram = "16gb 2666Mhz";
        string grafics = "RTX 2060";
        string storage = "M.2 500GB";
        string Screen = "1920x1080p 144Hz";
        string Precio = "RD $750000";

        public void mostrar()
        {
            this.Show();
            label1.Text = processor;
            label2.Text = Ram;
            label3.Text = grafics;
            label4.Text = storage;
            label5.Text = Screen;
            label6.Text = Precio;

        }

        private void MSI_Load(object sender, EventArgs e)
        {
            mostrar();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Producto agregado.");
        }
    }
}
