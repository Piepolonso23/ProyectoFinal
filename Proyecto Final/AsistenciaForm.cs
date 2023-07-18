using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Synthesis;
using System.Threading;
using System.Xml.Serialization;
using System.IO;

namespace Proyecto_Final
{
    public partial class AsistenciaForm : Form
    {
        Profesorado profesorado;
        Profesor profesor;
        Curso curso;
        bool manualmente = false;
        int i = 0;
        SpeechSynthesizer synthesizer;
        public AsistenciaForm(Profesorado profes, Profesor p, Curso c)
        {
            profesorado = profes;
            profesor = p;
            curso = c;
            InitializeComponent();
        }

        private void AsistenciaForm_Load(object sender, EventArgs e)
        {
            foreach (Sesion s in profesor.cursos[profesor.cursos.IndexOf(curso)].sesiones)
            {
                cbSesiones.Items.Add(s.nombreSesion);
            }
            if (cbSesiones.Items.Count > 0)
                cbSesiones.SelectedIndex = 0;
        }

        private void cbSesiones_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgwAsistencia.Rows.Clear();
            for (int i = 0; i < curso.sesiones.Count; i++)
            {
                if (cbSesiones.SelectedIndex == i)
                {
                    foreach (Estudiante es in curso.alumnado.alumnos)
                    {
                        dgwAsistencia.Rows.Add(es.codigo, es.nombre, curso.sesiones[cbSesiones.SelectedIndex].getAsistencia(es.codigo).asistio);
                    }
                }
            }
        }

        private void dgwParticipaciones_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == 2)
            {
                DataGridViewRow row = dgwAsistencia.Rows[e.RowIndex];
                row.Cells["cAsistencia"].Value = Convert.ToBoolean(row.Cells["cAsistencia"].EditedFormattedValue);
                if (Convert.ToBoolean(row.Cells["cAsistencia"].Value))
                {
                    foreach (Estudiante es in curso.alumnado.alumnos)
                    {
                        if (Convert.ToInt32(row.Cells["cCodigo"].Value) == es.codigo)
                            curso.sesiones[cbSesiones.SelectedIndex].getAsistencia(es.codigo).asistio = true;
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
                            curso.sesiones[cbSesiones.SelectedIndex].getAsistencia(es.codigo).asistio = false;
                    }
                    XmlSerializer xml = new XmlSerializer(typeof(Profesorado));
                    Stream stream = new FileStream("Profesorado.xml", FileMode.Create, FileAccess.Write);
                    xml.Serialize(stream, profesorado);
                    stream.Close();
                }
            }
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Form ses = new SesionesForm(profesorado, profesor, curso);
            this.Visible = false;
            ses.Visible = true;
        }

        private void btnTLmanualmente_Click(object sender, EventArgs e)
        {
            manualmente = true;
        }

        private void dgwParticipaciones_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (manualmente == true)
            {
                Thread thread = new Thread(new ParameterizedThreadStart(hablar));
                thread.Start();
            }
        }

        private void hablar(object texto)
        {
            SpeechSynthesizer synthesizer = new SpeechSynthesizer();
            synthesizer.SetOutputToDefaultAudioDevice();
            synthesizer.Speak(dgwAsistencia.Rows[dgwAsistencia.SelectedRows[0].Index].Cells[1].Value.ToString());
        }

        private void btnDesactivar_Click(object sender, EventArgs e)
        {
            manualmente = false;
            timer1.Enabled = false;
            i = 0;
        }

        private void btnTLsemiautomatico_Click(object sender, EventArgs e)
        {
            timer1.Interval = 1;
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Interval = 7000;
            if (i < dgwAsistencia.Rows.Count)
            {
                synthesizer = new SpeechSynthesizer();
                synthesizer.SetOutputToDefaultAudioDevice();
                synthesizer.Speak(dgwAsistencia.Rows[i].Cells[1].Value.ToString());
                dgwAsistencia.FirstDisplayedScrollingRowIndex = i;
                dgwAsistencia.Refresh();
                dgwAsistencia.CurrentCell = dgwAsistencia.Rows[i].Cells[2];
                dgwAsistencia.Rows[i].Selected = true;
                i++;
            }
            
        }
    }
}
