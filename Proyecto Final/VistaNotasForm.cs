using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Proyecto_Final
{
    public partial class VistaNotasForm : Form
    {
        Profesorado profesorado;
        Estudiante estudiante;
        public VistaNotasForm(Profesorado profes, Estudiante e)
        {
            profesorado = profes;
            estudiante = e;
            InitializeComponent();
        }

        private void VistaNotasForm_Load(object sender, EventArgs e)
        {
            int indiceProfesor = profesorado.findProfesorIDByAlumno(profesorado, estudiante);
            int indiceEstudiante = profesorado.findAlumnoID(profesorado, estudiante);
            int indiceCurso = profesorado.findCursoIDByAlumno(profesorado, estudiante);
            int PRT1 = profesorado.profesores[indiceProfesor].cursos[indiceCurso].alumnado.alumnos[indiceEstudiante].PC1;
            int PRT2 = profesorado.profesores[indiceProfesor].cursos[indiceCurso].alumnado.alumnos[indiceEstudiante].PC2;
            int PRT3 = profesorado.profesores[indiceProfesor].cursos[indiceCurso].alumnado.alumnos[indiceEstudiante].PC3;
            int PRT4 = profesorado.profesores[indiceProfesor].cursos[indiceCurso].alumnado.alumnos[indiceEstudiante].PC4;
            int TLR1 = profesorado.profesores[indiceProfesor].cursos[indiceCurso].alumnado.alumnos[indiceEstudiante].TLR1;
            int notaParticipacion = profesorado.profesores[indiceProfesor].cursos[indiceCurso].alumnado.alumnos[indiceEstudiante].notaParticipacion;
            int asistidas = 0;
            int faltadas = 0;
            dgwNotas.Rows.Add("Práctica Teórica	", "PRT1", PRT1);
            dgwNotas.Rows.Add("Práctica Teórica	", "PRT2", PRT2);
            dgwNotas.Rows.Add("Práctica Teórica	", "PRT3", PRT3);
            dgwNotas.Rows.Add("Práctica Teórica	", "PRT4", PRT4);
            dgwNotas.Rows.Add("Taller", "TLR1", TLR1);
            dgwNotas.Rows.Add("Participación", "PART", notaParticipacion);
            foreach (Sesion s in profesorado.profesores[indiceProfesor].cursos[indiceCurso].sesiones)
            {
                if (s.getAsistencia(profesorado.profesores[indiceProfesor].cursos[indiceCurso].alumnado.alumnos[indiceEstudiante].codigo).asistio == true)
                    asistidas++;
                else
                    faltadas++;
            }
            lblAsistidos.Text = "Sesiones asistidas: " + asistidas;
            lblFaltados.Text = "Sesiones faltadas: " + faltadas;
            lblTotales.Text = "Sesiones totales: " + profesorado.profesores[indiceProfesor].cursos[indiceCurso].sesiones.Count;
            txtParticipaciones.Text = profesorado.profesores[indiceProfesor].cursos[indiceCurso].alumnado.alumnos[indiceEstudiante].mostrarParticipaciones();
            string[] evaluaciones = { "PRT1", "PRT2", "PRT3", "PRT4", "TLR1" , "PART"};
            int[] notas = { PRT1, PRT2, PRT3, PRT4, TLR1 , notaParticipacion};
            cGrafico.Titles.Add("Notas");
            for (int i = 0; i < evaluaciones.Length; i++)
            {
                Series serie = cGrafico.Series.Add(evaluaciones[i]);
                serie.Label = notas[i].ToString();
                serie.Points.Add(notas[i]);
            }
            lblCurso.Text = profesorado.profesores[indiceProfesor].cursos[indiceCurso].nombreCurso;
            lblAlumno.Text = profesorado.profesores[indiceProfesor].cursos[indiceCurso].alumnado.alumnos[indiceEstudiante].nombre;
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Form notas = new AlumnoForm(profesorado);
            notas.Visible = true;
            this.Visible = false;
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            int indiceProfesor = profesorado.findProfesorIDByAlumno(profesorado, estudiante);
            int indiceEstudiante = profesorado.findAlumnoID(profesorado, estudiante);
            int indiceCurso = profesorado.findCursoIDByAlumno(profesorado, estudiante);
            Form promedio = new PromedioFinalForm(profesorado, profesorado.profesores[indiceProfesor].cursos[indiceCurso].alumnado.alumnos[indiceEstudiante]);
            this.Hide();
            promedio.ShowDialog();
        }
    }
}
