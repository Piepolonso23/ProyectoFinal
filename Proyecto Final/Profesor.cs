using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Final
{
    public class Profesor
    {
        public string nombre { get; set; }
        public string correo { get; set; }
        public string contra { get; set; }
        public int codigo { get; set; }

        public List<Curso> cursos = new List<Curso>();

        public Profesor()
        {
        }

        public Profesor(string n, int cod, string co, string con)
        {
            nombre = n;
            codigo = cod;
            correo = co;
            contra = con;
        }

        public void addCurso(string nomCurso, Alumnado a, Profesor p)
        {
            cursos.Add(new Curso(nomCurso, p.nombre, a));
        }

        public void addCurso(string nomCurso,  Profesor p)
        {
            cursos.Add(new Curso(nomCurso, p.nombre));
        }

        public bool findAlumno(Profesor profesor, int codigo)
        {
            bool existe = false;
            foreach (Curso c in profesor.cursos)
            {
                foreach (Estudiante e in c.alumnado.alumnos)
                {
                    if (e.codigo == codigo)
                        existe = true;
                }
            }
            return existe;
        }

        public Estudiante findAlumnoClase(Profesor profesor, int codigo)
        {
            Estudiante estudiante = new Estudiante();
            foreach (Curso c in profesor.cursos)
            {
                foreach (Estudiante e in c.alumnado.alumnos)
                {
                    if (e.codigo == codigo)
                        estudiante = e;
                }
            }
            return estudiante;
        }

        public int findAlumnoID(Profesor profesor, Estudiante estudiante)
        {
            int id = 0;
            foreach (Curso c in profesor.cursos)
            {
                foreach (Estudiante e in c.alumnado.alumnos)
                {
                    if (e.codigo == estudiante.codigo)
                        id = c.alumnado.alumnos.IndexOf(e);
                }
            }
            return id;
        }

        public int findCursoIDByAlumno(Profesor profesor, Estudiante estudiante)
        {
            int id = 0;
            foreach (Curso c in profesor.cursos)
            {
                foreach (Estudiante e in c.alumnado.alumnos)
                {
                    if (e.codigo == estudiante.codigo)
                        id = profesor.cursos.IndexOf(c);
                }
            }
            return id;
        }

        public string[] nombreCursos()
        {
            string[] nCursos = new string[cursos.Count];
            for (int i = 0; i < nCursos.Length; i++)
            {
                nCursos[i] = cursos[i].nombreCurso;
            }
            return nCursos;
        }

        public double[] promediosPRT1()
        {
            double[] prt1Cursos = new double[cursos.Count];
            for (int i = 0; i < prt1Cursos.Length; i++)
            {
                prt1Cursos[i] = cursos[i].promedioPRT1();
            }
            return prt1Cursos;
        }

        public double[] promediosPRT2()
        {
            double[] prt2Cursos = new double[cursos.Count];
            for (int i = 0; i < prt2Cursos.Length; i++)
            {
                prt2Cursos[i] = cursos[i].promedioPRT2();
            }
            return prt2Cursos;
        }

        public double[] promediosPRT3()
        {
            double[] prt3Cursos = new double[cursos.Count];
            for (int i = 0; i < prt3Cursos.Length; i++)
            {
                prt3Cursos[i] = cursos[i].promedioPRT3();
            }
            return prt3Cursos;
        }

        public double[] promediosPRT4()
        {
            double[] prt4Cursos = new double[cursos.Count];
            for (int i = 0; i < prt4Cursos.Length; i++)
            {
                prt4Cursos[i] = cursos[i].promedioPRT4();
            }
            return prt4Cursos;
        }

        public double[] promediosTLR1()
        {
            double[] tlr14Cursos = new double[cursos.Count];
            for (int i = 0; i < tlr14Cursos.Length; i++)
            {
                tlr14Cursos[i] = cursos[i].promedioTLR1();
            }
            return tlr14Cursos;
        }

        public double[] promediosPART()
        {
            double[] partCursos = new double[cursos.Count];
            for (int i = 0; i < partCursos.Length; i++)
            {
                partCursos[i] = cursos[i].promedioPART();
            }
            return partCursos;
        }
    }
}
