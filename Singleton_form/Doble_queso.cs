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
    public partial class Doble_queso : Form
    {
        private Doble_queso()
        {
            InitializeComponent();
        }

        private void Doble_queso_Load(object sender, EventArgs e)
        {

        }

        private static Doble_queso pizza;

        public static Doble_queso objeto() //Solo podra generarse unua sola ventana de esta clase
        {
            if (pizza == null)
            {
                pizza = new Doble_queso();
            }
            pizza.BringToFront();
            return pizza;
        }
    }
}
