using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UtilizandoPI
{
    internal class Calculadora
    {
        public static double Diametro(double raio)
        {
            return 2.0 * raio;
        }

        public static double Circunferencia(double raio)
        {
            return 2.0 * Math.PI * raio;
        }

        public static double Volume(double raio)
        {
            return (4 / 3.0) * Math.PI * Math.Pow(raio, 3.0);
        }
    }
}
