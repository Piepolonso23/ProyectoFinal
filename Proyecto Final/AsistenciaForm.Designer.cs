namespace Proyecto_Final
{
    partial class AsistenciaForm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnTLsemiautomatico = new Proyecto_Final.NewControls.NewButton();
            this.btnDesactivar = new Proyecto_Final.NewControls.NewButton();
            this.btnTLmanualmente = new Proyecto_Final.NewControls.NewButton();
            this.btnRegresar = new Proyecto_Final.NewControls.BotonCircular();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgwAsistencia = new System.Windows.Forms.DataGridView();
            this.cCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cAlumnos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cAsistencia = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.cbSesiones = new System.Windows.Forms.ComboBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwAsistencia)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnTLsemiautomatico);
            this.panel1.Controls.Add(this.btnDesactivar);
            this.panel1.Controls.Add(this.btnTLmanualmente);
            this.panel1.Controls.Add(this.btnRegresar);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.dgwAsistencia);
            this.panel1.Controls.Add(this.cbSesiones);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(925, 661);
            this.panel1.TabIndex = 0;
            // 
            // btnTLsemiautomatico
            // 
            this.btnTLsemiautomatico.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(135)))), ((int)(((byte)(49)))));
            this.btnTLsemiautomatico.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(135)))), ((int)(((byte)(49)))));
            this.btnTLsemiautomatico.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnTLsemiautomatico.BorderRadius = 20;
            this.btnTLsemiautomatico.BorderSize = 0;
            this.btnTLsemiautomatico.FlatAppearance.BorderSize = 0;
            this.btnTLsemiautomatico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTLsemiautomatico.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTLsemiautomatico.ForeColor = System.Drawing.Color.White;
            this.btnTLsemiautomatico.Location = new System.Drawing.Point(79, 355);
            this.btnTLsemiautomatico.Name = "btnTLsemiautomatico";
            this.btnTLsemiautomatico.Size = new System.Drawing.Size(246, 80);
            this.btnTLsemiautomatico.TabIndex = 28;
            this.btnTLsemiautomatico.Text = "Tomar lista\r\n(semiautomatico)";
            this.btnTLsemiautomatico.TextColor = System.Drawing.Color.White;
            this.btnTLsemiautomatico.UseVisualStyleBackColor = false;
            this.btnTLsemiautomatico.Click += new System.EventHandler(this.btnTLsemiautomatico_Click);
            // 
            // btnDesactivar
            // 
            this.btnDesactivar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(135)))), ((int)(((byte)(49)))));
            this.btnDesactivar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(135)))), ((int)(((byte)(49)))));
            this.btnDesactivar.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnDesactivar.BorderRadius = 20;
            this.btnDesactivar.BorderSize = 0;
            this.btnDesactivar.FlatAppearance.BorderSize = 0;
            this.btnDesactivar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDesactivar.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDesactivar.ForeColor = System.Drawing.Color.White;
            this.btnDesactivar.Location = new System.Drawing.Point(79, 450);
            this.btnDesactivar.Name = "btnDesactivar";
            this.btnDesactivar.Size = new System.Drawing.Size(246, 68);
            this.btnDesactivar.TabIndex = 27;
            this.btnDesactivar.Text = "Desactivar modo";
            this.btnDesactivar.TextColor = System.Drawing.Color.White;
            this.btnDesactivar.UseVisualStyleBackColor = false;
            this.btnDesactivar.Click += new System.EventHandler(this.btnDesactivar_Click);
            // 
            // btnTLmanualmente
            // 
            this.btnTLmanualmente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(135)))), ((int)(((byte)(49)))));
            this.btnTLmanualmente.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(135)))), ((int)(((byte)(49)))));
            this.btnTLmanualmente.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.btnTLmanualmente.BorderRadius = 20;
            this.btnTLmanualmente.BorderSize = 0;
            this.btnTLmanualmente.FlatAppearance.BorderSize = 0;
            this.btnTLmanualmente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTLmanualmente.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTLmanualmente.ForeColor = System.Drawing.Color.White;
            this.btnTLmanualmente.Location = new System.Drawing.Point(79, 260);
            this.btnTLmanualmente.Name = "btnTLmanualmente";
            this.btnTLmanualmente.Size = new System.Drawing.Size(246, 80);
            this.btnTLmanualmente.TabIndex = 26;
            this.btnTLmanualmente.Text = "Tomar lista\r\n(manualmente)";
            this.btnTLmanualmente.TextColor = System.Drawing.Color.White;
            this.btnTLmanualmente.UseVisualStyleBackColor = false;
            this.btnTLmanualmente.Click += new System.EventHandler(this.btnTLmanualmente_Click);
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
            this.btnRegresar.TabIndex = 25;
            this.btnRegresar.UseVisualStyleBackColor = false;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Proyecto_Final.Properties.Resources.urp;
            this.pictureBox1.Location = new System.Drawing.Point(100, 49);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(84, 72);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(202, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(322, 37);
            this.label2.TabIndex = 23;
            this.label2.Text = "Control de asistencia";
            // 
            // dgwAsistencia
            // 
            this.dgwAsistencia.AllowDrop = true;
            this.dgwAsistencia.AllowUserToAddRows = false;
            this.dgwAsistencia.AllowUserToDeleteRows = false;
            this.dgwAsistencia.AllowUserToOrderColumns = true;
            this.dgwAsistencia.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgwAsistencia.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgwAsistencia.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dgwAsistencia.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgwAsistencia.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(135)))), ((int)(((byte)(49)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Century Schoolbook", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(135)))), ((int)(((byte)(49)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgwAsistencia.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgwAsistencia.ColumnHeadersHeight = 30;
            this.dgwAsistencia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgwAsistencia.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cCodigo,
            this.cAlumnos,
            this.cAsistencia});
            this.dgwAsistencia.EnableHeadersVisualStyles = false;
            this.dgwAsistencia.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(135)))), ((int)(((byte)(49)))));
            this.dgwAsistencia.Location = new System.Drawing.Point(377, 150);
            this.dgwAsistencia.Name = "dgwAsistencia";
            this.dgwAsistencia.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Lime;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgwAsistencia.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgwAsistencia.RowHeadersVisible = false;
            this.dgwAsistencia.RowHeadersWidth = 51;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Century Schoolbook", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            this.dgwAsistencia.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgwAsistencia.RowTemplate.Height = 24;
            this.dgwAsistencia.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgwAsistencia.Size = new System.Drawing.Size(486, 426);
            this.dgwAsistencia.TabIndex = 22;
            this.dgwAsistencia.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwParticipaciones_CellContentClick);
            this.dgwAsistencia.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwParticipaciones_RowEnter);
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
            // cAsistencia
            // 
            this.cAsistencia.HeaderText = "Asistencia";
            this.cAsistencia.MinimumWidth = 6;
            this.cAsistencia.Name = "cAsistencia";
            this.cAsistencia.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.cAsistencia.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.cAsistencia.Width = 118;
            // 
            // cbSesiones
            // 
            this.cbSesiones.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSesiones.FormattingEnabled = true;
            this.cbSesiones.Location = new System.Drawing.Point(100, 170);
            this.cbSesiones.Name = "cbSesiones";
            this.cbSesiones.Size = new System.Drawing.Size(221, 24);
            this.cbSesiones.TabIndex = 21;
            this.cbSesiones.SelectedIndexChanged += new System.EventHandler(this.cbSesiones_SelectedIndexChanged);
            // 
            // timer1
            // 
            this.timer1.Interval = 5000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // AsistenciaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(135)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(949, 685);
            this.Controls.Add(this.panel1);
            this.Name = "AsistenciaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Asistencia";
            this.Load += new System.EventHandler(this.AsistenciaForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgwAsistencia)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private NewControls.BotonCircular btnRegresar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgwAsistencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn cCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn cAlumnos;
        private System.Windows.Forms.DataGridViewCheckBoxColumn cAsistencia;
        public System.Windows.Forms.ComboBox cbSesiones;
        public NewControls.NewButton btnTLmanualmente;
        public NewControls.NewButton btnTLsemiautomatico;
        public NewControls.NewButton btnDesactivar;
        private System.Windows.Forms.Timer timer1;
    }
}