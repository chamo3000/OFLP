
namespace OFLP.Vistas
{
    partial class FrmAgregarGanado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAgregarGanado));
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.BtnAceptarInsertar = new System.Windows.Forms.Button();
            this.pnlBarraTitulo = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.lblAddUser = new System.Windows.Forms.Label();
            this.TxtInsertarClase = new System.Windows.Forms.TextBox();
            this.TxtInsertarGanado = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtInsertarDescripcion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlBarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelar.Location = new System.Drawing.Point(254, 233);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(136, 23);
            this.BtnCancelar.TabIndex = 49;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // BtnAceptarInsertar
            // 
            this.BtnAceptarInsertar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAceptarInsertar.Location = new System.Drawing.Point(86, 233);
            this.BtnAceptarInsertar.Name = "BtnAceptarInsertar";
            this.BtnAceptarInsertar.Size = new System.Drawing.Size(136, 23);
            this.BtnAceptarInsertar.TabIndex = 48;
            this.BtnAceptarInsertar.Text = "Aceptar";
            this.BtnAceptarInsertar.UseVisualStyleBackColor = true;
            this.BtnAceptarInsertar.Click += new System.EventHandler(this.BtnAceptarInsertar_Click);
            // 
            // pnlBarraTitulo
            // 
            this.pnlBarraTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pnlBarraTitulo.Controls.Add(this.pictureBox1);
            this.pnlBarraTitulo.Controls.Add(this.pictureBox4);
            this.pnlBarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBarraTitulo.Location = new System.Drawing.Point(0, 0);
            this.pnlBarraTitulo.Name = "pnlBarraTitulo";
            this.pnlBarraTitulo.Size = new System.Drawing.Size(434, 33);
            this.pnlBarraTitulo.TabIndex = 47;
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
            this.pictureBox4.TabIndex = 2;
            this.pictureBox4.TabStop = false;
            // 
            // lblAddUser
            // 
            this.lblAddUser.AutoSize = true;
            this.lblAddUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddUser.ForeColor = System.Drawing.Color.White;
            this.lblAddUser.Location = new System.Drawing.Point(152, 57);
            this.lblAddUser.Name = "lblAddUser";
            this.lblAddUser.Size = new System.Drawing.Size(164, 24);
            this.lblAddUser.TabIndex = 46;
            this.lblAddUser.Text = "Agregar Ganado";
            this.lblAddUser.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // TxtInsertarClase
            // 
            this.TxtInsertarClase.Location = new System.Drawing.Point(132, 132);
            this.TxtInsertarClase.Name = "TxtInsertarClase";
            this.TxtInsertarClase.Size = new System.Drawing.Size(240, 20);
            this.TxtInsertarClase.TabIndex = 45;
            this.TxtInsertarClase.TextChanged += new System.EventHandler(this.TxtInsertarClase_TextChanged);
            // 
            // TxtInsertarGanado
            // 
            this.TxtInsertarGanado.Location = new System.Drawing.Point(132, 94);
            this.TxtInsertarGanado.MaxLength = 1;
            this.TxtInsertarGanado.Name = "TxtInsertarGanado";
            this.TxtInsertarGanado.Size = new System.Drawing.Size(240, 20);
            this.TxtInsertarGanado.TabIndex = 44;
            this.TxtInsertarGanado.TextChanged += new System.EventHandler(this.TxtInsertarGanado_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(68, 133);
            this.label3.Margin = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 16);
            this.label3.TabIndex = 43;
            this.label3.Text = "Clase:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(20, 94);
            this.label2.Margin = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 16);
            this.label2.TabIndex = 42;
            this.label2.Text = "Clase Ganado:";
            // 
            // TxtInsertarDescripcion
            // 
            this.TxtInsertarDescripcion.Location = new System.Drawing.Point(132, 169);
            this.TxtInsertarDescripcion.Name = "TxtInsertarDescripcion";
            this.TxtInsertarDescripcion.Size = new System.Drawing.Size(240, 20);
            this.TxtInsertarDescripcion.TabIndex = 51;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(33, 171);
            this.label1.Margin = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 16);
            this.label1.TabIndex = 50;
            this.label1.Text = "Descripcion:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox1.Image = global::OFLP.Properties.Resources.FACTBYA_Icono;
            this.pictureBox1.Location = new System.Drawing.Point(341, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(93, 33);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 44;
            this.pictureBox1.TabStop = false;
            // 
            // FrmAgregarGanado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(434, 297);
            this.Controls.Add(this.TxtInsertarDescripcion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnAceptarInsertar);
            this.Controls.Add(this.pnlBarraTitulo);
            this.Controls.Add(this.lblAddUser);
            this.Controls.Add(this.TxtInsertarClase);
            this.Controls.Add(this.TxtInsertarGanado);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmAgregarGanado";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAgregarGanado";
            this.pnlBarraTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Button BtnAceptarInsertar;
        private System.Windows.Forms.Panel pnlBarraTitulo;
        private System.Windows.Forms.Label lblAddUser;
        public System.Windows.Forms.TextBox TxtInsertarClase;
        public System.Windows.Forms.TextBox TxtInsertarGanado;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox TxtInsertarDescripcion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}