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
