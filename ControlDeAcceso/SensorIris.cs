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
