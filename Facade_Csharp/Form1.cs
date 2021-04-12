using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Facade_Csharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Fachada fachada = new Fachada();
        private void button1_Click(object sender, EventArgs e)
        {
            int sueldo = int.Parse(textBox1.Text);
            var ars = fachada.taxARS(sueldo);
            var afp = fachada.taxAFP(sueldo);
            MessageBox.Show("En base al sueldo, tal empledado debe pagar: RD $"+ars+" de ARS/SFS y RD $"+afp+" de AFP");
        }
    }
}
