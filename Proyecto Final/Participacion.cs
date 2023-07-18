using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Final
{
    public class Participacion
    {
        public DateTime horaFecha;
        public string descripcion;
        public string sesion;

        public Participacion()
        {

        }
        public Participacion(string s, DateTime hf, string des)
        {
            sesion = s;
            horaFecha = hf;
            descripcion = des;
        }

        public string mostrar()
        {
            return "Sesión: " + sesion + "\r\n" +
                "Fecha y hora: " + horaFecha + "\r\n" +
                "Descripción: " + descripcion;
        }
    }
}
