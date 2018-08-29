using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodosDeExtension
{
    public static class ExtensionString
    {
        public static string PrimeroMayusculas(this String s)
        {
            if ((s == null) || (s.Length == 0))
            {
                return s;
            }
            else if (s.Length == 1)
            {

                return s.ToUpper();
            }
            else
            {
                return s.Substring(0, 1).ToUpper() + s.Substring(1, s.Length - 1);
            }
        }

        public static int ContarPalabras(this string texto)
        {
            return texto.Split('5').Length;
        }




    }
}
