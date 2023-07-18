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
    public partial class PromedioFinalForm : Form
    {
        int cont = 0;
        int promedio = 0;
        Estudiante estudiante;
        Profesorado profesorado;
        public PromedioFinalForm(Profesorado profes, Estudiante e)
        {
            profesorado = profes;
            estudiante = e;
            promedio = (e.PC1 + e.PC2 + e.PC3 + e.PC4 + e.TLR1) / 4;
            if (promedio < 20 && promedio != 19 && e.notaParticipacion > 15)
            {
                promedio += 2;
            }
            else if (promedio > 20)
                promedio = 20;
            else if (promedio == 19 && e.notaParticipacion > 15)
            {
                promedio++;
            }
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(this.Opacity < 1) this.Opacity += 0.05;
            cont++;
            if(cont == 100)
            {
                timer1.Stop();
                Graphics g = panel1.CreateGraphics();
                FiguraAprobado fa;
                FiguraDesaprobado fd;
                if (promedio > 10)
                {
                    fa = new FiguraAprobado(530, 10, 250, 250);
                    fa.dibujar(g);
                }
                else
                {
                    fd = new FiguraDesaprobado(530, 10, 250, 250);
                    fd.dibujar(g);
                }
                lblNota.Text = promedio + "";
            }
        }

        private void PromedioFinalForm_Load(object sender, EventArgs e)
        {
            this.Opacity = 0.0;
            timer1.Start();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Form vista = new VistaNotasForm(profesorado, estudiante);
            vista.Visible = true;
            this.Visible = false;
        }
    }
}
