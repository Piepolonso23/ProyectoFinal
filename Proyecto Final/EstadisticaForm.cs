using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Proyecto_Final
{
    public partial class EstadisticaForm : Form
    {
        Profesorado profesorado;
        Profesor profesor;
        public EstadisticaForm(Profesorado profes, Profesor p)
        {
            profesorado = profes;
            profesor = p;
            InitializeComponent();
        }

        private void EstadisticaForm_Load(object sender, EventArgs e)
        {
            // PRT1 CHART
            string[] cursos = profesor.nombreCursos();
            double[] prt1s = profesor.promediosPRT1();
            for (int i = 0; i < cursos.Length; i++)
            {
                Series serie = cPRT1.Series.Add(cursos[i]);
                serie.Label = prt1s[i].ToString();
                serie.Points.Add(prt1s[i]);
            }
            // PRT2 CHART
            string[] cursos2 = profesor.nombreCursos();
            double[] prt2s = profesor.promediosPRT2();
            for (int i = 0; i < cursos2.Length; i++)
            {
                Series serie = cPRT2.Series.Add(cursos2[i]);
                serie.Label = prt2s[i].ToString();
                serie.Points.Add(prt2s[i]);
            }
            // PRT3 CHART
            string[] cursos3 = profesor.nombreCursos();
            double[] prt3s = profesor.promediosPRT3();
            for (int i = 0; i < cursos3.Length; i++)
            {
                Series serie = cPRT3.Series.Add(cursos3[i]);
                serie.Label = prt3s[i].ToString();
                serie.Points.Add(prt3s[i]);
            }
            // PRT4 CHART
            string[] cursos4 = profesor.nombreCursos();
            double[] prt4s = profesor.promediosPRT4();
            for (int i = 0; i < cursos4.Length; i++)
            {
                Series serie = cPRT4.Series.Add(cursos4[i]);
                serie.Label = prt4s[i].ToString();
                serie.Points.Add(prt4s[i]);
            }
            // TLR1 CHART
            string[] cursos5 = profesor.nombreCursos();
            double[] tlr1s = profesor.promediosPRT4();
            for (int i = 0; i < cursos5.Length; i++)
            {
                Series serie = cTLR1.Series.Add(cursos5[i]);
                serie.Label = tlr1s[i].ToString();
                serie.Points.Add(tlr1s[i]);
            }
            // PART CHART
            string[] cursos6 = profesor.nombreCursos();
            double[] parts = profesor.promediosPRT4();
            for (int i = 0; i < cursos6.Length; i++)
            {
                Series serie = cPART.Series.Add(cursos6[i]);
                serie.Label = parts[i].ToString();
                serie.Points.Add(parts[i]);
            }
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Form cursos = new CursosForm(profesorado, profesor);
            cursos.Visible = true;
            this.Visible = false;
        }
    }
}
