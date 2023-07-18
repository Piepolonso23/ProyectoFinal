using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Proyecto_Final
{
    public partial class ContrasenaForm : Form
    {
        Profesorado profesorado;
        int codigo;
        Estudiante estudiante;

        public ContrasenaForm(Profesorado profes, int cod)
        {
            codigo = cod;
            profesorado = profes;
            InitializeComponent();
        }
        public ContrasenaForm(Profesorado profes, Estudiante e)
        {
            profesorado = profes;
            estudiante = e;
            InitializeComponent();
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            if(estudiante != null)
            {
                int indiceProfesor;
                int indiceCurso;
                int indiceEstudiante;
                if (txtConfirmarContrasena.Text == txtContrasena.Text)
                {
                    indiceProfesor = profesorado.findProfesorIDByAlumno(profesorado, estudiante);
                    indiceEstudiante = profesorado.findAlumnoID(profesorado, estudiante);
                    indiceCurso = profesorado.findCursoIDByAlumno(profesorado, estudiante);
                    profesorado.profesores[indiceProfesor].cursos[indiceCurso].alumnado.alumnos[indiceEstudiante].contra = txtConfirmarContrasena.Text;
                    XmlSerializer xml = new XmlSerializer(typeof(Profesorado));
                    Stream stream = new FileStream("Profesorado.xml", FileMode.Create, FileAccess.Write);
                    xml.Serialize(stream, profesorado);
                    stream.Close();
                    Form alumno = new AlumnoForm(profesorado);
                    alumno.Visible = true;
                    this.Visible = false;

                }
                else
                {
                    MessageBox.Show("Confirme de manera correcta su contraseña");
                }
            }
            else
            {
                int indiceProfesor;
                if (txtConfirmarContrasena.Text == txtContrasena.Text)
                {
                    indiceProfesor = profesorado.profesores.IndexOf(profesorado.findUserProfesor(codigo));
                    profesorado.profesores[indiceProfesor].contra = txtConfirmarContrasena.Text;
                    XmlSerializer xml = new XmlSerializer(typeof(Profesorado));
                    Stream stream = new FileStream("Profesorado.xml", FileMode.Create, FileAccess.Write);
                    xml.Serialize(stream, profesorado);
                    stream.Close();
                    Form profesor = new ProfesorForm(profesorado);
                    profesor.Visible = true;
                    this.Visible = false;
                }
                else
                {
                    MessageBox.Show("Confirme de manera correcta su contraseña");
                }
            }
            
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            if(estudiante != null)
            {
                Form alumno = new AlumnoForm(profesorado);
                alumno.Visible = true;
                this.Visible = false;
            }
            else
            {
                Form profesor = new ProfesorForm(profesorado);
                profesor.Visible = true;
                this.Visible = false;
            }
        }
    }
}
