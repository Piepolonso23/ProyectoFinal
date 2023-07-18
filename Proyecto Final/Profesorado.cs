using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Final
{
    public class Profesorado
    {
        public List<Profesor> profesores = new List<Profesor>();
        public Profesorado() { }

        public bool findProfesor(int codigo)
        {
            bool existe = false;
            foreach (Profesor p in profesores)
            {
                if(p.codigo == codigo)
                    existe = true;
            }
            return existe;
        }

        public bool findProfesor(int codigo, string contrasena)
        {
            bool existe = false;
            foreach (Profesor p in profesores)
            {
                if (p.codigo == codigo && p.contra == contrasena)
                    existe = true;
            }
            return existe;
        }

        public Profesor findUserProfesor(int codigo)
        {
            Profesor profesor = new Profesor();
            foreach (Profesor p in profesores)
            {
                if (p.codigo == codigo)
                    profesor = p;
            }
            return profesor;
        }

        public Profesor findUserProfesor(int codigo, string contrasena)
        {
            Profesor profesor = new Profesor();
            foreach (Profesor p in profesores)
            {
                if (p.codigo == codigo && p.contra == contrasena)
                    profesor = p;
            }
            return profesor;
        }

        public Profesor findUserProfesor(Profesorado profesorado, Estudiante estudiante)
        {
            Profesor profesor = new Profesor();
            foreach (Profesor p in profesorado.profesores)
            {
                foreach (Curso c in p.cursos)
                {
                    foreach (Estudiante e in c.alumnado.alumnos)
                    {
                        if (e.codigo == estudiante.codigo)
                            profesor = p;
                    }
                }
            }
            return profesor;
        }

        public bool findAlumno(Profesorado profesorado, int codigo)
        {
            bool existe = false;
            foreach (Profesor p in profesorado.profesores)
            {
                foreach (Curso c in p.cursos)
                {
                    foreach (Estudiante e in c.alumnado.alumnos)
                    {
                        if (e.codigo == codigo)
                            existe = true;
                    }
                }
            }
            return existe;
        }

        public Estudiante findAlumnoClase(Profesorado profesorado, int codigo)
        {
            Estudiante estudiante = new Estudiante();
            foreach (Profesor p in profesorado.profesores)
            {
                foreach (Curso c in p.cursos)
                {
                    foreach (Estudiante e in c.alumnado.alumnos)
                    {
                        if (e.codigo == codigo)
                            estudiante = e;
                    }
                }
            }
            return estudiante;
        }

        public int findProfesorIDByAlumno(Profesorado profesorado, Estudiante estudiante)
        {
            int id = 0;
            foreach (Profesor p in profesorado.profesores)
            {
                foreach (Curso c in p.cursos)
                {
                    foreach (Estudiante e in c.alumnado.alumnos)
                    {
                        if (e.codigo == estudiante.codigo)
                            id = profesorado.profesores.IndexOf(p);
                    }
                }
            }
            return id;
        }

        public int findAlumnoID(Profesorado profesorado, Estudiante estudiante)
        {
            int id = 0;
            foreach (Profesor p in profesorado.profesores)
            {
                foreach (Curso c in p.cursos)
                {
                    foreach (Estudiante e in c.alumnado.alumnos)
                    {
                        if (e.codigo == estudiante.codigo)
                            id = c.alumnado.alumnos.IndexOf(e);
                    }
                }
            }
            return id;
        }

        public int findCursoIDByAlumno(Profesorado profesorado, Estudiante estudiante)
        {
            int id = 0;
            foreach (Profesor p in profesorado.profesores)
            {
                foreach (Curso c in p.cursos)
                {
                    foreach (Estudiante e in c.alumnado.alumnos)
                    {
                        if (e.codigo == estudiante.codigo)
                            id = p.cursos.IndexOf(c);
                    }
                }
            }
            return id;
        }
    }
}
