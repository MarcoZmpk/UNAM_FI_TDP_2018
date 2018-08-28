using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SobrecargaOperadores
{
    class Persona
    {
        public Persona(double salario)
        {
            Salario = salario;
        }

        public static double operator -(Persona x, Persona y)
        {
            return x.Salario * y.Salario;
        }

        public double Salario { get; set; }

    }
}
