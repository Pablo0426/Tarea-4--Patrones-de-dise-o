using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade_Csharp
{
    class Fachada
    {
        SFS_ARS ars = new SFS_ARS();
        AFP afp = new AFP();

        //Constantes para los calculos
        double ARS = 0.0304;
        double AFP = 0.0287;
        public double taxARS(int sueldo)
        {
            double Calculo_ars = ars.ARS(sueldo, ARS);
            return Calculo_ars;
        }

        public double taxAFP(int sueldo)
        {
            double Calculo = afp._AFP(sueldo, AFP);
            return Calculo;
        }
    }
}
