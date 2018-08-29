using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodosDeExtension
{
    class Program
    {
        static void Main(string[] args)
        {
            string ejemplo = "esta frase es un ejemplo";

            Console.WriteLine(ExtensionString.PrimeroMayusculas(ejemplo));

            ejemplo = "segunda frase";
            Console.WriteLine(ejemplo.PrimeroMayusculas());

            string ejemplo1 = "123456789";
            int n = ejemplo1.ContarPalabras();
            Console.WriteLine("Hay {0} palabras.", n);

            int valor1 = 10;

            valor1.ElevadoALa(4);

            Console.WriteLine(5.ElevadoALa(5));
            Console.WriteLine(7.ElevadoALa(2));
            Console.WriteLine(15.Doble());



            Console.Read();

        }
    }
}
