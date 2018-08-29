using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodosDeExtension
{
    public static class IntegerExtensionsMethods
    {
        public static double ElevadoALa(this int valor, int exponente)
        {
            return Math.Pow(valor, exponente);
        }

        public static double Doble(this int valor)
        {
            return valor * 2;
        }


    }
}
