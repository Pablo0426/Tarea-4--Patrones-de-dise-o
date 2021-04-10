using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Singleton_form
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Jamon form = Jamon.objeto();
            form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Pepperoni form = Pepperoni.objeto();
            form.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Doble_queso form = Doble_queso.objeto();
            form.Show();
        }
    }
}
