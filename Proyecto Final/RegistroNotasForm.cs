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
    public partial class RegistroNotasForm : Form
    {
        Profesorado profesorado;
        Profesor profesor;
        Curso curso;
        Excepciones excepciones;
        public RegistroNotasForm(Profesorado profes, Profesor p, Curso c)
        {
            InitializeComponent();
            profesorado = profes;
            profesor = p;
            curso = c;
        }

        private void Evaluaciones_Load(object sender, EventArgs e)
        {
            foreach (Estudiante es in curso.alumnado.alumnos)
            {
                dgwEvaluacion.Rows.Add(es.codigo, es.nombre, es.PC1, es.PC2, es.PC3, es.PC4, es.TLR1, es.notaParticipacion);
            }
        }

        private void dgwEvaluacion_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCodigo.Text = dgwEvaluacion.CurrentRow.Cells[0].Value.ToString();
            txtNombre.Text = dgwEvaluacion.CurrentRow.Cells[1].Value.ToString();
            txtPRT1.Text = dgwEvaluacion.CurrentRow.Cells[2].Value.ToString();
            txtPRT2.Text = dgwEvaluacion.CurrentRow.Cells[3].Value.ToString();
            txtPRT3.Text = dgwEvaluacion.CurrentRow.Cells[4].Value.ToString();
            txtPRT4.Text = dgwEvaluacion.CurrentRow.Cells[5].Value.ToString();
            txtTLR1.Text = dgwEvaluacion.CurrentRow.Cells[6].Value.ToString();
            txtParticipacion.Text = dgwEvaluacion.CurrentRow.Cells[7].Value.ToString();
            foreach  (Estudiante es in curso.alumnado.alumnos)
            {
                if (txtCodigo.Text == es.codigo.ToString())
                {
                    txtParticipaciones.Text = es.mostrarParticipaciones();
                    lblNParticipaciones.Text = "N° Participaciónes: " + es.participaciones.Count();
                }
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if(btnModificar.Text == "Modificar")
            {
                excepciones = new Excepciones();
                foreach (Estudiante es in curso.alumnado.alumnos)
                {
                    if (txtCodigo.Text == es.codigo.ToString())
                    {
                        es.PC1 = excepciones.notas(txtPRT1);
                        es.PC2 = excepciones.notas(txtPRT2);
                        es.PC3 = excepciones.notas(txtPRT3);
                        es.PC4 = excepciones.notas(txtPRT4);
                        es.TLR1 = excepciones.notas(txtTLR1);
                        es.notaParticipacion = excepciones.notas(txtParticipacion);
                    }
                }
                dgwEvaluacion.Rows.Clear();
                foreach (Estudiante es in curso.alumnado.alumnos)
                {
                    dgwEvaluacion.Rows.Add(es.codigo, es.nombre, es.PC1, es.PC2, es.PC3, es.PC4, es.TLR1, es.notaParticipacion);
                }
                XmlSerializer xml = new XmlSerializer(typeof(Profesorado));
                Stream stream = new FileStream("Profesorado.xml", FileMode.Create, FileAccess.Write);
                xml.Serialize(stream, profesorado);
                stream.Close();
            }
            else
            {
                excepciones = new Excepciones();
                if (excepciones.codigo(txtCodigo) != "" && excepciones.nombreCompleto(txtNombre) != "" && excepciones.correo(txtCorreo) != "")
                {
                    if(!profesorado.findAlumno(profesorado, Convert.ToInt32(excepciones.codigo(txtCodigo))))
                    {
                        curso.alumnado.alumnos.Add(new Estudiante(excepciones.nombreCompleto(txtNombre), Convert.ToInt32(excepciones.codigo(txtCodigo)), excepciones.correo(txtCorreo), excepciones.notas(txtPRT1), excepciones.notas(txtPRT2), excepciones.notas(txtPRT3), excepciones.notas(txtPRT4), excepciones.notas(txtTLR1), excepciones.notas(txtParticipacion)));
                        btnModificar.Text = "Modificar";
                        btnAgregar.Enabled = true;
                        txtCodigo.ReadOnly = true;
                        txtNombre.ReadOnly = true;
                        lblCorreo.Visible = false;
                        txtCorreo.Visible = false;
                        btnCancelar.Visible = false;
                        dgwEvaluacion.Enabled = true;
                        dgwEvaluacion.Rows.Clear();
                        foreach (Estudiante es in curso.alumnado.alumnos)
                        {
                            dgwEvaluacion.Rows.Add(es.codigo, es.nombre, es.PC1, es.PC2, es.PC3, es.PC4, es.TLR1, es.notaParticipacion);
                        }
                        XmlSerializer xml = new XmlSerializer(typeof(Profesorado));
                        Stream stream = new FileStream("Profesorado.xml", FileMode.Create, FileAccess.Write);
                        xml.Serialize(stream, profesorado);
                        stream.Close();
                    }
                    else
                    {
                        MessageBox.Show(null, "Este alumno ya tiene un curso inscrito", "Información", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        txtCodigo.Clear();
                        txtNombre.Clear();
                        txtCorreo.Clear();
                        txtPRT1.Clear();
                        txtPRT2.Clear();
                        txtPRT3.Clear();
                        txtPRT4.Clear();
                        txtTLR1.Clear();
                        txtParticipacion.Clear();
                        txtCodigo.Focus();
                    }
                }
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Form ses = new SesionesForm(profesorado, profesor, curso);
            this.Visible = false;
            ses.Visible = true;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            btnModificar.Text = "Agregar";
            btnAgregar.Enabled = false;
            txtCodigo.ReadOnly = false;
            txtNombre.ReadOnly = false;
            lblCorreo.Visible = true;
            txtCorreo.Visible = true;
            btnCancelar.Visible = true;
            dgwEvaluacion.Enabled = false;
            txtCorreo.Clear();
            txtCodigo.Clear();
            txtNombre.Clear();
            txtPRT1.Clear();
            txtPRT2.Clear();
            txtPRT3.Clear();
            txtPRT4.Clear();
            txtTLR1.Clear();
            txtParticipacion.Clear();
            txtParticipaciones.Clear();
            txtCorreo.Focus();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            btnModificar.Text = "Modificar";
            btnAgregar.Enabled = true;
            txtCodigo.ReadOnly = true;
            txtNombre.ReadOnly = true;
            lblCorreo.Visible = false;
            txtCorreo.Visible = false;
            btnCancelar.Visible = false;
            dgwEvaluacion.Enabled = true;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Está seguro que quiere eliminar a este alumno?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                int id = profesorado.findAlumnoID(profesorado, profesorado.findAlumnoClase(profesorado, Convert.ToInt32(dgwEvaluacion.CurrentRow.Cells[0].Value)));
                curso.alumnado.alumnos.RemoveAt(id);
                dgwEvaluacion.Rows.Clear();
                foreach (Estudiante es in curso.alumnado.alumnos)
                {
                    dgwEvaluacion.Rows.Add(es.codigo, es.nombre, es.PC1, es.PC2, es.PC3, es.PC4, es.TLR1, es.notaParticipacion);
                }
                XmlSerializer xml = new XmlSerializer(typeof(Profesorado));
                Stream stream = new FileStream("Profesorado.xml", FileMode.Create, FileAccess.Write);
                xml.Serialize(stream, profesorado);
                stream.Close();
            }
        }
    }
}
