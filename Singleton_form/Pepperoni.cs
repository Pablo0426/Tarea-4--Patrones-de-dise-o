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
    public partial class Pepperoni : Form
    {
        private Pepperoni()
        {
            InitializeComponent();
        }

        private void Pepperoni_Load(object sender, EventArgs e)
        {

        }

        private static Pepperoni pizza;

        public static Pepperoni objeto()
        {
            if (pizza == null)
            {
                pizza = new Pepperoni();
            }
            pizza.BringToFront();
            return pizza;
        }
    }
}
