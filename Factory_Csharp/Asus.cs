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
    public partial class Asus : Form, ILaptop
    {
        public Asus()
        {
            InitializeComponent();
        }

        private void Asus_Load(object sender, EventArgs e)
        {
            mostrar();
        }

        string processor = "Ryzen 7 4800h";
        string Ram = "8gb 2666Mhz";
        string grafics = "GTX 1650";
        string storage = "M.2 1T";
        string Screen = "1920x1080p 120Hz";
        string Precio = "RD $620000";

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

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Producto agregado.");
        }
    }
}

