using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Factory_Csharp
{
    class Fabrica: Inicio
    {
        public static ILaptop fabrica(string laptop)
        {
            ILaptop interface1 = null;
            if(laptop == "MSI GL75")
            {
                interface1 = new MSI();
                interface1.mostrar();
            }
            if (laptop == "ASUS TUF Dash 15")
            {
                interface1 = new Asus();
                interface1.mostrar();
            }
            if (laptop == "Lenovo Legion 5")
            {
                interface1 = new Lenovo();
                interface1.mostrar();
            }
            return interface1;
        }
    }
}
