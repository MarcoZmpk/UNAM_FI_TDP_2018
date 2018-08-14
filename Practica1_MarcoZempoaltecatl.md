## Universidad Nacional Autónoma de México
### Facultad de Ingeniería
#### Técnicas de Programación - Ingeniería Mecatrónica

##### *Clases y objetos*

*No de práctica: 1*

1. *Objetivos de aprendizaje* 
 
I. Objetivos generales:  Entender la diferencia entre clase y objeto. 
 
 
II. Objetivos específicos:
 
* Aprender a diseñar clases. 
* Entender el funcionamiento de los constructores. 
* Identificar los atributos y los métodos. 
* Aprender a crear objetos. 
 
2. *Introducción*
 
Una clase es una construcción que permite crear tipos personalizados de datos mediante la agrupación de diversas variables, métodos y eventos. 
Una clase es como un plano. Define los datos y el comportamiento de un tipo de datos. Si la clase no se declara como estática, el código de cliente puede utilizarla mediante la creación de objetos o instancias que se asignan a una variable. 
A través de una clase se define un tipo de objeto, pero no es propiamente un objeto. Un objeto es una entidad concreta basada en una clase y, a veces, se denomina instancia de una clase. 
Las clases contienen atributos que son un tipo de datos que guarda información y también son considerados como metadatos.
Las clases también incluyen métodos, que son bloques de código que contienen una serie de instrucciones. 
Cada vez que se crea un objeto, se llama al constructor de la clase. Una clase puede tener varios constructores que toman argumentos diferentes. Los constructores permiten al programador establecer valores predeterminados, limitar la creación de instancias y escribir código flexible y fácil de leer

3. *Desarrollo*
 
I. Actividad 1
*Diseño de una clase*
 
A partir de un objeto real, elija al menos 3 características que lo identifiquen y 2 acciones que definan su comportamiento. 
Posteriormente, realice una abstracción para definir una clase o plantilla para ese tipo de objetos, que incluya un mínimo de 3 atributos de diferentes tipos (enteros, flotantes, cadenas, booleanos, etc.) y al menos 6 métodos que sean necesarios para escribir/leer los valores de los atributos y/o para interactuar con los objetos.  Incluya también al menos 2 constructores para la clase.

 Perro |
--------|
int Altura |
string Raza |
int Peso |
void Correr() |
void Ladrar() |
int getAltura() |
void setAltura() |
string getRaza() |
void setRaza() |
string getPeso() |
void setPeso() |

II. Actividad 2 
*Creación de objetos*
 
Mediante la creación de objetos, realice pruebas de escritorio para verificar el funcionamiento correcto de su clase y, de ser necesario, realice los ajustes y correcciones adecuados. 
Las pruebas deben incluir, sin limitarse a ello, los siguientes puntos: 
 
* Verificación de todos los constructores implementados. 
* Comprobación de la correcta asignación de valores a cada uno de los atributos definidos. 
* Verificación de todos los métodos programados.

*Clase Perro*


```
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caninos
{
    class Perro
    {
        private string nombre;
        private string tamaño;
        private int edad;

        public Boolean perroConHambre = false;
        public string Nombre { get => nombre; set => nombre = value; }
        public string Tamaño { get => tamaño; set => tamaño = value; }
        public int Edad { get => edad; set => edad = value; }

        enum TiposDeComida { AGUA, CROQUETAS, BASURA }

        public Perro(string nombreDelPerro, int edaddelPerro)
        {
            nombre = nombreDelPerro;
            edad = edaddelPerro;
        }

        public Perro()
        {

        }

        public Boolean dormir(int hora)
        {
            int horaDeDormir = 9;

            if (hora > horaDeDormir)
                return true;
            else
                return false;
        }

        public bool cagar(bool perroConHambre)
        {
            if (perroConHambre)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        void jugar()
        {

        }

        void ladrar()
        {

        }

        public bool comer(int tipoDeComida)
        {
            switch (tipoDeComida)
            {
                case (int)TiposDeComida.AGUA:
                    return false;
                    break;
                case (int)TiposDeComida.CROQUETAS:
                    return true;
                    break;
                case (int)TiposDeComida.BASURA:
                    return true;
                    break;
                default:
                    return false;
                    break;
            }
                                  
        }

    }
}

```

* Main Class*

```
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Caninos
{
    class Program
    {
        enum TiposDeComida { AGUA, CROQUETAS, BASURA }

        static void Main(string[] args)
        {
            bool perroConHambre = false;
            string comida = "";
            Perro Perro1 = new Perro();

            Perro1.Nombre = "Chato";
            Perro1.Edad = 4;

            Console.WriteLine("Por favor indica que comió el Perro: 0 --> Agua; 1 --> Croquetas; 2 --> Basura");

            comida = Console.ReadLine();

            perroConHambre = Perro1.comer(Convert.ToInt16(comida));

            if (Perro1.cagar(perroConHambre))
            {
                Console.WriteLine("El perro " + Perro1.Nombre + "va a cagar" );
                Console.Read();
            }
            else
            {
                Console.WriteLine("El perro N0 va a cagar");
                Console.Read();
            }
            Console.Read();

            Perro perro2 = new Perro("Goma", 8);

            Console.WriteLine("Por favor indica que comió el Perro: 0 --> Agua; 1 --> Croquetas; 2 --> Basura");

            comida = Console.ReadLine();

            perroConHambre = perro2.comer(Convert.ToInt16(comida));

            if (perro2.cagar(perroConHambre))
            {
                Console.WriteLine("El perro " + perro2.Nombre + " va a cagar");
                Console.Read();
            }
            else
            {
                Console.WriteLine("El perro " + perro2.Nombre + " No va a cagar");
                Console.Read();
            }
            Console.Read();
        }
    }
}
```
 
6. Bibliografía  
 
* CEBALLOS SIERRA, Francisco Javier. Microsoft C#. Curso de programación. México, Alfaomega, 2007   
* DEITEL, Harvey y Deitel, PAUL. C# Cómo programar. España, Pearson, 2007   
* LÓPEZ ROMÁN, Leobardo. Metodología de la programación orientada a objetos. México, Alfaomega, 2007
