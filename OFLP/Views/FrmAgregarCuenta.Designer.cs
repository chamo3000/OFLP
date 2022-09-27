
namespace OFLP.Vistas
{
    partial class FrmAgregarCuenta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAgregarCuenta));
            this.BtnCancelarBanco = new System.Windows.Forms.Button();
            this.BtnAceptaAgregarCuenta = new System.Windows.Forms.Button();
            this.TxtCiudad = new System.Windows.Forms.TextBox();
            this.TxtNumeroCuenta = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblAgregar_Banco = new System.Windows.Forms.Label();
            this.TxtComentario = new System.Windows.Forms.TextBox();
            this.TxtSucursal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbIdcliente = new System.Windows.Forms.ComboBox();
            this.cmbIdBanco = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pnlBarraTitulo = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlBarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnCancelarBanco
            // 
            this.BtnCancelarBanco.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCancelarBanco.Location = new System.Drawing.Point(234, 304);
            this.BtnCancelarBanco.Name = "BtnCancelarBanco";
            this.BtnCancelarBanco.Size = new System.Drawing.Size(136, 23);
            this.BtnCancelarBanco.TabIndex = 37;
            this.BtnCancelarBanco.Text = "Cancelar";
            this.BtnCancelarBanco.UseVisualStyleBackColor = true;
            this.BtnCancelarBanco.Click += new System.EventHandler(this.BtnCancelarBanco_Click);
            // 
            // BtnAceptaAgregarCuenta
            // 
            this.BtnAceptaAgregarCuenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAceptaAgregarCuenta.Location = new System.Drawing.Point(56, 304);
            this.BtnAceptaAgregarCuenta.Name = "BtnAceptaAgregarCuenta";
            this.BtnAceptaAgregarCuenta.Size = new System.Drawing.Size(136, 23);
            this.BtnAceptaAgregarCuenta.TabIndex = 36;
            this.BtnAceptaAgregarCuenta.Text = "Aceptar";
            this.BtnAceptaAgregarCuenta.UseVisualStyleBackColor = true;
            this.BtnAceptaAgregarCuenta.Click += new System.EventHandler(this.BtnAceptaAgregarCuenta_Click);
            // 
            // TxtCiudad
            // 
            this.TxtCiudad.Location = new System.Drawing.Point(130, 115);
            this.TxtCiudad.Name = "TxtCiudad";
            this.TxtCiudad.Size = new System.Drawing.Size(240, 20);
            this.TxtCiudad.TabIndex = 35;
            this.TxtCiudad.TextChanged += new System.EventHandler(this.TxtCiudad_TextChanged);
            // 
            // TxtNumeroCuenta
            // 
            this.TxtNumeroCuenta.Location = new System.Drawing.Point(130, 81);
            this.TxtNumeroCuenta.Name = "TxtNumeroCuenta";
            this.TxtNumeroCuenta.Size = new System.Drawing.Size(240, 20);
            this.TxtNumeroCuenta.TabIndex = 34;
            this.TxtNumeroCuenta.TextChanged += new System.EventHandler(this.TxtNumeroCuenta_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(60, 116);
            this.label3.Margin = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 16);
            this.label3.TabIndex = 33;
            this.label3.Text = "Ciudad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(6, 82);
            this.label2.Margin = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 16);
            this.label2.TabIndex = 32;
            this.label2.Text = "Numero Cuenta";
            // 
            // lblAgregar_Banco
            // 
            this.lblAgregar_Banco.AutoSize = true;
            this.lblAgregar_Banco.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgregar_Banco.ForeColor = System.Drawing.Color.White;
            this.lblAgregar_Banco.Location = new System.Drawing.Point(139, 47);
            this.lblAgregar_Banco.Name = "lblAgregar_Banco";
            this.lblAgregar_Banco.Size = new System.Drawing.Size(167, 24);
            this.lblAgregar_Banco.TabIndex = 31;
            this.lblAgregar_Banco.Text = "Agregar Cuentas";
            this.lblAgregar_Banco.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // TxtComentario
            // 
            this.TxtComentario.Location = new System.Drawing.Point(130, 181);
            this.TxtComentario.Name = "TxtComentario";
            this.TxtComentario.Size = new System.Drawing.Size(240, 20);
            this.TxtComentario.TabIndex = 41;
            // 
            // TxtSucursal
            // 
            this.TxtSucursal.Location = new System.Drawing.Point(130, 146);
            this.TxtSucursal.Name = "TxtSucursal";
            this.TxtSucursal.Size = new System.Drawing.Size(240, 20);
            this.TxtSucursal.TabIndex = 40;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(31, 185);
            this.label1.Margin = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 16);
            this.label1.TabIndex = 39;
            this.label1.Text = "Comentario";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(48, 150);
            this.label4.Margin = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 16);
            this.label4.TabIndex = 38;
            this.label4.Text = "Sucursal";
            // 
            // cmbIdcliente
            // 
            this.cmbIdcliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbIdcliente.FormattingEnabled = true;
            this.cmbIdcliente.Items.AddRange(new object[] {
            "SELECCIONE UN CLIENTE"});
            this.cmbIdcliente.Location = new System.Drawing.Point(130, 216);
            this.cmbIdcliente.Margin = new System.Windows.Forms.Padding(2);
            this.cmbIdcliente.Name = "cmbIdcliente";
            this.cmbIdcliente.Size = new System.Drawing.Size(240, 21);
            this.cmbIdcliente.TabIndex = 42;
            // 
            // cmbIdBanco
            // 
            this.cmbIdBanco.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbIdBanco.FormattingEnabled = true;
            this.cmbIdBanco.Items.AddRange(new object[] {
            "SELECCIONE UN BANCO"});
            this.cmbIdBanco.Location = new System.Drawing.Point(130, 251);
            this.cmbIdBanco.Margin = new System.Windows.Forms.Padding(2);
            this.cmbIdBanco.Name = "cmbIdBanco";
            this.cmbIdBanco.Size = new System.Drawing.Size(240, 21);
            this.cmbIdBanco.TabIndex = 43;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(48, 217);
            this.label5.Margin = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 16);
            this.label5.TabIndex = 44;
            this.label5.Text = "IdCliente";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(52, 252);
            this.label6.Margin = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 16);
            this.label6.TabIndex = 45;
            this.label6.Text = "IdBanco";
            // 
            // pnlBarraTitulo
            // 
            this.pnlBarraTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pnlBarraTitulo.Controls.Add(this.pictureBox1);
            this.pnlBarraTitulo.Controls.Add(this.pictureBox4);
            this.pnlBarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBarraTitulo.Location = new System.Drawing.Point(0, 0);
            this.pnlBarraTitulo.Name = "pnlBarraTitulo";
            this.pnlBarraTitulo.Size = new System.Drawing.Size(395, 33);
            this.pnlBarraTitulo.TabIndex = 46;
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
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox1.Image = global::OFLP.Properties.Resources.FACTBYA_Icono;
            this.pictureBox1.Location = new System.Drawing.Point(302, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(93, 33);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 44;
            this.pictureBox1.TabStop = false;
            // 
            // FrmAgregarCuenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(395, 344);
            this.Controls.Add(this.pnlBarraTitulo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbIdBanco);
            this.Controls.Add(this.cmbIdcliente);
            this.Controls.Add(this.TxtComentario);
            this.Controls.Add(this.TxtSucursal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BtnCancelarBanco);
            this.Controls.Add(this.BtnAceptaAgregarCuenta);
            this.Controls.Add(this.TxtCiudad);
            this.Controls.Add(this.TxtNumeroCuenta);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblAgregar_Banco);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmAgregarCuenta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAgregarCuenta";
            this.Load += new System.EventHandler(this.FrmAgregarCuenta_Load);
            this.pnlBarraTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnCancelarBanco;
        private System.Windows.Forms.Button BtnAceptaAgregarCuenta;
        private System.Windows.Forms.TextBox TxtCiudad;
        private System.Windows.Forms.TextBox TxtNumeroCuenta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblAgregar_Banco;
        private System.Windows.Forms.TextBox TxtComentario;
        private System.Windows.Forms.TextBox TxtSucursal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbIdcliente;
        private System.Windows.Forms.ComboBox cmbIdBanco;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel pnlBarraTitulo;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}