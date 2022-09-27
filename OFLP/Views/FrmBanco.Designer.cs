
namespace OFLP.Vistas
{
    partial class FrmBanco
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
            this.pnlConfiguracionBanco = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnActualizaBanco = new System.Windows.Forms.Button();
            this.btnEliminarBanco = new System.Windows.Forms.Button();
            this.btnAgregarBanco = new System.Windows.Forms.Button();
            this.btnLimpiarBusquedaBanco = new System.Windows.Forms.Button();
            this.btnBuscarBanco = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBusquedaBanco = new System.Windows.Forms.TextBox();
            this.lblconfigBanco = new System.Windows.Forms.Label();
            this.lblNombreBanco = new System.Windows.Forms.Label();
            this.lblDescripcionBanco = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombrebanco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idbanco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DtgBanco = new System.Windows.Forms.DataGridView();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.pnlConfiguracionBanco.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DtgBanco)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlConfiguracionBanco
            // 
            this.pnlConfiguracionBanco.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pnlConfiguracionBanco.Controls.Add(this.picLogo);
            this.pnlConfiguracionBanco.Controls.Add(this.groupBox1);
            this.pnlConfiguracionBanco.Controls.Add(this.btnLimpiarBusquedaBanco);
            this.pnlConfiguracionBanco.Controls.Add(this.btnBuscarBanco);
            this.pnlConfiguracionBanco.Controls.Add(this.label5);
            this.pnlConfiguracionBanco.Controls.Add(this.txtBusquedaBanco);
            this.pnlConfiguracionBanco.Controls.Add(this.lblconfigBanco);
            this.pnlConfiguracionBanco.Controls.Add(this.lblNombreBanco);
            this.pnlConfiguracionBanco.Controls.Add(this.lblDescripcionBanco);
            this.pnlConfiguracionBanco.Controls.Add(this.label3);
            this.pnlConfiguracionBanco.Controls.Add(this.label1);
            this.pnlConfiguracionBanco.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlConfiguracionBanco.Location = new System.Drawing.Point(0, 0);
            this.pnlConfiguracionBanco.Name = "pnlConfiguracionBanco";
            this.pnlConfiguracionBanco.Size = new System.Drawing.Size(941, 238);
            this.pnlConfiguracionBanco.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnActualizaBanco);
            this.groupBox1.Controls.Add(this.btnEliminarBanco);
            this.groupBox1.Controls.Add(this.btnAgregarBanco);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(694, 68);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(211, 148);
            this.groupBox1.TabIndex = 33;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Configuración Propietarios";
            // 
            // btnActualizaBanco
            // 
            this.btnActualizaBanco.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizaBanco.ForeColor = System.Drawing.Color.Black;
            this.btnActualizaBanco.Location = new System.Drawing.Point(16, 62);
            this.btnActualizaBanco.Name = "btnActualizaBanco";
            this.btnActualizaBanco.Size = new System.Drawing.Size(181, 26);
            this.btnActualizaBanco.TabIndex = 14;
            this.btnActualizaBanco.Text = "Actualiza Banco";
            this.btnActualizaBanco.UseVisualStyleBackColor = true;
            this.btnActualizaBanco.Click += new System.EventHandler(this.BtnActualizaBanco_Click);
            // 
            // btnEliminarBanco
            // 
            this.btnEliminarBanco.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarBanco.ForeColor = System.Drawing.Color.Black;
            this.btnEliminarBanco.Location = new System.Drawing.Point(16, 94);
            this.btnEliminarBanco.Name = "btnEliminarBanco";
            this.btnEliminarBanco.Size = new System.Drawing.Size(181, 26);
            this.btnEliminarBanco.TabIndex = 14;
            this.btnEliminarBanco.Text = "Eliminar Banco";
            this.btnEliminarBanco.UseVisualStyleBackColor = true;
            this.btnEliminarBanco.Click += new System.EventHandler(this.btnEliminarBanco_Click);
            // 
            // btnAgregarBanco
            // 
            this.btnAgregarBanco.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarBanco.ForeColor = System.Drawing.Color.Black;
            this.btnAgregarBanco.Location = new System.Drawing.Point(16, 30);
            this.btnAgregarBanco.Name = "btnAgregarBanco";
            this.btnAgregarBanco.Size = new System.Drawing.Size(181, 26);
            this.btnAgregarBanco.TabIndex = 14;
            this.btnAgregarBanco.Text = "Agregar Banco";
            this.btnAgregarBanco.UseVisualStyleBackColor = true;
            this.btnAgregarBanco.Click += new System.EventHandler(this.btnAgregarBanco_Click);
            // 
            // btnLimpiarBusquedaBanco
            // 
            this.btnLimpiarBusquedaBanco.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiarBusquedaBanco.Location = new System.Drawing.Point(502, 125);
            this.btnLimpiarBusquedaBanco.Name = "btnLimpiarBusquedaBanco";
            this.btnLimpiarBusquedaBanco.Size = new System.Drawing.Size(86, 23);
            this.btnLimpiarBusquedaBanco.TabIndex = 32;
            this.btnLimpiarBusquedaBanco.Text = "Limpiar";
            this.btnLimpiarBusquedaBanco.UseVisualStyleBackColor = true;
            this.btnLimpiarBusquedaBanco.Click += new System.EventHandler(this.btnLimpiarBusquedaBanco_Click);
            // 
            // btnBuscarBanco
            // 
            this.btnBuscarBanco.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarBanco.Location = new System.Drawing.Point(412, 125);
            this.btnBuscarBanco.Name = "btnBuscarBanco";
            this.btnBuscarBanco.Size = new System.Drawing.Size(86, 23);
            this.btnBuscarBanco.TabIndex = 31;
            this.btnBuscarBanco.Text = "Buscar";
            this.btnBuscarBanco.UseVisualStyleBackColor = true;
            this.btnBuscarBanco.Click += new System.EventHandler(this.btnBuscarBanco_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(408, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 20);
            this.label5.TabIndex = 30;
            this.label5.Text = "Buscar Banco";
            // 
            // txtBusquedaBanco
            // 
            this.txtBusquedaBanco.Location = new System.Drawing.Point(411, 94);
            this.txtBusquedaBanco.Name = "txtBusquedaBanco";
            this.txtBusquedaBanco.Size = new System.Drawing.Size(177, 20);
            this.txtBusquedaBanco.TabIndex = 29;
            this.txtBusquedaBanco.TextChanged += new System.EventHandler(this.txtBusquedaBanco_TextChanged);
            // 
            // lblconfigBanco
            // 
            this.lblconfigBanco.AutoSize = true;
            this.lblconfigBanco.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblconfigBanco.ForeColor = System.Drawing.Color.White;
            this.lblconfigBanco.Location = new System.Drawing.Point(12, 15);
            this.lblconfigBanco.Name = "lblconfigBanco";
            this.lblconfigBanco.Size = new System.Drawing.Size(362, 29);
            this.lblconfigBanco.TabIndex = 28;
            this.lblconfigBanco.Text = "Modulo Configuracion Bancos";
            // 
            // lblNombreBanco
            // 
            this.lblNombreBanco.AutoSize = true;
            this.lblNombreBanco.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreBanco.ForeColor = System.Drawing.Color.White;
            this.lblNombreBanco.Location = new System.Drawing.Point(173, 83);
            this.lblNombreBanco.Name = "lblNombreBanco";
            this.lblNombreBanco.Size = new System.Drawing.Size(0, 20);
            this.lblNombreBanco.TabIndex = 27;
            // 
            // lblDescripcionBanco
            // 
            this.lblDescripcionBanco.AutoSize = true;
            this.lblDescripcionBanco.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcionBanco.ForeColor = System.Drawing.Color.White;
            this.lblDescripcionBanco.Location = new System.Drawing.Point(173, 108);
            this.lblDescripcionBanco.Name = "lblDescripcionBanco";
            this.lblDescripcionBanco.Size = new System.Drawing.Size(0, 20);
            this.lblDescripcionBanco.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(13, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 20);
            this.label3.TabIndex = 22;
            this.label3.Text = "Descripcion Banco:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(13, 84);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 20);
            this.label1.TabIndex = 19;
            this.label1.Text = "Nombre Banco:";
            // 
            // descripcion
            // 
            this.descripcion.HeaderText = "DESCRIPCION";
            this.descripcion.MinimumWidth = 6;
            this.descripcion.Name = "descripcion";
            this.descripcion.ReadOnly = true;
            this.descripcion.Width = 125;
            // 
            // nombrebanco
            // 
            this.nombrebanco.HeaderText = "NOMBRE_BANCO";
            this.nombrebanco.MinimumWidth = 6;
            this.nombrebanco.Name = "nombrebanco";
            this.nombrebanco.ReadOnly = true;
            this.nombrebanco.Width = 125;
            // 
            // idbanco
            // 
            this.idbanco.HeaderText = "ID_BANCO";
            this.idbanco.MinimumWidth = 6;
            this.idbanco.Name = "idbanco";
            this.idbanco.ReadOnly = true;
            this.idbanco.Width = 125;
            // 
            // DtgBanco
            // 
            this.DtgBanco.AllowUserToAddRows = false;
            this.DtgBanco.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtgBanco.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idbanco,
            this.nombrebanco,
            this.descripcion});
            this.DtgBanco.Dock = System.Windows.Forms.DockStyle.Top;
            this.DtgBanco.Location = new System.Drawing.Point(0, 238);
            this.DtgBanco.Name = "DtgBanco";
            this.DtgBanco.ReadOnly = true;
            this.DtgBanco.RowHeadersWidth = 51;
            this.DtgBanco.Size = new System.Drawing.Size(941, 219);
            this.DtgBanco.TabIndex = 1;
            this.DtgBanco.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DtgBanco_CellClick);
            // 
            // picLogo
            // 
            this.picLogo.BackColor = System.Drawing.Color.White;
            this.picLogo.Image = global::OFLP.Properties.Resources.FACTBYA;
            this.picLogo.Location = new System.Drawing.Point(960, 68);
            this.picLogo.Margin = new System.Windows.Forms.Padding(2);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(211, 148);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogo.TabIndex = 45;
            this.picLogo.TabStop = false;
            // 
            // FrmBanco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(941, 450);
            this.Controls.Add(this.DtgBanco);
            this.Controls.Add(this.pnlConfiguracionBanco);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmBanco";
            this.Text = "FrmBanco";
            this.Load += new System.EventHandler(this.FrmBanco_Load);
            this.pnlConfiguracionBanco.ResumeLayout(false);
            this.pnlConfiguracionBanco.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DtgBanco)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlConfiguracionBanco;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnActualizaBanco;
        private System.Windows.Forms.Button btnEliminarBanco;
        private System.Windows.Forms.Button btnAgregarBanco;
        private System.Windows.Forms.Button btnLimpiarBusquedaBanco;
        private System.Windows.Forms.Button btnBuscarBanco;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBusquedaBanco;
        private System.Windows.Forms.Label lblconfigBanco;
        private System.Windows.Forms.Label lblNombreBanco;
        private System.Windows.Forms.Label lblDescripcionBanco;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombrebanco;
        private System.Windows.Forms.DataGridViewTextBoxColumn idbanco;
        private System.Windows.Forms.DataGridView DtgBanco;
        private System.Windows.Forms.PictureBox picLogo;
    }
}