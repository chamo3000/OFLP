
namespace OFLP.Vistas
{
    partial class FrmSexo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSexo));
            this.pnlConfiguracionSexo = new System.Windows.Forms.Panel();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BtnActualizarSexo = new System.Windows.Forms.Button();
            this.BtnEliminarSexo = new System.Windows.Forms.Button();
            this.BtnAgregarSexo = new System.Windows.Forms.Button();
            this.BtnLimpiarSexo = new System.Windows.Forms.Button();
            this.BtnBuscarSexo = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtBuscarSexo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_Sexo = new System.Windows.Forms.Label();
            this.lblDescripcionSexo = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DtgSexo = new System.Windows.Forms.DataGridView();
            this.idferia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sexo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlConfiguracionSexo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DtgSexo)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlConfiguracionSexo
            // 
            this.pnlConfiguracionSexo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pnlConfiguracionSexo.Controls.Add(this.picLogo);
            this.pnlConfiguracionSexo.Controls.Add(this.groupBox2);
            this.pnlConfiguracionSexo.Controls.Add(this.BtnLimpiarSexo);
            this.pnlConfiguracionSexo.Controls.Add(this.BtnBuscarSexo);
            this.pnlConfiguracionSexo.Controls.Add(this.label2);
            this.pnlConfiguracionSexo.Controls.Add(this.TxtBuscarSexo);
            this.pnlConfiguracionSexo.Controls.Add(this.label4);
            this.pnlConfiguracionSexo.Controls.Add(this.lbl_Sexo);
            this.pnlConfiguracionSexo.Controls.Add(this.lblDescripcionSexo);
            this.pnlConfiguracionSexo.Controls.Add(this.label8);
            this.pnlConfiguracionSexo.Controls.Add(this.label1);
            this.pnlConfiguracionSexo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlConfiguracionSexo.Location = new System.Drawing.Point(0, 0);
            this.pnlConfiguracionSexo.Name = "pnlConfiguracionSexo";
            this.pnlConfiguracionSexo.Size = new System.Drawing.Size(976, 238);
            this.pnlConfiguracionSexo.TabIndex = 45;
            // 
            // picLogo
            // 
            this.picLogo.BackColor = System.Drawing.Color.White;
            this.picLogo.Image = ((System.Drawing.Image)(resources.GetObject("picLogo.Image")));
            this.picLogo.Location = new System.Drawing.Point(960, 66);
            this.picLogo.Margin = new System.Windows.Forms.Padding(2);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(211, 148);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogo.TabIndex = 44;
            this.picLogo.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BtnActualizarSexo);
            this.groupBox2.Controls.Add(this.BtnEliminarSexo);
            this.groupBox2.Controls.Add(this.BtnAgregarSexo);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(694, 68);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(211, 148);
            this.groupBox2.TabIndex = 33;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Configuración Sexo";
            // 
            // BtnActualizarSexo
            // 
            this.BtnActualizarSexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnActualizarSexo.ForeColor = System.Drawing.Color.Black;
            this.BtnActualizarSexo.Location = new System.Drawing.Point(16, 62);
            this.BtnActualizarSexo.Name = "BtnActualizarSexo";
            this.BtnActualizarSexo.Size = new System.Drawing.Size(181, 26);
            this.BtnActualizarSexo.TabIndex = 14;
            this.BtnActualizarSexo.Text = "Actualizar Sexo";
            this.BtnActualizarSexo.UseVisualStyleBackColor = true;
            this.BtnActualizarSexo.Click += new System.EventHandler(this.BtnActualizarSexo_Click);
            // 
            // BtnEliminarSexo
            // 
            this.BtnEliminarSexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEliminarSexo.ForeColor = System.Drawing.Color.Black;
            this.BtnEliminarSexo.Location = new System.Drawing.Point(16, 94);
            this.BtnEliminarSexo.Name = "BtnEliminarSexo";
            this.BtnEliminarSexo.Size = new System.Drawing.Size(181, 26);
            this.BtnEliminarSexo.TabIndex = 14;
            this.BtnEliminarSexo.Text = "Eliminar Sexo";
            this.BtnEliminarSexo.UseVisualStyleBackColor = true;
            this.BtnEliminarSexo.Click += new System.EventHandler(this.BtnEliminarSexo_Click);
            // 
            // BtnAgregarSexo
            // 
            this.BtnAgregarSexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAgregarSexo.ForeColor = System.Drawing.Color.Black;
            this.BtnAgregarSexo.Location = new System.Drawing.Point(16, 30);
            this.BtnAgregarSexo.Name = "BtnAgregarSexo";
            this.BtnAgregarSexo.Size = new System.Drawing.Size(181, 26);
            this.BtnAgregarSexo.TabIndex = 14;
            this.BtnAgregarSexo.Text = "Agregar Sexo";
            this.BtnAgregarSexo.UseVisualStyleBackColor = true;
            this.BtnAgregarSexo.Click += new System.EventHandler(this.BtnAgregarSexo_Click);
            // 
            // BtnLimpiarSexo
            // 
            this.BtnLimpiarSexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLimpiarSexo.Location = new System.Drawing.Point(502, 125);
            this.BtnLimpiarSexo.Name = "BtnLimpiarSexo";
            this.BtnLimpiarSexo.Size = new System.Drawing.Size(86, 23);
            this.BtnLimpiarSexo.TabIndex = 32;
            this.BtnLimpiarSexo.Text = "Limpiar";
            this.BtnLimpiarSexo.UseVisualStyleBackColor = true;
            this.BtnLimpiarSexo.Click += new System.EventHandler(this.BtnLimpiarSexo_Click);
            // 
            // BtnBuscarSexo
            // 
            this.BtnBuscarSexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBuscarSexo.Location = new System.Drawing.Point(411, 125);
            this.BtnBuscarSexo.Name = "BtnBuscarSexo";
            this.BtnBuscarSexo.Size = new System.Drawing.Size(86, 23);
            this.BtnBuscarSexo.TabIndex = 31;
            this.BtnBuscarSexo.Text = "Buscar";
            this.BtnBuscarSexo.UseVisualStyleBackColor = true;
            this.BtnBuscarSexo.Click += new System.EventHandler(this.BtnBuscarSexo_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(439, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 20);
            this.label2.TabIndex = 30;
            this.label2.Text = "Buscar  Sexo";
            // 
            // TxtBuscarSexo
            // 
            this.TxtBuscarSexo.Location = new System.Drawing.Point(411, 94);
            this.TxtBuscarSexo.Name = "TxtBuscarSexo";
            this.TxtBuscarSexo.Size = new System.Drawing.Size(177, 20);
            this.TxtBuscarSexo.TabIndex = 29;
            this.TxtBuscarSexo.TextChanged += new System.EventHandler(this.TxtBuscarSexo_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(12, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(335, 29);
            this.label4.TabIndex = 28;
            this.label4.Text = "Modulo Configuracion Sexo";
            // 
            // lbl_Sexo
            // 
            this.lbl_Sexo.AutoSize = true;
            this.lbl_Sexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Sexo.ForeColor = System.Drawing.Color.White;
            this.lbl_Sexo.Location = new System.Drawing.Point(173, 83);
            this.lbl_Sexo.Name = "lbl_Sexo";
            this.lbl_Sexo.Size = new System.Drawing.Size(0, 20);
            this.lbl_Sexo.TabIndex = 27;
            // 
            // lblDescripcionSexo
            // 
            this.lblDescripcionSexo.AutoSize = true;
            this.lblDescripcionSexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcionSexo.ForeColor = System.Drawing.Color.White;
            this.lblDescripcionSexo.Location = new System.Drawing.Point(173, 108);
            this.lblDescripcionSexo.Name = "lblDescripcionSexo";
            this.lblDescripcionSexo.Size = new System.Drawing.Size(0, 20);
            this.lblDescripcionSexo.TabIndex = 26;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(13, 109);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(108, 20);
            this.label8.TabIndex = 22;
            this.label8.Text = "Descripcion:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(13, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 20);
            this.label1.TabIndex = 19;
            this.label1.Text = "Sexo:";
            // 
            // DtgSexo
            // 
            this.DtgSexo.AllowUserToAddRows = false;
            this.DtgSexo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtgSexo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idferia,
            this.sexo,
            this.descripcion});
            this.DtgSexo.Dock = System.Windows.Forms.DockStyle.Top;
            this.DtgSexo.Location = new System.Drawing.Point(0, 238);
            this.DtgSexo.Name = "DtgSexo";
            this.DtgSexo.ReadOnly = true;
            this.DtgSexo.RowHeadersWidth = 51;
            this.DtgSexo.Size = new System.Drawing.Size(976, 154);
            this.DtgSexo.TabIndex = 46;
            this.DtgSexo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DtgSexo_CellClick);
            // 
            // idferia
            // 
            this.idferia.HeaderText = "ID";
            this.idferia.MinimumWidth = 6;
            this.idferia.Name = "idferia";
            this.idferia.ReadOnly = true;
            this.idferia.Width = 125;
            // 
            // sexo
            // 
            this.sexo.HeaderText = "SEXO";
            this.sexo.MinimumWidth = 6;
            this.sexo.Name = "sexo";
            this.sexo.ReadOnly = true;
            this.sexo.Width = 125;
            // 
            // descripcion
            // 
            this.descripcion.HeaderText = "DESCRIPCION";
            this.descripcion.MinimumWidth = 6;
            this.descripcion.Name = "descripcion";
            this.descripcion.ReadOnly = true;
            this.descripcion.Width = 125;
            // 
            // FrmSexo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(976, 388);
            this.Controls.Add(this.DtgSexo);
            this.Controls.Add(this.pnlConfiguracionSexo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmSexo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmSexo";
            this.Load += new System.EventHandler(this.FrmSexo_Load);
            this.pnlConfiguracionSexo.ResumeLayout(false);
            this.pnlConfiguracionSexo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DtgSexo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlConfiguracionSexo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button BtnActualizarSexo;
        private System.Windows.Forms.Button BtnEliminarSexo;
        private System.Windows.Forms.Button BtnAgregarSexo;
        private System.Windows.Forms.Button BtnLimpiarSexo;
        private System.Windows.Forms.Button BtnBuscarSexo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtBuscarSexo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_Sexo;
        private System.Windows.Forms.Label lblDescripcionSexo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.DataGridView DtgSexo;
        private System.Windows.Forms.DataGridViewTextBoxColumn idferia;
        private System.Windows.Forms.DataGridViewTextBoxColumn sexo;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
        private System.Windows.Forms.PictureBox picLogo;
    }
}