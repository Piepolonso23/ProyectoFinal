namespace Proyecto_Final
{
    partial class SesionesForm
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
            this.cbSesiones = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblAsistencia = new System.Windows.Forms.Label();
            this.btnAsistencia = new Proyecto_Final.NewControls.BotonCircular();
            this.btnAgregarSesion = new Proyecto_Final.NewControls.BotonCircular();
            this.btnEditarSesiones = new Proyecto_Final.NewControls.NewButton();
            this.btnSorteoNoParticipan = new Proyecto_Final.NewControls.NewButton();
            this.btnRegresar = new Proyecto_Final.NewControls.BotonCircular();
            this.btnSorteo = new Proyecto_Final.NewControls.NewButton();
            this.btnRegistroNotas = new Proyecto_Final.NewControls.NewButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgwParticipaciones = new System.Windows.Forms.DataGridView();
            this.cCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cAlumnos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cParticipacion = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwParticipaciones)).BeginInit();
            this.SuspendLayout();
            // 
            // cbSesiones
            // 
            this.cbSesiones.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSesiones.FormattingEnabled = true;
            this.cbSesiones.Location = new System.Drawing.Point(181, 173);
            this.cbSesiones.Name = "cbSesiones";
            this.cbSesiones.Size = new System.Drawing.Size(191, 24);
            this.cbSesiones.TabIndex = 0;
            this.cbSesiones.SelectedIndexChanged += new System.EventHandler(this.cbSesiones_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.lblAsistencia);
            this.panel1.Controls.Add(this.btnAsistencia);
            this.panel1.Controls.Add(this.btnAgregarSesion);
            this.panel1.Controls.Add(this.btnEditarSesiones);
            this.panel1.Controls.Add(this.btnSorteoNoParticipan);
            this.panel1.Controls.Add(this.btnRegresar);
            this.panel1.Controls.Add(this.btnSorteo);
            this.panel1.Controls.Add(this.btnRegistroNotas);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.dgwParticipaciones);
            this.panel1.Controls.Add(this.cbSesiones);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1081, 626);
            this.panel1.TabIndex = 1;
            // 
            // lblAsistencia
            // 
            this.lblAsistencia.AutoSize = true;
            this.lblAsistencia.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAsistencia.Location = new System.Drawing.Point(938, 353);
            this.lblAsistencia.Name = "lblAsistencia";
            this.lblAsistencia.Size = new System.Drawing.Size(127, 27);
            this.lblAsistencia.TabIndex = 25;
            this.lblAsistencia.Text = "Asistencia";
            // 
            // btnAsistencia
            // 
            this.btnAsistencia.BackColor = System.Drawing.Color.Transparent;
            this.btnAsistencia.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnAsistencia.FlatAppearance.BorderSize = 0;
            this.btnAsistencia.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnAsistencia.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnAsistencia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAsistencia.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAsistencia.ForeColor = System.Drawing.Color.White;
            this.btnAsistencia.Image = global::Proyecto_Final.Properties.Resources.btnAvanzar;
            this.btnAsistencia.Location = new System.Drawing.Point(958, 275);
            this.btnAsistencia.Name = "btnAsistencia";
            this.btnAsistencia.Size = new System.Drawing.Size(84, 75);
            this.btnAsistencia.TabIndex = 24;
            this.btnAsistencia.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAsistencia.UseVisualStyleBackColor = false;
            this.btnAsistencia.Click += new System.EventHandler(this.btnAsistencia_Click);
            // 
            // btnAgregarSesion
            // 
            this.btnAgregarSesion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(135)))), ((int)(((byte)(49)))));
            this.btnAgregarSesion.FlatAppearance.BorderSize = 0;
            this.btnAgregarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarSesion.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarSesion.ForeColor = System.Drawing.Color.White;
            this.btnAgregarSesion.Location = new System.Drawing.Point(107, 152);
            this.btnAgregarSesion.Name = "btnAgregarSesion";
            this.btnAgregarSesion.Size = new System.Drawing.Size(60, 57);
            this.btnAgregarSesion.TabIndex = 23;
            this.btnAgregarSesion.Text = "+";
            this.btnAgregarSesion.UseVisualStyleBackColor = false;
            this.btnAgregarSesion.Click += new System.EventHandler(this.btnAgregarSesion_Click_1);
            // 
            // btnEditarSesiones
            // 
            this.btnEditarSesiones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(135)))), ((int)(((byte)(49)))));
            this.btnEditarSesiones.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(135)))), ((int)(((byte)(49)))));
            this.btnEditarSesiones.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnEditarSesiones.BorderRadius = 20;
            this.btnEditarSesiones.BorderSize = 0;
            this.btnEditarSesiones.FlatAppearance.BorderSize = 0;
            this.btnEditarSesiones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditarSesiones.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditarSesiones.ForeColor = System.Drawing.Color.White;
            this.btnEditarSesiones.Location = new System.Drawing.Point(107, 275);
            this.btnEditarSesiones.Name = "btnEditarSesiones";
            this.btnEditarSesiones.Size = new System.Drawing.Size(246, 58);
            this.btnEditarSesiones.TabIndex = 22;
            this.btnEditarSesiones.Text = "Editar sesiones";
            this.btnEditarSesiones.TextColor = System.Drawing.Color.White;
            this.btnEditarSesiones.UseVisualStyleBackColor = false;
            this.btnEditarSesiones.Click += new System.EventHandler(this.btnEditarSesiones_Click);
            // 
            // btnSorteoNoParticipan
            // 
            this.btnSorteoNoParticipan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(135)))), ((int)(((byte)(49)))));
            this.btnSorteoNoParticipan.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(135)))), ((int)(((byte)(49)))));
            this.btnSorteoNoParticipan.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnSorteoNoParticipan.BorderRadius = 20;
            this.btnSorteoNoParticipan.BorderSize = 0;
            this.btnSorteoNoParticipan.FlatAppearance.BorderSize = 0;
            this.btnSorteoNoParticipan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSorteoNoParticipan.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSorteoNoParticipan.ForeColor = System.Drawing.Color.White;
            this.btnSorteoNoParticipan.Location = new System.Drawing.Point(107, 524);
            this.btnSorteoNoParticipan.Name = "btnSorteoNoParticipan";
            this.btnSorteoNoParticipan.Size = new System.Drawing.Size(246, 56);
            this.btnSorteoNoParticipan.TabIndex = 21;
            this.btnSorteoNoParticipan.Text = "Sorteo(no participan)";
            this.btnSorteoNoParticipan.TextColor = System.Drawing.Color.White;
            this.btnSorteoNoParticipan.UseVisualStyleBackColor = false;
            this.btnSorteoNoParticipan.Click += new System.EventHandler(this.btnSorteoNoParticipan_Click);
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
            this.btnRegresar.TabIndex = 20;
            this.btnRegresar.UseVisualStyleBackColor = false;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // btnSorteo
            // 
            this.btnSorteo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(135)))), ((int)(((byte)(49)))));
            this.btnSorteo.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(135)))), ((int)(((byte)(49)))));
            this.btnSorteo.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnSorteo.BorderRadius = 20;
            this.btnSorteo.BorderSize = 0;
            this.btnSorteo.FlatAppearance.BorderSize = 0;
            this.btnSorteo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSorteo.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSorteo.ForeColor = System.Drawing.Color.White;
            this.btnSorteo.Location = new System.Drawing.Point(107, 446);
            this.btnSorteo.Name = "btnSorteo";
            this.btnSorteo.Size = new System.Drawing.Size(246, 56);
            this.btnSorteo.TabIndex = 12;
            this.btnSorteo.Text = "Sorteo";
            this.btnSorteo.TextColor = System.Drawing.Color.White;
            this.btnSorteo.UseVisualStyleBackColor = false;
            this.btnSorteo.Click += new System.EventHandler(this.btnSorteo_Click);
            // 
            // btnRegistroNotas
            // 
            this.btnRegistroNotas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(135)))), ((int)(((byte)(49)))));
            this.btnRegistroNotas.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(135)))), ((int)(((byte)(49)))));
            this.btnRegistroNotas.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnRegistroNotas.BorderRadius = 20;
            this.btnRegistroNotas.BorderSize = 0;
            this.btnRegistroNotas.FlatAppearance.BorderSize = 0;
            this.btnRegistroNotas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistroNotas.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistroNotas.ForeColor = System.Drawing.Color.White;
            this.btnRegistroNotas.Location = new System.Drawing.Point(107, 348);
            this.btnRegistroNotas.Name = "btnRegistroNotas";
            this.btnRegistroNotas.Size = new System.Drawing.Size(246, 79);
            this.btnRegistroNotas.TabIndex = 11;
            this.btnRegistroNotas.Text = "Registro de notas\r\ny participaciones";
            this.btnRegistroNotas.TextColor = System.Drawing.Color.White;
            this.btnRegistroNotas.UseVisualStyleBackColor = false;
            this.btnRegistroNotas.Click += new System.EventHandler(this.btnRegistroNotas_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Proyecto_Final.Properties.Resources.urp;
            this.pictureBox1.Location = new System.Drawing.Point(97, 44);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(84, 72);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(199, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(404, 37);
            this.label2.TabIndex = 9;
            this.label2.Text = "Control de participaciones";
            // 
            // dgwParticipaciones
            // 
            this.dgwParticipaciones.AllowDrop = true;
            this.dgwParticipaciones.AllowUserToAddRows = false;
            this.dgwParticipaciones.AllowUserToDeleteRows = false;
            this.dgwParticipaciones.AllowUserToOrderColumns = true;
            this.dgwParticipaciones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgwParticipaciones.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgwParticipaciones.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dgwParticipaciones.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgwParticipaciones.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(135)))), ((int)(((byte)(49)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Schoolbook", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(135)))), ((int)(((byte)(49)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgwParticipaciones.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgwParticipaciones.ColumnHeadersHeight = 30;
            this.dgwParticipaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgwParticipaciones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cCodigo,
            this.cAlumnos,
            this.cParticipacion});
            this.dgwParticipaciones.EnableHeadersVisualStyles = false;
            this.dgwParticipaciones.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(135)))), ((int)(((byte)(49)))));
            this.dgwParticipaciones.Location = new System.Drawing.Point(421, 154);
            this.dgwParticipaciones.Name = "dgwParticipaciones";
            this.dgwParticipaciones.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Lime;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgwParticipaciones.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgwParticipaciones.RowHeadersVisible = false;
            this.dgwParticipaciones.RowHeadersWidth = 51;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Schoolbook", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            this.dgwParticipaciones.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgwParticipaciones.RowTemplate.Height = 24;
            this.dgwParticipaciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwParticipaciones.Size = new System.Drawing.Size(486, 426);
            this.dgwParticipaciones.TabIndex = 8;
            this.dgwParticipaciones.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwParticipaciones_CellContentClick);
            // 
            // cCodigo
            // 
            this.cCodigo.HeaderText = "Código";
            this.cCodigo.MinimumWidth = 6;
            this.cCodigo.Name = "cCodigo";
            this.cCodigo.Width = 91;
            // 
            // cAlumnos
            // 
            this.cAlumnos.HeaderText = "Nombres";
            this.cAlumnos.MinimumWidth = 6;
            this.cAlumnos.Name = "cAlumnos";
            this.cAlumnos.Width = 109;
            // 
            // cParticipacion
            // 
            this.cParticipacion.HeaderText = "Participación";
            this.cParticipacion.MinimumWidth = 6;
            this.cParticipacion.Name = "cParticipacion";
            this.cParticipacion.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cParticipacion.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.cParticipacion.Width = 141;
            // 
            // SesionesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(135)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(1105, 650);
            this.Controls.Add(this.panel1);
            this.Name = "SesionesForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sesiones";
            this.Load += new System.EventHandler(this.SesionesForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwParticipaciones)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgwParticipaciones;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.ComboBox cbSesiones;
        private System.Windows.Forms.DataGridViewTextBoxColumn cCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn cAlumnos;
        private System.Windows.Forms.DataGridViewCheckBoxColumn cParticipacion;
        public NewControls.NewButton btnSorteo;
        public NewControls.NewButton btnRegistroNotas;
        private NewControls.BotonCircular btnRegresar;
        public NewControls.NewButton btnSorteoNoParticipan;
        private NewControls.BotonCircular btnAgregarSesion;
        public NewControls.NewButton btnEditarSesiones;
        private NewControls.BotonCircular btnAsistencia;
        private System.Windows.Forms.Label lblAsistencia;
    }
}