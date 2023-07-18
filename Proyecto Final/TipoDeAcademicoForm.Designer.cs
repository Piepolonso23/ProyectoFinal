namespace Proyecto_Final
{
    partial class TipoDeAcademicoForm
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btnAlumno = new Proyecto_Final.NewControls.NewButton();
            this.btnProfesor = new Proyecto_Final.NewControls.NewButton();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.btnAlumno);
            this.panel1.Controls.Add(this.btnProfesor);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(404, 504);
            this.panel1.TabIndex = 1;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Proyecto_Final.Properties.Resources.logo53;
            this.pictureBox2.Location = new System.Drawing.Point(-12, -12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(423, 219);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // btnAlumno
            // 
            this.btnAlumno.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(135)))), ((int)(((byte)(49)))));
            this.btnAlumno.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(135)))), ((int)(((byte)(49)))));
            this.btnAlumno.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnAlumno.BorderRadius = 20;
            this.btnAlumno.BorderSize = 0;
            this.btnAlumno.FlatAppearance.BorderSize = 0;
            this.btnAlumno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAlumno.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlumno.ForeColor = System.Drawing.Color.White;
            this.btnAlumno.Location = new System.Drawing.Point(72, 399);
            this.btnAlumno.Name = "btnAlumno";
            this.btnAlumno.Size = new System.Drawing.Size(263, 52);
            this.btnAlumno.TabIndex = 2;
            this.btnAlumno.Text = "Alumno";
            this.btnAlumno.TextColor = System.Drawing.Color.White;
            this.btnAlumno.UseVisualStyleBackColor = false;
            this.btnAlumno.Click += new System.EventHandler(this.btnAlumno_Click);
            // 
            // btnProfesor
            // 
            this.btnProfesor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(135)))), ((int)(((byte)(49)))));
            this.btnProfesor.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(135)))), ((int)(((byte)(49)))));
            this.btnProfesor.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnProfesor.BorderRadius = 20;
            this.btnProfesor.BorderSize = 0;
            this.btnProfesor.FlatAppearance.BorderSize = 0;
            this.btnProfesor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProfesor.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProfesor.ForeColor = System.Drawing.Color.White;
            this.btnProfesor.Location = new System.Drawing.Point(72, 312);
            this.btnProfesor.Name = "btnProfesor";
            this.btnProfesor.Size = new System.Drawing.Size(263, 52);
            this.btnProfesor.TabIndex = 1;
            this.btnProfesor.Text = "Profesor";
            this.btnProfesor.TextColor = System.Drawing.Color.White;
            this.btnProfesor.UseVisualStyleBackColor = false;
            this.btnProfesor.Click += new System.EventHandler(this.btnProfesor_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(94, 209);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(222, 74);
            this.label1.TabIndex = 0;
            this.label1.Text = "Escoja su tipo \r\nacadémico";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TipoDeAcademicoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(135)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(428, 528);
            this.Controls.Add(this.panel1);
            this.Name = "TipoDeAcademicoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Seleccione su tipo académico";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private NewControls.NewButton btnProfesor;
        private System.Windows.Forms.Label label1;
        public NewControls.NewButton btnAlumno;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

