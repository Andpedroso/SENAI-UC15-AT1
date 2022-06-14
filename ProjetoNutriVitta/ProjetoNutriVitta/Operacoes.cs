using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoNutriVitta
{
    public static class Operacoes
    {
        public static double CalcularImc(double pNum, double aNum)
        {
            return (pNum / (aNum * aNum));
        }

        public static double CompararImc(double iNum)
        {
            if(iNum < 18.5)
            {
                return 1;
            }

            else if (iNum > 18.5 && iNum < 24.9)
            {
                return 2;
            }

            else if (iNum > 25.0 && iNum < 29.9)
            {
                return 3;
            }

            else if (iNum > 30.0 && iNum < 34.9)
            {
                return 4;
            }

            else if (iNum > 35.0 && iNum < 39.9)
            {
                return 5;
            }

            else if (iNum > 40.0)
            {
                return 6;
            }

            return 0;
        }
    }
}
