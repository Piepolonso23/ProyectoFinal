using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Final
{
    public partial class SorteoForm : Form
    {
        Profesor profesor;
        Curso curso;
        public SorteoForm(Profesor p, Curso c)
        {
            profesor = p;
            curso = c;
            InitializeComponent();
        }

        private void SorteoForm_Load(object sender, EventArgs e)
        {
            Random r = new Random();
            int seleccionado = r.Next(0, curso.alumnado.alumnos.Count);
            txtCodigo.Text = curso.alumnado.alumnos[seleccionado].codigo.ToString();
            txtNombre.Text = curso.alumnado.alumnos[seleccionado].nombre;
            txtCorreo.Text = curso.alumnado.alumnos[seleccionado].correo;
        }

        private void btnOtro_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            int seleccionado = r.Next(0, curso.alumnado.alumnos.Count);
            txtCodigo.Text = curso.alumnado.alumnos[seleccionado].codigo.ToString();
            txtNombre.Text = curso.alumnado.alumnos[seleccionado].nombre;
            txtCorreo.Text = curso.alumnado.alumnos[seleccionado].correo;
        }
    }
}
