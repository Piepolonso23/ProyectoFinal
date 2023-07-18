namespace Proyecto_Final
{
    partial class VistaNotasForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.dgwNotas = new System.Windows.Forms.DataGridView();
            this.cEvaluacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cPrefijo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cNota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCurso = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTotales = new System.Windows.Forms.Label();
            this.lblAsistidos = new System.Windows.Forms.Label();
            this.lblFaltados = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnRegresar = new Proyecto_Final.NewControls.BotonCircular();
            this.lblAlumno = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSiguiente = new Proyecto_Final.NewControls.NewButton();
            this.cGrafico = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtParticipaciones = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgwNotas)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cGrafico)).BeginInit();
            this.SuspendLayout();
            // 
            // dgwNotas
            // 
            this.dgwNotas.AllowUserToAddRows = false;
            this.dgwNotas.AllowUserToDeleteRows = false;
            this.dgwNotas.AllowUserToOrderColumns = true;
            this.dgwNotas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgwNotas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgwNotas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dgwNotas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgwNotas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(135)))), ((int)(((byte)(49)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Schoolbook", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(135)))), ((int)(((byte)(49)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgwNotas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgwNotas.ColumnHeadersHeight = 30;
            this.dgwNotas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgwNotas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cEvaluacion,
            this.cPrefijo,
            this.cNota});
            this.dgwNotas.EnableHeadersVisualStyles = false;
            this.dgwNotas.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(135)))), ((int)(((byte)(49)))));
            this.dgwNotas.Location = new System.Drawing.Point(147, 180);
            this.dgwNotas.Name = "dgwNotas";
            this.dgwNotas.ReadOnly = true;
            this.dgwNotas.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Lime;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgwNotas.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgwNotas.RowHeadersVisible = false;
            this.dgwNotas.RowHeadersWidth = 51;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Schoolbook", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            this.dgwNotas.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgwNotas.RowTemplate.Height = 24;
            this.dgwNotas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwNotas.Size = new System.Drawing.Size(466, 230);
            this.dgwNotas.TabIndex = 8;
            // 
            // cEvaluacion
            // 
            this.cEvaluacion.HeaderText = " Descripción de Evaluación\t";
            this.cEvaluacion.MinimumWidth = 6;
            this.cEvaluacion.Name = "cEvaluacion";
            this.cEvaluacion.ReadOnly = true;
            this.cEvaluacion.Width = 250;
            // 
            // cPrefijo
            // 
            this.cPrefijo.HeaderText = "Prefijo";
            this.cPrefijo.MinimumWidth = 6;
            this.cPrefijo.Name = "cPrefijo";
            this.cPrefijo.ReadOnly = true;
            this.cPrefijo.Width = 90;
            // 
            // cNota
            // 
            this.cNota.HeaderText = "Nota";
            this.cNota.MinimumWidth = 6;
            this.cNota.Name = "cNota";
            this.cNota.ReadOnly = true;
            this.cNota.Width = 76;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(96, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(363, 27);
            this.label1.TabIndex = 9;
            this.label1.Text = "Consulta de notas académicas";
            // 
            // lblCurso
            // 
            this.lblCurso.AutoSize = true;
            this.lblCurso.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurso.Location = new System.Drawing.Point(96, 125);
            this.lblCurso.Name = "lblCurso";
            this.lblCurso.Size = new System.Drawing.Size(76, 27);
            this.lblCurso.TabIndex = 10;
            this.lblCurso.Text = "Curso";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.lblTotales);
            this.panel1.Controls.Add(this.lblAsistidos);
            this.panel1.Controls.Add(this.lblFaltados);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btnRegresar);
            this.panel1.Controls.Add(this.lblAlumno);
            this.panel1.Controls.Add(this.dgwNotas);
            this.panel1.Controls.Add(this.lblCurso);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1499, 683);
            this.panel1.TabIndex = 11;
            // 
            // lblTotales
            // 
            this.lblTotales.AutoSize = true;
            this.lblTotales.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotales.ForeColor = System.Drawing.Color.Black;
            this.lblTotales.Location = new System.Drawing.Point(124, 585);
            this.lblTotales.Name = "lblTotales";
            this.lblTotales.Size = new System.Drawing.Size(153, 21);
            this.lblTotales.TabIndex = 20;
            this.lblTotales.Text = "Sesiones totales:";
            // 
            // lblAsistidos
            // 
            this.lblAsistidos.AutoSize = true;
            this.lblAsistidos.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAsistidos.ForeColor = System.Drawing.Color.Black;
            this.lblAsistidos.Location = new System.Drawing.Point(124, 493);
            this.lblAsistidos.Name = "lblAsistidos";
            this.lblAsistidos.Size = new System.Drawing.Size(163, 21);
            this.lblAsistidos.TabIndex = 19;
            this.lblAsistidos.Text = "Sesiones asistidas:";
            // 
            // lblFaltados
            // 
            this.lblFaltados.AutoSize = true;
            this.lblFaltados.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFaltados.ForeColor = System.Drawing.Color.Black;
            this.lblFaltados.Location = new System.Drawing.Point(124, 541);
            this.lblFaltados.Name = "lblFaltados";
            this.lblFaltados.Size = new System.Drawing.Size(164, 21);
            this.lblFaltados.TabIndex = 18;
            this.lblFaltados.Text = "Sesiones faltadas:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(96, 443);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 27);
            this.label3.TabIndex = 13;
            this.label3.Text = "Asistencia";
            // 
            // btnRegresar
            // 
            this.btnRegresar.BackColor = System.Drawing.Color.Transparent;
            this.btnRegresar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnRegresar.FlatAppearance.BorderSize = 0;
            this.btnRegresar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnRegresar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnRegresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegresar.Font = new System.Drawing.Font("Century Gothic", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegresar.ForeColor = System.Drawing.Color.White;
            this.btnRegresar.Image = global::Proyecto_Final.Properties.Resources.btnRegresar;
            this.btnRegresar.Location = new System.Drawing.Point(3, 3);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(84, 75);
            this.btnRegresar.TabIndex = 12;
            this.btnRegresar.UseVisualStyleBackColor = false;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // lblAlumno
            // 
            this.lblAlumno.AutoSize = true;
            this.lblAlumno.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAlumno.ForeColor = System.Drawing.Color.Black;
            this.lblAlumno.Location = new System.Drawing.Point(96, 54);
            this.lblAlumno.Name = "lblAlumno";
            this.lblAlumno.Size = new System.Drawing.Size(106, 27);
            this.lblAlumno.TabIndex = 11;
            this.lblAlumno.Text = "Alumno:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel2.Controls.Add(this.btnSiguiente);
            this.panel2.Controls.Add(this.cGrafico);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txtParticipaciones);
            this.panel2.Controls.Add(this.label9);
            this.panel2.ForeColor = System.Drawing.Color.Black;
            this.panel2.Location = new System.Drawing.Point(758, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(753, 683);
            this.panel2.TabIndex = 12;
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(135)))), ((int)(((byte)(49)))));
            this.btnSiguiente.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(135)))), ((int)(((byte)(49)))));
            this.btnSiguiente.BorderColor = System.Drawing.Color.Gold;
            this.btnSiguiente.BorderRadius = 20;
            this.btnSiguiente.BorderSize = 0;
            this.btnSiguiente.FlatAppearance.BorderSize = 0;
            this.btnSiguiente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSiguiente.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSiguiente.ForeColor = System.Drawing.Color.Black;
            this.btnSiguiente.Location = new System.Drawing.Point(436, 605);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(298, 53);
            this.btnSiguiente.TabIndex = 22;
            this.btnSiguiente.Text = "PROMEDIO FINAL";
            this.btnSiguiente.TextColor = System.Drawing.Color.Black;
            this.btnSiguiente.UseVisualStyleBackColor = false;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // cGrafico
            // 
            chartArea1.Name = "ChartArea1";
            this.cGrafico.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.cGrafico.Legends.Add(legend1);
            this.cGrafico.Location = new System.Drawing.Point(120, 332);
            this.cGrafico.Name = "cGrafico";
            this.cGrafico.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            this.cGrafico.Size = new System.Drawing.Size(491, 239);
            this.cGrafico.TabIndex = 21;
            this.cGrafico.Text = "chart1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(15, 280);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(269, 27);
            this.label4.TabIndex = 20;
            this.label4.Text = "Estadisticas en el curso";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(15, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(270, 27);
            this.label2.TabIndex = 19;
            this.label2.Text = "Interacción en el curso";
            // 
            // txtParticipaciones
            // 
            this.txtParticipaciones.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtParticipaciones.Location = new System.Drawing.Point(284, 82);
            this.txtParticipaciones.Multiline = true;
            this.txtParticipaciones.Name = "txtParticipaciones";
            this.txtParticipaciones.ReadOnly = true;
            this.txtParticipaciones.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtParticipaciones.Size = new System.Drawing.Size(327, 174);
            this.txtParticipaciones.TabIndex = 18;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(116, 85);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(149, 21);
            this.label9.TabIndex = 17;
            this.label9.Text = "Participaciónes:";
            // 
            // VistaNotasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(135)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(1523, 707);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(135)))), ((int)(((byte)(49)))));
            this.Name = "VistaNotasForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vista de notas";
            this.Load += new System.EventHandler(this.VistaNotasForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwNotas)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cGrafico)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwNotas;
        private System.Windows.Forms.DataGridViewTextBoxColumn cEvaluacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn cPrefijo;
        private System.Windows.Forms.DataGridViewTextBoxColumn cNota;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblCurso;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblAlumno;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataVisualization.Charting.Chart cGrafico;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtParticipaciones;
        private System.Windows.Forms.Label label9;
        private NewControls.NewButton btnSiguiente;
        private NewControls.BotonCircular btnRegresar;
        private System.Windows.Forms.Label lblAsistidos;
        private System.Windows.Forms.Label lblFaltados;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblTotales;
    }
}