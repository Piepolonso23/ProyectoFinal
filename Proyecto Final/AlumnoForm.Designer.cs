﻿namespace Proyecto_Final
{
    partial class AlumnoForm
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblOlvidarContrasena = new System.Windows.Forms.Label();
            this.btnRegresar = new Proyecto_Final.NewControls.BotonCircular();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnIngresar = new Proyecto_Final.NewControls.NewButton();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtContrasena = new System.Windows.Forms.TextBox();
            this.lblContrasena = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.lblOlvidarContrasena);
            this.panel2.Controls.Add(this.btnRegresar);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.btnIngresar);
            this.panel2.Controls.Add(this.txtCodigo);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txtContrasena);
            this.panel2.Controls.Add(this.lblContrasena);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(575, 398);
            this.panel2.TabIndex = 7;
            // 
            // lblOlvidarContrasena
            // 
            this.lblOlvidarContrasena.AutoSize = true;
            this.lblOlvidarContrasena.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOlvidarContrasena.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(135)))), ((int)(((byte)(49)))));
            this.lblOlvidarContrasena.Location = new System.Drawing.Point(97, 269);
            this.lblOlvidarContrasena.Name = "lblOlvidarContrasena";
            this.lblOlvidarContrasena.Size = new System.Drawing.Size(199, 22);
            this.lblOlvidarContrasena.TabIndex = 24;
            this.lblOlvidarContrasena.Text = "Olvidé mi contraseña";
            this.lblOlvidarContrasena.Click += new System.EventHandler(this.lblOlvidarContrasena_Click);
            this.lblOlvidarContrasena.MouseLeave += new System.EventHandler(this.lblOlvidarContrasena_MouseLeave);
            this.lblOlvidarContrasena.MouseHover += new System.EventHandler(this.lblOlvidarContrasena_MouseHover);
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
            this.btnRegresar.TabIndex = 7;
            this.btnRegresar.UseVisualStyleBackColor = false;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Proyecto_Final.Properties.Resources.urp;
            this.pictureBox1.Location = new System.Drawing.Point(101, 32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(84, 72);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // btnIngresar
            // 
            this.btnIngresar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(135)))), ((int)(((byte)(49)))));
            this.btnIngresar.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(135)))), ((int)(((byte)(49)))));
            this.btnIngresar.BorderColor = System.Drawing.Color.Gold;
            this.btnIngresar.BorderRadius = 20;
            this.btnIngresar.BorderSize = 0;
            this.btnIngresar.FlatAppearance.BorderSize = 0;
            this.btnIngresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIngresar.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresar.ForeColor = System.Drawing.Color.White;
            this.btnIngresar.Location = new System.Drawing.Point(184, 316);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(207, 53);
            this.btnIngresar.TabIndex = 4;
            this.btnIngresar.Text = "INGRESAR";
            this.btnIngresar.TextColor = System.Drawing.Color.White;
            this.btnIngresar.UseVisualStyleBackColor = false;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // txtCodigo
            // 
            this.txtCodigo.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodigo.Location = new System.Drawing.Point(306, 154);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(177, 30);
            this.txtCodigo.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(193, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(274, 74);
            this.label2.TabIndex = 0;
            this.label2.Text = "Ingrese su cuenta\r\ninstitucional";
            // 
            // txtContrasena
            // 
            this.txtContrasena.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContrasena.Location = new System.Drawing.Point(306, 217);
            this.txtContrasena.Name = "txtContrasena";
            this.txtContrasena.PasswordChar = '•';
            this.txtContrasena.Size = new System.Drawing.Size(177, 30);
            this.txtContrasena.TabIndex = 2;
            // 
            // lblContrasena
            // 
            this.lblContrasena.AutoSize = true;
            this.lblContrasena.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContrasena.Location = new System.Drawing.Point(96, 220);
            this.lblContrasena.Name = "lblContrasena";
            this.lblContrasena.Size = new System.Drawing.Size(119, 21);
            this.lblContrasena.TabIndex = 1;
            this.lblContrasena.Text = "Contraseña:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(96, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 21);
            this.label5.TabIndex = 1;
            this.label5.Text = "Código:";
            // 
            // AlumnoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(135)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(599, 422);
            this.Controls.Add(this.panel2);
            this.Name = "AlumnoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ingreso de alumno";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private NewControls.NewButton btnIngresar;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtContrasena;
        private System.Windows.Forms.Label lblContrasena;
        private System.Windows.Forms.Label label5;
        private NewControls.BotonCircular btnRegresar;
        private System.Windows.Forms.Label lblOlvidarContrasena;
    }
}