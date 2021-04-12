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
    public partial class Jamon : Form
    {
        private Jamon()
        {
            InitializeComponent();
        }

        private void Jamon_Load(object sender, EventArgs e)
        {

        }

        private static Jamon pizza;

        public static Jamon objeto() //Solo podra generarse unua sola ventana de esta clase
        {
            if (pizza == null)
            {
                pizza = new Jamon();
            }
            pizza.BringToFront();
            return pizza;
        }
    }
}
