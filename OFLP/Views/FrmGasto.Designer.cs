namespace OFLP.Views
{
    partial class FrmGasto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmGasto));
            this.pnlContenedorGasto = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.btnTerminarGuardar = new System.Windows.Forms.Button();
            this.grbGasto = new System.Windows.Forms.GroupBox();
            this.TxtObservaciones = new System.Windows.Forms.TextBox();
            this.TxtOtros = new System.Windows.Forms.TextBox();
            this.TxtAnticipos = new System.Windows.Forms.TextBox();
            this.TxtVacunas = new System.Windows.Forms.TextBox();
            this.TxtComiGordo = new System.Windows.Forms.TextBox();
            this.txtComiFlaco = new System.Windows.Forms.TextBox();
            this.TxtRecibida = new System.Windows.Forms.TextBox();
            this.txtBaños = new System.Windows.Forms.TextBox();
            this.TxtTranposte = new System.Windows.Forms.TextBox();
            this.TxtFeriaBascula = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlBarraTitulo = new System.Windows.Forms.Panel();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pnlContenedorGasto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.grbGasto.SuspendLayout();
            this.pnlBarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlContenedorGasto
            // 
            this.pnlContenedorGasto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pnlContenedorGasto.Controls.Add(this.pictureBox3);
            this.pnlContenedorGasto.Controls.Add(this.pictureBox2);
            this.pnlContenedorGasto.Controls.Add(this.BtnCancelar);
            this.pnlContenedorGasto.Controls.Add(this.btnTerminarGuardar);
            this.pnlContenedorGasto.Controls.Add(this.grbGasto);
            this.pnlContenedorGasto.Controls.Add(this.pnlBarraTitulo);
            this.pnlContenedorGasto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContenedorGasto.Location = new System.Drawing.Point(0, 0);
            this.pnlContenedorGasto.Name = "pnlContenedorGasto";
            this.pnlContenedorGasto.Size = new System.Drawing.Size(800, 450);
            this.pnlContenedorGasto.TabIndex = 0;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::OFLP.Properties.Resources.cancelar;
            this.pictureBox3.Location = new System.Drawing.Point(558, 399);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(45, 39);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 53;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(40, 398);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(46, 40);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 52;
            this.pictureBox2.TabStop = false;
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.BtnCancelar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnCancelar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonShadow;
            this.BtnCancelar.FlatAppearance.BorderSize = 0;
            this.BtnCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.BtnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.BtnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelar.ForeColor = System.Drawing.Color.White;
            this.BtnCancelar.Location = new System.Drawing.Point(558, 399);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(221, 39);
            this.BtnCancelar.TabIndex = 50;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = false;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // btnTerminarGuardar
            // 
            this.btnTerminarGuardar.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnTerminarGuardar.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnTerminarGuardar.FlatAppearance.BorderSize = 0;
            this.btnTerminarGuardar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btnTerminarGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnTerminarGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTerminarGuardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTerminarGuardar.ForeColor = System.Drawing.Color.White;
            this.btnTerminarGuardar.Location = new System.Drawing.Point(39, 399);
            this.btnTerminarGuardar.Name = "btnTerminarGuardar";
            this.btnTerminarGuardar.Size = new System.Drawing.Size(221, 39);
            this.btnTerminarGuardar.TabIndex = 51;
            this.btnTerminarGuardar.Text = "Terminar";
            this.btnTerminarGuardar.UseVisualStyleBackColor = false;
            this.btnTerminarGuardar.Click += new System.EventHandler(this.BtnTerminarGuardar_Click);
            // 
            // grbGasto
            // 
            this.grbGasto.Controls.Add(this.TxtObservaciones);
            this.grbGasto.Controls.Add(this.TxtOtros);
            this.grbGasto.Controls.Add(this.TxtAnticipos);
            this.grbGasto.Controls.Add(this.TxtVacunas);
            this.grbGasto.Controls.Add(this.TxtComiGordo);
            this.grbGasto.Controls.Add(this.txtComiFlaco);
            this.grbGasto.Controls.Add(this.TxtRecibida);
            this.grbGasto.Controls.Add(this.txtBaños);
            this.grbGasto.Controls.Add(this.TxtTranposte);
            this.grbGasto.Controls.Add(this.TxtFeriaBascula);
            this.grbGasto.Controls.Add(this.label10);
            this.grbGasto.Controls.Add(this.label9);
            this.grbGasto.Controls.Add(this.label8);
            this.grbGasto.Controls.Add(this.label7);
            this.grbGasto.Controls.Add(this.label4);
            this.grbGasto.Controls.Add(this.label6);
            this.grbGasto.Controls.Add(this.label3);
            this.grbGasto.Controls.Add(this.label5);
            this.grbGasto.Controls.Add(this.label2);
            this.grbGasto.Controls.Add(this.label1);
            this.grbGasto.Dock = System.Windows.Forms.DockStyle.Top;
            this.grbGasto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbGasto.ForeColor = System.Drawing.SystemColors.Window;
            this.grbGasto.Location = new System.Drawing.Point(0, 33);
            this.grbGasto.Name = "grbGasto";
            this.grbGasto.Size = new System.Drawing.Size(800, 222);
            this.grbGasto.TabIndex = 49;
            this.grbGasto.TabStop = false;
            this.grbGasto.Text = "GASTO";
            // 
            // TxtObservaciones
            // 
            this.TxtObservaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtObservaciones.Location = new System.Drawing.Point(530, 122);
            this.TxtObservaciones.Multiline = true;
            this.TxtObservaciones.Name = "TxtObservaciones";
            this.TxtObservaciones.Size = new System.Drawing.Size(231, 78);
            this.TxtObservaciones.TabIndex = 10;
            // 
            // TxtOtros
            // 
            this.TxtOtros.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtOtros.Location = new System.Drawing.Point(530, 85);
            this.TxtOtros.Name = "TxtOtros";
            this.TxtOtros.Size = new System.Drawing.Size(171, 22);
            this.TxtOtros.TabIndex = 9;
            // 
            // TxtAnticipos
            // 
            this.TxtAnticipos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtAnticipos.Location = new System.Drawing.Point(530, 54);
            this.TxtAnticipos.Name = "TxtAnticipos";
            this.TxtAnticipos.Size = new System.Drawing.Size(171, 22);
            this.TxtAnticipos.TabIndex = 8;
            // 
            // TxtVacunas
            // 
            this.TxtVacunas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtVacunas.Location = new System.Drawing.Point(530, 22);
            this.TxtVacunas.Name = "TxtVacunas";
            this.TxtVacunas.Size = new System.Drawing.Size(171, 22);
            this.TxtVacunas.TabIndex = 7;
            // 
            // TxtComiGordo
            // 
            this.TxtComiGordo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtComiGordo.Location = new System.Drawing.Point(160, 178);
            this.TxtComiGordo.Name = "TxtComiGordo";
            this.TxtComiGordo.Size = new System.Drawing.Size(171, 22);
            this.TxtComiGordo.TabIndex = 6;
            // 
            // txtComiFlaco
            // 
            this.txtComiFlaco.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtComiFlaco.Location = new System.Drawing.Point(160, 147);
            this.txtComiFlaco.Name = "txtComiFlaco";
            this.txtComiFlaco.Size = new System.Drawing.Size(171, 22);
            this.txtComiFlaco.TabIndex = 5;
            // 
            // TxtRecibida
            // 
            this.TxtRecibida.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtRecibida.Location = new System.Drawing.Point(160, 116);
            this.TxtRecibida.Name = "TxtRecibida";
            this.TxtRecibida.Size = new System.Drawing.Size(171, 22);
            this.TxtRecibida.TabIndex = 4;
            // 
            // txtBaños
            // 
            this.txtBaños.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBaños.Location = new System.Drawing.Point(160, 85);
            this.txtBaños.Name = "txtBaños";
            this.txtBaños.Size = new System.Drawing.Size(171, 22);
            this.txtBaños.TabIndex = 3;
            // 
            // TxtTranposte
            // 
            this.TxtTranposte.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTranposte.Location = new System.Drawing.Point(160, 54);
            this.TxtTranposte.Name = "TxtTranposte";
            this.TxtTranposte.Size = new System.Drawing.Size(171, 22);
            this.TxtTranposte.TabIndex = 2;
            // 
            // TxtFeriaBascula
            // 
            this.TxtFeriaBascula.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtFeriaBascula.Location = new System.Drawing.Point(160, 23);
            this.TxtFeriaBascula.Name = "TxtFeriaBascula";
            this.TxtFeriaBascula.Size = new System.Drawing.Size(171, 22);
            this.TxtFeriaBascula.TabIndex = 1;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(425, 122);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(99, 16);
            this.label10.TabIndex = 0;
            this.label10.Text = "Observaciones";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(463, 91);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 16);
            this.label9.TabIndex = 0;
            this.label9.Text = "Otros";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(464, 60);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(62, 16);
            this.label8.TabIndex = 0;
            this.label8.Text = "Anticipos";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(464, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 16);
            this.label7.TabIndex = 0;
            this.label7.Text = "Vacunas";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Recibida";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(13, 184);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(135, 16);
            this.label6.TabIndex = 0;
            this.label6.Text = "Comision Gan. Gordo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Baños";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Comision Gan. Flaco";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Transporte";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Feria o bascula";
            // 
            // pnlBarraTitulo
            // 
            this.pnlBarraTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pnlBarraTitulo.Controls.Add(this.pictureBox6);
            this.pnlBarraTitulo.Controls.Add(this.pictureBox4);
            this.pnlBarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBarraTitulo.Location = new System.Drawing.Point(0, 0);
            this.pnlBarraTitulo.Name = "pnlBarraTitulo";
            this.pnlBarraTitulo.Size = new System.Drawing.Size(800, 33);
            this.pnlBarraTitulo.TabIndex = 48;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox6.Image = global::OFLP.Properties.Resources.FACTBYA_Icono;
            this.pictureBox6.Location = new System.Drawing.Point(707, 0);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(93, 33);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 44;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.White;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(2, 0);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(37, 31);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 42;
            this.pictureBox4.TabStop = false;
            // 
            // FrmGasto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlContenedorGasto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmGasto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmGasto";
            this.pnlContenedorGasto.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.grbGasto.ResumeLayout(false);
            this.grbGasto.PerformLayout();
            this.pnlBarraTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlContenedorGasto;
        private System.Windows.Forms.Panel pnlBarraTitulo;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.GroupBox grbGasto;
        private System.Windows.Forms.TextBox TxtObservaciones;
        private System.Windows.Forms.TextBox TxtOtros;
        private System.Windows.Forms.TextBox TxtAnticipos;
        private System.Windows.Forms.TextBox TxtVacunas;
        private System.Windows.Forms.TextBox TxtComiGordo;
        private System.Windows.Forms.TextBox txtComiFlaco;
        private System.Windows.Forms.TextBox TxtRecibida;
        private System.Windows.Forms.TextBox txtBaños;
        private System.Windows.Forms.TextBox TxtTranposte;
        private System.Windows.Forms.TextBox TxtFeriaBascula;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Button btnTerminarGuardar;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}