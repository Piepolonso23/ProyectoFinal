using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Final
{
    public class Sesion : Curso
    {
        public string nombreSesion;
        public List<Asistencia> asistencias = new List<Asistencia>();
        public Sesion()
        {

        }
        public Sesion(string nc, string p, Alumnado a, string ns) : base(nc, p,a)
        {
            nombreSesion = ns;
        }

        public void rellenarAsistencia()
        {
            for (int i = 0; i < alumnado.alumnos.Count; i++)
            {
                asistencias.Add(new Asistencia(alumnado.alumnos[i].codigo, false));
            }
        }

        public Asistencia getAsistencia(int cod)
        {
            Asistencia asis = new Asistencia();
            foreach (Asistencia a in asistencias)
            {
                if (a.codigo == cod)
                    asis = a;
            }
            return asis;
        }
    }
}
