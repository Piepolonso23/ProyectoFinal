using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Proyecto_Final
{
    public partial class SesionesForm : Form
    {
        Profesorado profesorado;
        Profesor profesor;
        Curso curso;

        public SesionesForm(Profesorado profes, Profesor p, Curso c)
        {
            InitializeComponent();
            profesorado = profes;
            profesor = p;
            curso = c;
        }

        private void SesionesForm_Load(object sender, EventArgs e)
        {
            foreach (Sesion s in profesor.cursos[profesor.cursos.IndexOf(curso)].sesiones)
            {
                cbSesiones.Items.Add(s.nombreSesion);
            }
            if (cbSesiones.Items.Count > 0)
                cbSesiones.SelectedIndex = 0;
        }

        private void dgwParticipaciones_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string descripcion;
            if (e.RowIndex >= 0 && e.ColumnIndex == 2)
            {
                DataGridViewRow row = dgwParticipaciones.Rows[e.RowIndex];
                row.Cells["cParticipacion"].Value = Convert.ToBoolean(row.Cells["cParticipacion"].EditedFormattedValue);
                if (Convert.ToBoolean(row.Cells["cParticipacion"].Value))
                {
                    descripcion = Interaction.InputBox("Descripción de la participación:");
                    foreach (Estudiante es in curso.alumnado.alumnos)
                    {
                        if (Convert.ToInt32(row.Cells["cCodigo"].Value) == es.codigo)
                            es.addParticipacion(cbSesiones.SelectedItem.ToString(), es, DateTime.Now, descripcion);
                    }
                    XmlSerializer xml = new XmlSerializer(typeof(Profesorado));
                    Stream stream = new FileStream("Profesorado.xml", FileMode.Create, FileAccess.Write);
                    xml.Serialize(stream, profesorado);
                    stream.Close();
                }
                else
                {
                    foreach (Estudiante es in curso.alumnado.alumnos)
                    {
                        if (Convert.ToInt32(row.Cells["cCodigo"].Value) == es.codigo)
                            es.removeParticipacion(cbSesiones.SelectedItem.ToString());
                    }
                    XmlSerializer xml = new XmlSerializer(typeof(Profesorado));
                    Stream stream = new FileStream("Profesorado.xml", FileMode.Create, FileAccess.Write);
                    xml.Serialize(stream, profesorado);
                    stream.Close();
                }
            }
        }

        private void cbSesiones_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgwParticipaciones.Rows.Clear();
            for (int i = 0; i < curso.sesiones.Count; i++)
            {
                if (cbSesiones.SelectedIndex == i)
                {
                    foreach (Estudiante es in curso.alumnado.alumnos)
                    {
                        if (es.findParticipacion(cbSesiones.SelectedItem.ToString()))
                            dgwParticipaciones.Rows.Add(es.codigo, es.nombre, true);
                        else
                            dgwParticipaciones.Rows.Add(es.codigo, es.nombre, false);
                    }
                }
            }
        }

        private void btnRegistroNotas_Click(object sender, EventArgs e)
        {
            Form rg = new RegistroNotasForm(profesorado, profesor, curso);
            rg.Visible = true;
            this.Visible = false;
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Form cursos = new CursosForm(profesorado, profesor);
            cursos.Visible = true;
            this.Visible = false;
        }

        private void btnSorteo_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            int seleccionado = r.Next(0, curso.alumnado.alumnos.Count);
            string mensaje = "";
            mensaje += "Código: " + curso.alumnado.alumnos[seleccionado].codigo + "\n";
            mensaje += "Nombre: " + curso.alumnado.alumnos[seleccionado].nombre + "\n";
            mensaje += "Correo: " + curso.alumnado.alumnos[seleccionado].correo + "\n";
            MessageBox.Show(mensaje, "Alumno escogido");
            dgwParticipaciones.FirstDisplayedScrollingRowIndex = seleccionado;
            dgwParticipaciones.Refresh();
            dgwParticipaciones.CurrentCell = dgwParticipaciones.Rows[seleccionado].Cells[1];
            dgwParticipaciones.Rows[seleccionado].Selected = true;
        }

        private void btnSorteoNoParticipan_Click(object sender, EventArgs e)
        {
            List<Estudiante> estudiantes = new List<Estudiante>();
            foreach (Estudiante es in curso.alumnado.alumnos)
            {
                if (es.participaciones.Count < curso.sesiones.Count / 2)
                    estudiantes.Add(es);
            }
            Random r = new Random();
            int seleccionado = r.Next(0, estudiantes.Count);
            string mensaje = "";
            mensaje += "Código: " + curso.alumnado.alumnos[seleccionado].codigo + "\n";
            mensaje += "Nombre: " + curso.alumnado.alumnos[seleccionado].nombre + "\n";
            mensaje += "Correo: " + curso.alumnado.alumnos[seleccionado].correo + "\n";
            MessageBox.Show(mensaje, "Alumno escogido");
            dgwParticipaciones.FirstDisplayedScrollingRowIndex = seleccionado;
            dgwParticipaciones.Refresh();
            dgwParticipaciones.CurrentCell = dgwParticipaciones.Rows[seleccionado].Cells[1];
            dgwParticipaciones.Rows[seleccionado].Selected = true;
        }

        private void btnAgregarSesion_Click_1(object sender, EventArgs e)
        {
            string nombre = Interaction.InputBox("Ingrese el nombre de la nueva sesión: ");
            curso.addSesion(nombre);
            curso.sesiones.Last().rellenarAsistencia();
            cbSesiones.Items.Add(nombre);
            XmlSerializer xml = new XmlSerializer(typeof(Profesorado));
            Stream stream = new FileStream("Profesorado.xml", FileMode.Create, FileAccess.Write);
            xml.Serialize(stream, profesorado);
            stream.Close();
        }

        private void btnEditarSesiones_Click(object sender, EventArgs e)
        {
            Form editar = new EditarForm(profesorado, profesor, curso);
            editar.Visible = true;
            this.Visible = false;
        }

        private void btnAsistencia_Click(object sender, EventArgs e)
        {
            Form asistencia = new AsistenciaForm(profesorado, profesor, curso);
            asistencia.Visible = true;
            this.Visible = false;
        }
    }
}
