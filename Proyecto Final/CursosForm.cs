using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Windows.Forms;
using System.Globalization;

namespace Proyecto_Final
{
    public partial class CursosForm : Form
    {
        Profesorado profesorado;
        Profesor profesor;
        public CursosForm(Profesorado profes, Profesor p)
        {
            profesorado = profes;
            profesor = p;
            InitializeComponent();
        }

        private void lbCursos_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Form ses = new SesionesForm(profesorado, profesor, profesor.cursos[lbCursos.SelectedIndex]);
                this.Visible = false;
                ses.Visible = true;
            }
            catch (Exception)
            {
                MessageBox.Show(null, "Seleccione bien el curso", "Información");
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Excepciones ex = new Excepciones();
            ex.codigo(txtCodigo);
            ex.nombreCompleto(txtNombreAlumno);
            ex.correo(txtCorreo);
            ex.showMensaje();
            if (ex.codigo(txtCodigo) != "" && ex.nombreCompleto(txtNombreAlumno) != "" && ex.correo(txtCorreo) != "")
            {
                if (profesorado.findAlumno(profesorado, Convert.ToInt32(ex.codigo(txtCodigo))))
                {
                    MessageBox.Show(null, "Este alumno ya tiene un curso inscrito", "Información", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtCodigo.Clear();
                    txtNombreAlumno.Clear();
                    txtCorreo.Clear();
                    txtCodigo.Focus();
                }
                else
                {
                    profesor.cursos.Last().alumnado.alumnos.Add(new Estudiante(ex.nombreCompleto(txtNombreAlumno), Convert.ToInt32(txtCodigo.Text), txtCorreo.Text));
                    txtCodigo.Clear();
                    txtNombreAlumno.Clear();
                    txtCorreo.Clear();
                    txtCodigo.Focus();
                }
            }
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            if (txtNombre.TextLength > 1)
            {
                profesor.addCurso(txtNombre.Text, profesor);
                pnlCrearAlumnos.Enabled = true;
                btnCrear.Enabled = false;
                btnArchivo.Enabled = true;
                txtCodigo.Focus();
            }
            else
            {
                MessageBox.Show(null, "Ingrese de manera correcta el nombre del curso", "Información");
            }
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            XmlSerializer xml = new XmlSerializer(typeof(Profesorado));
            Stream stream = new FileStream("Profesorado.xml", FileMode.Create, FileAccess.Write);
            xml.Serialize(stream, profesorado);
            stream.Close();
            lbCursos.Items.Add(profesor.cursos.Last().nombreCurso);
            txtNombre.Clear();
            btnCrear.Enabled = true;
            pnlCrearAlumnos.Enabled = false;
            btnArchivo.Enabled = false;
        }

        private void CursosForm_Load(object sender, EventArgs e)
        {
            foreach (Curso c in profesor.cursos)
            {
                lbCursos.Items.Add(c.nombreCurso);
            }
            lblBienvenida.Text = "Bienvenido, " + profesor.nombre.Split(' ')[0];
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Desea salir de su cuenta?", "Información", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            if (resultado == DialogResult.OK)
            {
                TipoDeAcademicoForm tipo = new TipoDeAcademicoForm();
                tipo.Visible = true;
                this.Visible = false;
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Form editar = new EditarForm(profesorado, profesor);
            editar.Visible = true;
            this.Visible = false;
        }

        private void btnArchivo_Click(object sender, EventArgs e)
        {
            if(txtNombre.Text != "")
            {
                string rutaArchivo = "";
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    rutaArchivo = openFileDialog1.FileName;
                    profesor.cursos.Last().agregarAlumnadoFile(rutaArchivo);
                }
                XmlSerializer xml = new XmlSerializer(typeof(Profesorado));
                Stream stream = new FileStream("Profesorado.xml", FileMode.Create, FileAccess.Write);
                xml.Serialize(stream, profesorado);
                stream.Close();
                lbCursos.Items.Add(profesor.cursos.Last().nombreCurso);
                txtNombre.Clear();
                btnCrear.Enabled = true;
                pnlCrearAlumnos.Enabled = false;
                btnArchivo.Enabled = false;
            }
            else
            {
                MessageBox.Show("No ha colocado el nombre del curso a crear");
            }
        }

        private void btnEliminarCuenta_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Desea eliminar su cuenta?", "Información", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            if (resultado == DialogResult.OK)
            {
                profesorado.profesores.Remove(profesor);
                XmlSerializer xml = new XmlSerializer(typeof(Profesorado));
                Stream stream = new FileStream("Profesorado.xml", FileMode.Create, FileAccess.Write);
                xml.Serialize(stream, profesorado);
                stream.Close();
                TipoDeAcademicoForm tipo = new TipoDeAcademicoForm();
                tipo.Visible = true;
                this.Visible = false;
            }
        }

        private void btnEstadisticas_Click(object sender, EventArgs e)
        {
            EstadisticaForm tipo = new EstadisticaForm(profesorado, profesor);
            tipo.Visible = true;
            this.Visible = false;
        }
    }
}
