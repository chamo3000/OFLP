namespace OFLP.Vistas
{
    partial class frmAgregarHacienda
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAgregarHacienda));
            this.pnlBarraTitulo = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.txtxtMunicipioHacienda = new System.Windows.Forms.TextBox();
            this.txtNombreHacienda = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptaAgregarHacienda = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblAddUser = new System.Windows.Forms.Label();
            this.cmbDueñoHacienda = new System.Windows.Forms.ComboBox();
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
            this.pnlBarraTitulo.Size = new System.Drawing.Size(466, 33);
            this.pnlBarraTitulo.TabIndex = 14;
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
            this.pictureBox4.TabIndex = 2;
            this.pictureBox4.TabStop = false;
            // 
            // txtxtMunicipioHacienda
            // 
            this.txtxtMunicipioHacienda.Location = new System.Drawing.Point(186, 120);
            this.txtxtMunicipioHacienda.Name = "txtxtMunicipioHacienda";
            this.txtxtMunicipioHacienda.Size = new System.Drawing.Size(240, 20);
            this.txtxtMunicipioHacienda.TabIndex = 23;
            this.txtxtMunicipioHacienda.TextChanged += new System.EventHandler(this.txtxtMunicipioHacienda_TextChanged);
            // 
            // txtNombreHacienda
            // 
            this.txtNombreHacienda.Location = new System.Drawing.Point(186, 80);
            this.txtNombreHacienda.Name = "txtNombreHacienda";
            this.txtNombreHacienda.Size = new System.Drawing.Size(240, 20);
            this.txtNombreHacienda.TabIndex = 22;
            this.txtNombreHacienda.TextChanged += new System.EventHandler(this.txtNombreHacienda_TextChanged);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(290, 212);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(136, 23);
            this.btnCancelar.TabIndex = 21;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptaAgregarHacienda
            // 
            this.btnAceptaAgregarHacienda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptaAgregarHacienda.Location = new System.Drawing.Point(25, 212);
            this.btnAceptaAgregarHacienda.Name = "btnAceptaAgregarHacienda";
            this.btnAceptaAgregarHacienda.Size = new System.Drawing.Size(136, 23);
            this.btnAceptaAgregarHacienda.TabIndex = 20;
            this.btnAceptaAgregarHacienda.Text = "Aceptar";
            this.btnAceptaAgregarHacienda.UseVisualStyleBackColor = true;
            this.btnAceptaAgregarHacienda.Click += new System.EventHandler(this.BtnAceptaAgregarHacienda_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(25, 160);
            this.label4.Margin = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 16);
            this.label4.TabIndex = 18;
            this.label4.Text = "Dueño";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(25, 120);
            this.label3.Margin = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 16);
            this.label3.TabIndex = 17;
            this.label3.Text = "Municipio";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(25, 80);
            this.label2.Margin = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 16);
            this.label2.TabIndex = 16;
            this.label2.Text = "Nombre Hacienda";
            // 
            // lblAddUser
            // 
            this.lblAddUser.AutoSize = true;
            this.lblAddUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddUser.ForeColor = System.Drawing.Color.White;
            this.lblAddUser.Location = new System.Drawing.Point(122, 42);
            this.lblAddUser.Name = "lblAddUser";
            this.lblAddUser.Size = new System.Drawing.Size(246, 24);
            this.lblAddUser.TabIndex = 15;
            this.lblAddUser.Text = "Agregar Nueva Hacienda";
            this.lblAddUser.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // cmbDueñoHacienda
            // 
            this.cmbDueñoHacienda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDueñoHacienda.FormattingEnabled = true;
            this.cmbDueñoHacienda.Items.AddRange(new object[] {
            "SELECCIONE UNA OPCION"});
            this.cmbDueñoHacienda.Location = new System.Drawing.Point(186, 154);
            this.cmbDueñoHacienda.Name = "cmbDueñoHacienda";
            this.cmbDueñoHacienda.Size = new System.Drawing.Size(240, 21);
            this.cmbDueñoHacienda.TabIndex = 24;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox1.Image = global::OFLP.Properties.Resources.FACTBYA_Icono;
            this.pictureBox1.Location = new System.Drawing.Point(373, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(93, 33);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 44;
            this.pictureBox1.TabStop = false;
            // 
            // frmAgregarHacienda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(466, 251);
            this.Controls.Add(this.cmbDueñoHacienda);
            this.Controls.Add(this.txtxtMunicipioHacienda);
            this.Controls.Add(this.txtNombreHacienda);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptaAgregarHacienda);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblAddUser);
            this.Controls.Add(this.pnlBarraTitulo);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAgregarHacienda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAgregarHacienda";
            this.Load += new System.EventHandler(this.frmAgregarHacienda_Load);
            this.pnlBarraTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlBarraTitulo;
        private System.Windows.Forms.TextBox txtxtMunicipioHacienda;
        private System.Windows.Forms.TextBox txtNombreHacienda;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptaAgregarHacienda;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblAddUser;
        private System.Windows.Forms.ComboBox cmbDueñoHacienda;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}