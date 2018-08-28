using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SobrecargaOperadores
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona juan = new Persona(5.0);

            Persona ana = new Persona(2.0);


        double salarioTotal = juan - ana;

            Console.WriteLine(salarioTotal);
            Console.Read();

        }
    }
}
