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
    public partial class TipoDeAcademicoForm : Form
    {
        Profesorado profesorado;
        public TipoDeAcademicoForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            XmlSerializer xml = new XmlSerializer(typeof(Profesorado));
            Stream stream = new FileStream("Profesorado.xml", FileMode.Open, FileAccess.Read);
            profesorado = (Profesorado)xml.Deserialize(stream);
            stream.Close();
        }

        private void btnProfesor_Click(object sender, EventArgs e)
        {
            Form profe = new ProfesorForm(profesorado);
            this.Visible = false;
            profe.Visible = true;
        }

        private void btnAlumno_Click(object sender, EventArgs e)
        {
            Form alumno = new AlumnoForm(profesorado);
            this.Visible = false;
            alumno.Visible = true;
        }
    }
}
