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
    public partial class EditarForm : Form
    {
        Profesorado profesorado;
        Profesor profesor;
        Curso curso;
        public EditarForm(Profesorado profes, Profesor p)
        {
            profesorado = profes;
            profesor = p;
            InitializeComponent();
        }

        public EditarForm(Profesorado profes, Profesor p, Curso c)
        {
            profesorado = profes;
            profesor = p;
            curso = c;
            InitializeComponent();
        }

        private void EditarForm_Load(object sender, EventArgs e)
        {
            if(curso == null)
            {
                foreach (Curso c in profesor.cursos)
                {
                    lbElementos.Items.Add(c.nombreCurso);
                }
            }
            else
            {
                foreach (Sesion s in profesor.cursos[profesor.cursos.IndexOf(curso)].sesiones)
                {
                    lbElementos.Items.Add(s.nombreSesion);
                }
                lblTitulo.Text = "Editar Sesiones";
            }
            
        }

        private void lbCursos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (curso == null)
                txtNombre.Text = profesor.cursos[lbElementos.SelectedIndex].nombreCurso;
            else
                txtNombre.Text = profesor.cursos[profesor.cursos.IndexOf(curso)].sesiones[lbElementos.SelectedIndex].nombreSesion;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (curso == null)
            {
                profesor.cursos[lbElementos.SelectedIndex].nombreCurso = txtNombre.Text;
                lbElementos.Items.Clear();
                foreach (Curso c in profesor.cursos)
                {
                    lbElementos.Items.Add(c.nombreCurso);
                }
            }
            else
            {
                profesor.cursos[profesor.cursos.IndexOf(curso)].sesiones[lbElementos.SelectedIndex].nombreSesion = txtNombre.Text;
                lbElementos.Items.Clear();
                foreach (Sesion s in profesor.cursos[profesor.cursos.IndexOf(curso)].sesiones)
                {
                    lbElementos.Items.Add(s.nombreSesion);
                }
            }
            XmlSerializer xml = new XmlSerializer(typeof(Profesorado));
            Stream stream = new FileStream("Profesorado.xml", FileMode.Create, FileAccess.Write);
            xml.Serialize(stream, profesorado);
            stream.Close();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if(curso == null)
            {
                DialogResult resultado = MessageBox.Show("¿Está seguro que quiere eliminar este curso?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resultado == DialogResult.Yes)
                {
                    profesor.cursos.RemoveAt(lbElementos.SelectedIndex);
                    XmlSerializer xml = new XmlSerializer(typeof(Profesorado));
                    Stream stream = new FileStream("Profesorado.xml", FileMode.Create, FileAccess.Write);
                    xml.Serialize(stream, profesorado);
                    stream.Close();
                    lbElementos.Items.Clear();
                    txtNombre.Clear();
                    foreach (Curso c in profesor.cursos)
                    {
                        lbElementos.Items.Add(c.nombreCurso);
                    }
                }
            }
            else
            {
                DialogResult resultado = MessageBox.Show("¿Está seguro que quiere eliminar esta sesión?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (resultado == DialogResult.Yes)
                {
                    profesor.cursos[profesor.cursos.IndexOf(curso)].sesiones.RemoveAt(lbElementos.SelectedIndex);
                    XmlSerializer xml = new XmlSerializer(typeof(Profesorado));
                    Stream stream = new FileStream("Profesorado.xml", FileMode.Create, FileAccess.Write);
                    xml.Serialize(stream, profesorado);
                    stream.Close();
                    lbElementos.Items.Clear();
                    txtNombre.Clear();
                    foreach (Sesion s in profesor.cursos[profesor.cursos.IndexOf(curso)].sesiones)
                    {
                        lbElementos.Items.Add(s.nombreSesion);
                    }
                }
            }
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            if(curso == null)
            {
                Form cursos = new CursosForm(profesorado, profesor);
                cursos.Visible = true;
                this.Visible = false;
            }
            else
            {
                Form sesiones = new SesionesForm(profesorado, profesor, curso);
                sesiones.Visible = true;
                this.Visible = false;
            }
        }
    }
}
