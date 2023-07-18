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
    public partial class ProfesorForm : Form
    {
        Profesorado profesorado;
        Profesor profesor;

        public ProfesorForm(Profesorado profes)
        {
            profesorado = profes;
            InitializeComponent();
        }
        public ProfesorForm(Profesorado profes, Profesor p)
        {
            profesorado = profes;
            profesor = p;   
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            Excepciones ex = new Excepciones();
            ex.codigo(txtCodigo);
            ex.contra(txtContrasena);
            ex.showMensaje();
            if (ex.codigo(txtCodigo) != "" && ex.contra(txtContrasena) != "")
            {
                if(profesorado.findProfesor(Convert.ToInt32(ex.codigo(txtCodigo)), ex.contra(txtContrasena)))
                {
                    Form cursos = new CursosForm(profesorado, profesorado.findUserProfesor(Convert.ToInt32(ex.codigo(txtCodigo)), ex.contra(txtContrasena)));
                    this.Visible = false;
                    cursos.Visible = true;
                }
                else
                {
                    MessageBox.Show("El código o la contraseña que ingresó no se encuentra registrado", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            TipoDeAcademicoForm tipo = new TipoDeAcademicoForm();
            tipo.Visible = true;
            this.Visible = false;
        }

        private void lblCrearCuenta_MouseHover(object sender, EventArgs e)
        {
            lblCrearCuenta.Font = new Font(lblCrearCuenta.Font, FontStyle.Bold  | FontStyle.Underline);
        }

        private void lblCrearCuenta_MouseLeave(object sender, EventArgs e)
        {
            lblCrearCuenta.Font = new Font(lblCrearCuenta.Font, FontStyle.Bold);
        }

        private void lblCrearCuenta_Click(object sender, EventArgs e)
        {
            Form crearProfesor = new ProfesorCrearForm(profesorado);
            crearProfesor.Visible = true;
            this.Visible = false;
        }

        private void lblOlvidarContrasena_MouseHover(object sender, EventArgs e)
        {
            lblOlvidarContrasena.Font = new Font(lblOlvidarContrasena.Font, FontStyle.Bold | FontStyle.Underline);
        }

        private void lblOlvidarContrasena_MouseLeave(object sender, EventArgs e)
        {
            lblOlvidarContrasena.Font = new Font(lblOlvidarContrasena.Font, FontStyle.Bold);
        }

        private void lblOlvidarContrasena_Click(object sender, EventArgs e)
        {
            if(txtCodigo.Text != "")
            {
                if (profesorado.findProfesor(Convert.ToInt32(txtCodigo.Text)))
                {
                    Form contrasena = new ContrasenaForm(profesorado, Convert.ToInt32(txtCodigo.Text));
                    contrasena.Visible = true;
                    this.Visible = false;
                }
                else
                {
                    MessageBox.Show("El código que ingresó no se encuentra registrado", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Ingrese su código para volver a configurar su contraseña", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
