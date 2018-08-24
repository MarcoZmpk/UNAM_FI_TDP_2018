## Universidad Nacional Autónoma de México
### Facultad de Ingeniería
#### Técnicas de Programación - Ingeniería Mecatrónica

##### *Polimorfismo*

*No de práctica: 3*

1. *Objetivos de aprendizaje* 
 
I. Objetivos generales:  Entender qué es y para qué sirve el polimorfismo. 
 
 
II. Objetivos específicos:
 
* Aprender qué es el polimorfismo. 
* Identificar cuándo puede utilizarse el polimorfismo. 
* Aprender a redefinir los métodos de una clase base en sus clases derivadas.
 
2. *Introducción*

El polimorfismo suele considerarse el tercer pilar de la programación orientada a objetos, además del encapsulamiento y la herencia.Polimorfismo es una palabra que proviene del griego, significa "con muchas formas" y tiene dos aspectos diferentes.

3. *Desarrollo*
 
I. Actividad 1

*Definir una clase base*
 
Programe una clase que incluya al menos un método que sea susceptible de tener un comportamiento distinto al ser heredado a una clase derivada.  Declare este tipo de métodos como métodos virtuales. 
Elabore las pruebas de escritorio necesarias para verificar el funcionamiento correcto de toda la funcionalidad de la clase base.


II. Actividad 2

*Implementación del polimorfismo*
 
A partir de la clase base previamente definida, mediante la herencia, genere al menos una clase derivada que redefina apropiadamente el comportamiento todos sus métodos virtuales. 
Elabore las pruebas de escritorio necesarias para verificar el funcionamiento correcto de toda la funcionalidad de la clase derivada.
 
´´´
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlDeAcceso
{
    public partial class Form1 : Form
    {
        SensorDactilar sd = new SensorDactilar();
        SensorIris si = new SensorIris();
        SensorVoz sv = new SensorVoz();
        Boolean iris = false;
        Boolean voz = false;
        Boolean dactilar = false;

        public Form1()
        {
            InitializeComponent();
        }

        /*
         * Método para leer el usuario 
         */
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        /*
        * Método para leer el tipo de sensor
        */
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ("Iris" == this.comboBox2.SelectedItem.ToString())
            {
                si.SetUsuario(this.comboBox1.SelectedItem.ToString());
                si.SetSensor(this.comboBox2.SelectedItem.ToString());
                iris = true;
                
            }
            else if ("Voz" == this.comboBox2.SelectedItem.ToString())
            {
                sv.SetUsuario(this.comboBox1.SelectedItem.ToString());
                sv.SetSensor(this.comboBox2.SelectedItem.ToString());
                voz = true;
                sv.GetID();
            }
            else
            {
                sd.SetUsuario(this.comboBox1.SelectedItem.ToString());
                sd.SetSensor(this.comboBox2.SelectedItem.ToString());
                dactilar = true;
                sd.GetID();
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            string id = null;
            bool result = false;
            string alarma = null;
            if (iris)
            {
                id = si.GetID();
                result = si.ValidarUsuario();
                alarma = si.ActivarAlarma();
            }
            else if (voz)
            {
                id = sv.GetID();
                result = sv.ValidarUsuario();
                alarma = sv.ActivarAlarma();
            }
            else
            {
                id = sd.GetID();
                result = sd.ValidarUsuario();
                alarma = sd.ActivarAlarma();
            }

            this.textBox1.Text = id;
            this.richTextBox1.Text = "Acceso: " + result.ToString() + Environment.NewLine;
            this.richTextBox1.Text += "Usuario: " + id + Environment.NewLine;
            this.richTextBox1.Text += alarma;

            iris = false;
            voz = false;
            dactilar = false;
        }
    }
}
´´´
--- 

´´´
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlDeAcceso
{
    abstract class Sensores
    {
        protected string usuario;
        protected string tipoSensor;
        protected bool accesoPermitido;

        public void SetUsuario(string user)
        {
            usuario = user;
        }

        public void SetSensor(string sensor)
        {
            tipoSensor = sensor;
        }

        public abstract string GetID();


        public virtual string ActivarAlarma()
        {
            return "Alarma Activada = True";
        }

        public bool ValidarUsuario()
        {
            if (usuario == "Directivo")
            {
                accesoPermitido = true;
            }
            else if ((usuario == "Académico") && (tipoSensor != "Iris"))
            {
                accesoPermitido = true;
            }
            else if ((usuario == "Estudiante") && (tipoSensor == "Dactilar"))
            {
                accesoPermitido = true;
            }
            else
            {
                accesoPermitido = false;
            }
            return accesoPermitido;
        }
    }
}
´´´
---

´´´
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlDeAcceso
{
    class SensorDactilar:Sensores
    {

 
        public override string GetID()
        {
            return "Soy una cadena de caracteres sensor Dactilar";
        }

        public override string ActivarAlarma()
        {
            return "Alarma Activada Dactilar = false";
        }
    }
}
´´´
---

´´´
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlDeAcceso
{
    class SensorVoz:Sensores
    {


        public override string GetID()
        {
            return "Soy un sonido del sensor voz";
        }

        public override string ActivarAlarma()
        {
            return "Alarma Activada Voz = false";
        }
    }
}

´´´
---
´´´
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlDeAcceso
{
    class SensorIris:Sensores
    {

        public override string GetID()
        {
            return "Cadena de números del iris";
        }

        public override string ActivarAlarma()
        {
            return "Alarma Activada Iris = false";
        }
    }
}

´´´
---
 
 
6. Bibliografía  
 
* CEBALLOS SIERRA, Francisco Javier. Microsoft C#. Curso de programación. México, Alfaomega, 2007   
* DEITEL, Harvey y Deitel, PAUL. C# Cómo programar. España, Pearson, 2007   
* LÓPEZ ROMÁN, Leobardo. Metodología de la programación orientada a objetos. México, Alfaomega, 2007
