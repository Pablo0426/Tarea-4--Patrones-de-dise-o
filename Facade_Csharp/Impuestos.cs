using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade_Csharp
{
    //Calculo para las ARS o SFS en base al sueldo
    class SFS_ARS
    {
        public double ARS(int sueldo, double ARS )
        {
            double Calc_ARS;
            if (sueldo > 134820)
            {
                Calc_ARS = 134820 * ARS;
            }
            else
            {
                Calc_ARS = sueldo * ARS;
            }
            return Calc_ARS;
        }
    }

    //Calculo para el AFP en base al sueldo
    class AFP
    {
        public double _AFP(int sueldo, double afp)
        {
            double Calc_AFP;
            if (sueldo > 269640)
            {
                Calc_AFP = 269640 * afp;
            }
            else
            {
                Calc_AFP = sueldo * afp;
            }
            return Calc_AFP;
        }
    }
}
