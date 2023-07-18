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
    public partial class ProfesorCrearForm : Form
    {
        Profesorado profesorado;
        public ProfesorCrearForm(Profesorado profes)
        {
            profesorado = profes;
            InitializeComponent();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            Excepciones ex = new Excepciones();
            ex.codigo(txtCodigo);
            ex.nombreCompleto(txtNombre);
            ex.correo(txtCorreo);
            ex.contra(txtContrasena);
            ex.showMensaje();
            if (ex.codigo(txtCodigo) != "" && ex.nombreCompleto(txtNombre) != "" && ex.correo(txtCorreo) != "" && ex.contra(txtContrasena) != "")
            {
                if (profesorado.findProfesor(Convert.ToInt32(ex.codigo(txtCodigo))))
                {
                    MessageBox.Show(null, "Este código de profesor ya existe", "Información", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtCodigo.Clear();
                    txtNombre.Clear();
                    txtCorreo.Clear();
                    txtContrasena.Clear();
                    txtCodigo.Focus();
                }
                else
                {
                    profesorado.profesores.Add(new Profesor(ex.nombreCompleto(txtNombre), Convert.ToInt32(ex.codigo(txtCodigo)), ex.correo(txtCorreo), ex.contra(txtContrasena)));
                    XmlSerializer xml = new XmlSerializer(typeof(Profesorado));
                    Stream stream = new FileStream("Profesorado.xml", FileMode.Create, FileAccess.Write);
                    xml.Serialize(stream, profesorado);
                    stream.Close();
                    Form cursos = new CursosForm(profesorado, profesorado.profesores.Last());
                    cursos.Visible = true;
                    this.Visible = false;
                }
            }
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            ProfesorForm profesor = new ProfesorForm(profesorado);
            profesor.Visible = true ;
            this.Visible = false;
        }
    }
}
