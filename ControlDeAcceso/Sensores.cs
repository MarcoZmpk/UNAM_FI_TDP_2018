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
