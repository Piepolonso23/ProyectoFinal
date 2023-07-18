using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Final
{
    [Serializable]
    public class Curso
    {
        public string nombreCurso;
        public string nombreProfesor;
        public List<Sesion> sesiones = new List<Sesion>();
        public Alumnado alumnado;

        public Curso()
        {
        }

        public Curso(string nc, string p)
        {
            nombreCurso = nc;
            nombreProfesor = p;
            alumnado = new Alumnado();
        }

        public Curso(string nc, string p, string nf)
        {
            nombreCurso = nc;
            nombreProfesor = p;
            alumnado = new Alumnado();
        }

        public Curso(string nc, string p, Alumnado alum)
        {
            nombreCurso = nc;
            nombreProfesor = p;
            alumnado = alum;
        }

        public void addSesion(string ns)
        {
            sesiones.Add(new Sesion(nombreCurso, nombreProfesor, alumnado, ns));
        }

        public void agregarAlumnadoFile(string nameFile)
        {
            try
            {
                string[] lineas = File.ReadLines(@nameFile).ToArray();
                foreach (string s in lineas)
                {
                    string[] datos = s.Split('\u002C');
                    if (datos.Length == 3)
                    {
                        datos[0] = datos[0].Trim();
                        datos[0] = datos[0].ToUpper();
                        datos[1] = datos[1].Trim();
                        datos[2] = datos[2].Trim();
                        if (datos[1].Length == 9)
                            alumnado.alumnos.Add(new Estudiante(datos[0], Convert.ToInt32(datos[1]), datos[2]));
                        else
                            throw new Exception("Un código no presenta 9 caracteres o los datos se encuentran desordenado : Nombre, código, correo, trate de corregirlo");
                    }
                    else
                        throw new Exception("Se ingreso más de 3 datos en una linea");
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public double promedioPRT1()
        {
            int suma = 0;
            foreach (Estudiante e in alumnado.alumnos)
            {
                suma += e.PC1;
            }
            return suma / alumnado.alumnos.Count;
        }

        public double promedioPRT2()
        {
            int suma = 0;
            foreach (Estudiante e in alumnado.alumnos)
            {
                suma += e.PC2;
            }
            return suma / alumnado.alumnos.Count;
        }

        public double promedioPRT3()
        {
            int suma = 0;
            foreach (Estudiante e in alumnado.alumnos)
            {
                suma += e.PC3;
            }
            return suma / alumnado.alumnos.Count;
        }

        public double promedioPRT4()
        {
            int suma = 0;
            foreach (Estudiante e in alumnado.alumnos)
            {
                suma += e.PC4;
            }
            return suma / alumnado.alumnos.Count;
        }

        public double promedioTLR1()
        {
            int suma = 0;
            foreach (Estudiante e in alumnado.alumnos)
            {
                suma += e.TLR1;
            }
            return suma / alumnado.alumnos.Count;
        }

        public double promedioPART()
        {
            int suma = 0;
            foreach (Estudiante e in alumnado.alumnos)
            {
                suma += e.notaParticipacion;
            }
            return suma / alumnado.alumnos.Count;
        }
    }
}
