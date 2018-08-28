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
