
namespace OFLP.Vistas
{
    partial class FrmActualizaSexo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmActualizaSexo));
            this.pnlBarraTitulo = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.TxtActualizarDescripcion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.BtnAceptarActualizar = new System.Windows.Forms.Button();
            this.lblAddUser = new System.Windows.Forms.Label();
            this.TxtActualizarSexo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlBarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlBarraTitulo
            // 
            this.pnlBarraTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pnlBarraTitulo.Controls.Add(this.pictureBox1);
            this.pnlBarraTitulo.Controls.Add(this.pictureBox4);
            this.pnlBarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBarraTitulo.Location = new System.Drawing.Point(0, 0);
            this.pnlBarraTitulo.Name = "pnlBarraTitulo";
            this.pnlBarraTitulo.Size = new System.Drawing.Size(440, 33);
            this.pnlBarraTitulo.TabIndex = 79;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.White;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(2, 2);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(37, 31);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 80;
            this.pictureBox4.TabStop = false;
            // 
            // TxtActualizarDescripcion
            // 
            this.TxtActualizarDescripcion.Location = new System.Drawing.Point(111, 165);
            this.TxtActualizarDescripcion.Name = "TxtActualizarDescripcion";
            this.TxtActualizarDescripcion.Size = new System.Drawing.Size(240, 20);
            this.TxtActualizarDescripcion.TabIndex = 78;
            this.TxtActualizarDescripcion.TextChanged += new System.EventHandler(this.TxtActualizarDescripcion_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 167);
            this.label1.Margin = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 16);
            this.label1.TabIndex = 77;
            this.label1.Text = "Descripcion:";
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelar.Location = new System.Drawing.Point(230, 236);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(136, 23);
            this.BtnCancelar.TabIndex = 76;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // BtnAceptarActualizar
            // 
            this.BtnAceptarActualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAceptarActualizar.Location = new System.Drawing.Point(65, 236);
            this.BtnAceptarActualizar.Name = "BtnAceptarActualizar";
            this.BtnAceptarActualizar.Size = new System.Drawing.Size(136, 23);
            this.BtnAceptarActualizar.TabIndex = 75;
            this.BtnAceptarActualizar.Text = "Aceptar";
            this.BtnAceptarActualizar.UseVisualStyleBackColor = true;
            this.BtnAceptarActualizar.Click += new System.EventHandler(this.BtnAceptarActualizar_Click);
            // 
            // lblAddUser
            // 
            this.lblAddUser.AutoSize = true;
            this.lblAddUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddUser.ForeColor = System.Drawing.Color.White;
            this.lblAddUser.Location = new System.Drawing.Point(131, 86);
            this.lblAddUser.Name = "lblAddUser";
            this.lblAddUser.Size = new System.Drawing.Size(155, 24);
            this.lblAddUser.TabIndex = 74;
            this.lblAddUser.Text = "Actualizar Sexo";
            this.lblAddUser.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // TxtActualizarSexo
            // 
            this.TxtActualizarSexo.Location = new System.Drawing.Point(111, 124);
            this.TxtActualizarSexo.MaxLength = 1;
            this.TxtActualizarSexo.Name = "TxtActualizarSexo";
            this.TxtActualizarSexo.Size = new System.Drawing.Size(240, 20);
            this.TxtActualizarSexo.TabIndex = 73;
            this.TxtActualizarSexo.TextChanged += new System.EventHandler(this.TxtActualizarSexo_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(57, 124);
            this.label2.Margin = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 16);
            this.label2.TabIndex = 72;
            this.label2.Text = "Sexo:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox1.Image = global::OFLP.Properties.Resources.FACTBYA_Icono;
            this.pictureBox1.Location = new System.Drawing.Point(347, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(93, 33);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 81;
            this.pictureBox1.TabStop = false;
            // 
            // FrmActualizaSexo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(440, 308);
            this.Controls.Add(this.pnlBarraTitulo);
            this.Controls.Add(this.TxtActualizarDescripcion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnAceptarActualizar);
            this.Controls.Add(this.lblAddUser);
            this.Controls.Add(this.TxtActualizarSexo);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmActualizaSexo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmActualizaSexo";
            this.Load += new System.EventHandler(this.FrmActualizarSexo_Load);
            this.pnlBarraTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlBarraTitulo;
        public System.Windows.Forms.TextBox TxtActualizarDescripcion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Label lblAddUser;
        public System.Windows.Forms.TextBox TxtActualizarSexo;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Button BtnAceptarActualizar;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}