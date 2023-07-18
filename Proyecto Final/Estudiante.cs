using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Final
{
    [Serializable]
    public class Estudiante
    {
        public string nombre { get; set; }
        public string correo { get; set; }
        public string contra { get; set; }
        public int codigo { get; set; }
        public int PC1 { get; set; }
        public int PC2 { get; set; }
        public int PC3 { get; set; }
        public int PC4 { get; set; }
        public int TLR1 { get; set; }

        public List<Participacion> participaciones = new List<Participacion>();
        public int notaParticipacion { get; set; }

        public Estudiante()
        {
        }

        public Estudiante(string n, int cod, string co)
        {
            nombre = n;
            codigo = cod;
            correo = co;
            contra = "";
            PC1 = 0;
            PC2 = 0;
            PC3 = 0;
            PC4 = 0;
            TLR1 = 0;
            notaParticipacion = 0;
        }

        public Estudiante(string n, int cod, string co, string con)
        {
            nombre = n;
            codigo = cod;
            correo = co;
            contra = con;
            PC1 = 0;
            PC2 = 0;
            PC3 = 0;
            PC4 = 0;
            TLR1 = 0;
            notaParticipacion = 0;
        }

        public Estudiante(string n, int cod, string co, int pc1, int pc2, int pc3, int pc4, int tlr1, int par)
        {
            nombre = n;
            codigo = cod;
            correo = co;
            contra = "";
            PC1 = pc1;
            PC2 = pc2;
            PC3 = pc3;
            PC4 = pc4;
            TLR1 = tlr1;
            notaParticipacion = par;
        }

        public void addParticipacion(string sesion, Estudiante e, DateTime hf, string des)
        {
            participaciones.Add(new Participacion(sesion, hf, des));
        }

        public void removeParticipacion(string sesion)
        {
            int indice = 0;
            foreach(Participacion participacion in participaciones)
            {
                if(participacion.sesion == sesion)
                {
                    indice = participaciones.IndexOf(participacion);
                }
            }
            participaciones.RemoveAt(indice);
        }

        public bool findParticipacion(string sesion)
        {
            bool seEncontro = false;
            foreach (Participacion participacion in participaciones)
            {
                if (participacion.sesion == sesion)
                {
                    seEncontro = true;
                }
            }
            return seEncontro;
        }

        public string mostrarParticipaciones()
        {
            string mensaje = "";
            foreach(Participacion participacion in participaciones)
            {
                mensaje += "PARTICIPACIÓN " + (participaciones.IndexOf(participacion) + 1) + "\r\n" +
                    participacion.mostrar() + "\r\n";
            }
            return mensaje;
        }

        public bool tieneContrasena()
        {
            if (contra.Length == 0)
                return false;
            else
                return true;
        }
    }
}
