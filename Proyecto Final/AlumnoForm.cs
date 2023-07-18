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
    public partial class AlumnoForm : Form
    {
        Profesorado profesorado;
        public AlumnoForm(Profesorado profes)
        {
            profesorado = profes;
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            DialogResult resultado;
            if (profesorado.findAlumno(profesorado, Convert.ToInt32(txtCodigo.Text)))
            {
                if (profesorado.findAlumnoClase(profesorado, Convert.ToInt32(txtCodigo.Text)).tieneContrasena() == false)
                {
                    resultado = MessageBox.Show("Usted no cuenta con una contraseña, presione Aceptar para configurarla", "Configuración contraseña", MessageBoxButtons.OKCancel);
                    if(resultado == DialogResult.OK)
                    {
                        Form contrasena = new ContrasenaForm(profesorado, profesorado.findAlumnoClase(profesorado, Convert.ToInt32(txtCodigo.Text)));
                        contrasena.Visible = true;
                        this.Visible = false;
                    }
                }
                else
                {
                    if(profesorado.findAlumnoClase(profesorado, Convert.ToInt32(txtCodigo.Text)).contra == txtContrasena.Text)
                    {
                        Form notas = new VistaNotasForm(profesorado, profesorado.findAlumnoClase(profesorado, Convert.ToInt32(txtCodigo.Text)));
                        notas.Visible = true;
                        this.Visible = false;
                    }
                    else
                    {
                        MessageBox.Show("Su contraseña que ingresó no es la correcta", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtContrasena.Clear();
                        txtContrasena.Focus();
                    }
                }
            }
            else
            {
                MessageBox.Show("El código que ingresó no se encuentra registrado", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCodigo.Clear();
                txtContrasena.Clear();
                txtCodigo.Focus();
            }
        }

        private void btnRegresar_Click_1(object sender, EventArgs e)
        {
            TipoDeAcademicoForm tipo = new TipoDeAcademicoForm();
            tipo.Visible = true;
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
            if (txtCodigo.Text != "")
            {
                if (profesorado.findAlumno(profesorado, Convert.ToInt32(txtCodigo.Text)))
                {
                    Form contrasena = new ContrasenaForm(profesorado, profesorado.findAlumnoClase(profesorado, Convert.ToInt32(txtCodigo.Text)));
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
