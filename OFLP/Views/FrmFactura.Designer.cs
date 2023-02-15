
namespace OFLP.Vistas
{
    partial class FrmFactura
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.DtgFactura = new System.Windows.Forms.DataGridView();
            this.pnlConfiguraHacienda = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.PicAgregarFactura = new System.Windows.Forms.PictureBox();
            this.PicLimpiarBusquedaCliente = new System.Windows.Forms.PictureBox();
            this.PicBuscarCliente = new System.Windows.Forms.PictureBox();
            this.LblValorTotal = new System.Windows.Forms.Label();
            this.lblPropietario = new System.Windows.Forms.Label();
            this.LblNumFactura = new System.Windows.Forms.Label();
            this.LblReunion = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.PicLogo = new System.Windows.Forms.PictureBox();
            this.LblGasto = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBusquedaHacienda = new System.Windows.Forms.TextBox();
            this.lblconfigFactura = new System.Windows.Forms.Label();
            this.lblNombreHacienda = new System.Windows.Forms.Label();
            this.lblMunicipio = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.idFactura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reunion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.propietario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gastos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valortotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Modificar = new System.Windows.Forms.DataGridViewImageColumn();
            this.Eliminar = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DtgFactura)).BeginInit();
            this.pnlConfiguraHacienda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicAgregarFactura)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicLimpiarBusquedaCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicBuscarCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.DtgFactura);
            this.panel1.Controls.Add(this.pnlConfiguraHacienda);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1182, 450);
            this.panel1.TabIndex = 0;
            // 
            // DtgFactura
            // 
            this.DtgFactura.AllowUserToAddRows = false;
            this.DtgFactura.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DtgFactura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtgFactura.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idFactura,
            this.reunion,
            this.propietario,
            this.Gastos,
            this.valortotal,
            this.Modificar,
            this.Eliminar});
            this.DtgFactura.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DtgFactura.Location = new System.Drawing.Point(0, 342);
            this.DtgFactura.Name = "DtgFactura";
            this.DtgFactura.RowHeadersVisible = false;
            this.DtgFactura.Size = new System.Drawing.Size(1182, 108);
            this.DtgFactura.TabIndex = 7;
            this.DtgFactura.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DtgFactura_CellClick);
            // 
            // pnlConfiguraHacienda
            // 
            this.pnlConfiguraHacienda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pnlConfiguraHacienda.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlConfiguraHacienda.Controls.Add(this.label13);
            this.pnlConfiguraHacienda.Controls.Add(this.PicAgregarFactura);
            this.pnlConfiguraHacienda.Controls.Add(this.PicLimpiarBusquedaCliente);
            this.pnlConfiguraHacienda.Controls.Add(this.PicBuscarCliente);
            this.pnlConfiguraHacienda.Controls.Add(this.LblValorTotal);
            this.pnlConfiguraHacienda.Controls.Add(this.lblPropietario);
            this.pnlConfiguraHacienda.Controls.Add(this.LblNumFactura);
            this.pnlConfiguraHacienda.Controls.Add(this.LblReunion);
            this.pnlConfiguraHacienda.Controls.Add(this.label12);
            this.pnlConfiguraHacienda.Controls.Add(this.PicLogo);
            this.pnlConfiguraHacienda.Controls.Add(this.LblGasto);
            this.pnlConfiguraHacienda.Controls.Add(this.label5);
            this.pnlConfiguraHacienda.Controls.Add(this.txtBusquedaHacienda);
            this.pnlConfiguraHacienda.Controls.Add(this.lblconfigFactura);
            this.pnlConfiguraHacienda.Controls.Add(this.lblNombreHacienda);
            this.pnlConfiguraHacienda.Controls.Add(this.lblMunicipio);
            this.pnlConfiguraHacienda.Controls.Add(this.label4);
            this.pnlConfiguraHacienda.Controls.Add(this.label3);
            this.pnlConfiguraHacienda.Controls.Add(this.label2);
            this.pnlConfiguraHacienda.Controls.Add(this.label1);
            this.pnlConfiguraHacienda.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlConfiguraHacienda.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlConfiguraHacienda.Location = new System.Drawing.Point(0, 0);
            this.pnlConfiguraHacienda.Name = "pnlConfiguraHacienda";
            this.pnlConfiguraHacienda.Size = new System.Drawing.Size(1182, 342);
            this.pnlConfiguraHacienda.TabIndex = 6;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(499, 219);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(140, 20);
            this.label13.TabIndex = 56;
            this.label13.Text = "Agregar Factura";
            // 
            // PicAgregarFactura
            // 
            this.PicAgregarFactura.Image = global::OFLP.Properties.Resources.Agregar;
            this.PicAgregarFactura.Location = new System.Drawing.Point(639, 202);
            this.PicAgregarFactura.Name = "PicAgregarFactura";
            this.PicAgregarFactura.Size = new System.Drawing.Size(77, 37);
            this.PicAgregarFactura.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PicAgregarFactura.TabIndex = 55;
            this.PicAgregarFactura.TabStop = false;
            this.PicAgregarFactura.Click += new System.EventHandler(this.PicAgregarFactura_Click);
            // 
            // PicLimpiarBusquedaCliente
            // 
            this.PicLimpiarBusquedaCliente.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PicLimpiarBusquedaCliente.Image = global::OFLP.Properties.Resources._2376996;
            this.PicLimpiarBusquedaCliente.Location = new System.Drawing.Point(798, 287);
            this.PicLimpiarBusquedaCliente.Name = "PicLimpiarBusquedaCliente";
            this.PicLimpiarBusquedaCliente.Size = new System.Drawing.Size(48, 27);
            this.PicLimpiarBusquedaCliente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PicLimpiarBusquedaCliente.TabIndex = 54;
            this.PicLimpiarBusquedaCliente.TabStop = false;
            // 
            // PicBuscarCliente
            // 
            this.PicBuscarCliente.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PicBuscarCliente.Image = global::OFLP.Properties.Resources._639375;
            this.PicBuscarCliente.Location = new System.Drawing.Point(753, 287);
            this.PicBuscarCliente.Name = "PicBuscarCliente";
            this.PicBuscarCliente.Size = new System.Drawing.Size(37, 27);
            this.PicBuscarCliente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PicBuscarCliente.TabIndex = 53;
            this.PicBuscarCliente.TabStop = false;
            // 
            // LblValorTotal
            // 
            this.LblValorTotal.AutoSize = true;
            this.LblValorTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblValorTotal.ForeColor = System.Drawing.Color.White;
            this.LblValorTotal.Location = new System.Drawing.Point(233, 308);
            this.LblValorTotal.Name = "LblValorTotal";
            this.LblValorTotal.Size = new System.Drawing.Size(59, 20);
            this.LblValorTotal.TabIndex = 52;
            this.LblValorTotal.Text = "11111";
            // 
            // lblPropietario
            // 
            this.lblPropietario.AutoSize = true;
            this.lblPropietario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPropietario.ForeColor = System.Drawing.Color.White;
            this.lblPropietario.Location = new System.Drawing.Point(233, 96);
            this.lblPropietario.Name = "lblPropietario";
            this.lblPropietario.Size = new System.Drawing.Size(49, 20);
            this.lblPropietario.TabIndex = 51;
            this.lblPropietario.Text = "1111";
            // 
            // LblNumFactura
            // 
            this.LblNumFactura.AutoSize = true;
            this.LblNumFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNumFactura.ForeColor = System.Drawing.Color.White;
            this.LblNumFactura.Location = new System.Drawing.Point(233, 49);
            this.LblNumFactura.Name = "LblNumFactura";
            this.LblNumFactura.Size = new System.Drawing.Size(39, 20);
            this.LblNumFactura.TabIndex = 49;
            this.LblNumFactura.Text = "111";
            // 
            // LblReunion
            // 
            this.LblReunion.AutoSize = true;
            this.LblReunion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblReunion.ForeColor = System.Drawing.Color.White;
            this.LblReunion.Location = new System.Drawing.Point(233, 72);
            this.LblReunion.Name = "LblReunion";
            this.LblReunion.Size = new System.Drawing.Size(59, 20);
            this.LblReunion.TabIndex = 48;
            this.LblReunion.Text = "11111";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(11, 308);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(101, 20);
            this.label12.TabIndex = 46;
            this.label12.Text = "Valor Total:";
            // 
            // PicLogo
            // 
            this.PicLogo.BackColor = System.Drawing.Color.White;
            this.PicLogo.Image = global::OFLP.Properties.Resources.FACTBYA;
            this.PicLogo.Location = new System.Drawing.Point(638, 10);
            this.PicLogo.Margin = new System.Windows.Forms.Padding(2);
            this.PicLogo.Name = "PicLogo";
            this.PicLogo.Size = new System.Drawing.Size(211, 148);
            this.PicLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PicLogo.TabIndex = 45;
            this.PicLogo.TabStop = false;
            // 
            // LblGasto
            // 
            this.LblGasto.AutoSize = true;
            this.LblGasto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblGasto.ForeColor = System.Drawing.Color.White;
            this.LblGasto.Location = new System.Drawing.Point(233, 122);
            this.LblGasto.Name = "LblGasto";
            this.LblGasto.Size = new System.Drawing.Size(39, 20);
            this.LblGasto.TabIndex = 18;
            this.LblGasto.Text = "111";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(499, 294);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Buscar";
            // 
            // txtBusquedaHacienda
            // 
            this.txtBusquedaHacienda.Location = new System.Drawing.Point(570, 294);
            this.txtBusquedaHacienda.Name = "txtBusquedaHacienda";
            this.txtBusquedaHacienda.Size = new System.Drawing.Size(177, 20);
            this.txtBusquedaHacienda.TabIndex = 11;
            // 
            // lblconfigFactura
            // 
            this.lblconfigFactura.AutoSize = true;
            this.lblconfigFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblconfigFactura.ForeColor = System.Drawing.Color.White;
            this.lblconfigFactura.Location = new System.Drawing.Point(11, 11);
            this.lblconfigFactura.Name = "lblconfigFactura";
            this.lblconfigFactura.Size = new System.Drawing.Size(363, 29);
            this.lblconfigFactura.TabIndex = 6;
            this.lblconfigFactura.Text = "Modulo Configuracion Factura";
            // 
            // lblNombreHacienda
            // 
            this.lblNombreHacienda.AutoSize = true;
            this.lblNombreHacienda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreHacienda.ForeColor = System.Drawing.Color.White;
            this.lblNombreHacienda.Location = new System.Drawing.Point(172, 55);
            this.lblNombreHacienda.Name = "lblNombreHacienda";
            this.lblNombreHacienda.Size = new System.Drawing.Size(0, 20);
            this.lblNombreHacienda.TabIndex = 5;
            // 
            // lblMunicipio
            // 
            this.lblMunicipio.AutoSize = true;
            this.lblMunicipio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMunicipio.ForeColor = System.Drawing.Color.White;
            this.lblMunicipio.Location = new System.Drawing.Point(172, 80);
            this.lblMunicipio.Name = "lblMunicipio";
            this.lblMunicipio.Size = new System.Drawing.Size(0, 20);
            this.lblMunicipio.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(12, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Propietario:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(12, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Reunión:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Gastos";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Número Fatura:";
            // 
            // idFactura
            // 
            this.idFactura.HeaderText = "NUMERO FACTURA";
            this.idFactura.Name = "idFactura";
            this.idFactura.ReadOnly = true;
            this.idFactura.Width = 122;
            // 
            // reunion
            // 
            this.reunion.HeaderText = "REUNION";
            this.reunion.Name = "reunion";
            this.reunion.ReadOnly = true;
            this.reunion.Width = 82;
            // 
            // propietario
            // 
            this.propietario.HeaderText = "PROPIETARIO";
            this.propietario.Name = "propietario";
            this.propietario.ReadOnly = true;
            this.propietario.Width = 105;
            // 
            // Gastos
            // 
            dataGridViewCellStyle1.Format = "0,000";
            dataGridViewCellStyle1.NullValue = "0";
            this.Gastos.DefaultCellStyle = dataGridViewCellStyle1;
            this.Gastos.HeaderText = "GASTOS";
            this.Gastos.Name = "Gastos";
            this.Gastos.ReadOnly = true;
            this.Gastos.Width = 76;
            // 
            // valortotal
            // 
            this.valortotal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle2.Format = "0,000";
            dataGridViewCellStyle2.NullValue = "0";
            this.valortotal.DefaultCellStyle = dataGridViewCellStyle2;
            this.valortotal.HeaderText = "VALOR TOTAL";
            this.valortotal.Name = "valortotal";
            this.valortotal.ReadOnly = true;
            this.valortotal.Width = 97;
            // 
            // Modificar
            // 
            this.Modificar.HeaderText = "MODIFICAR";
            this.Modificar.Image = global::OFLP.Properties.Resources.edit;
            this.Modificar.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Modificar.Name = "Modificar";
            this.Modificar.ReadOnly = true;
            this.Modificar.Width = 72;
            // 
            // Eliminar
            // 
            this.Eliminar.HeaderText = "ELIMINAR";
            this.Eliminar.Image = global::OFLP.Properties.Resources.eliminar;
            this.Eliminar.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.ReadOnly = true;
            this.Eliminar.Width = 64;
            // 
            // FrmFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 450);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmFactura";
            this.Text = "FrmFactura";
            this.Load += new System.EventHandler(this.FrmFactura_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DtgFactura)).EndInit();
            this.pnlConfiguraHacienda.ResumeLayout(false);
            this.pnlConfiguraHacienda.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicAgregarFactura)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicLimpiarBusquedaCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicBuscarCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlConfiguraHacienda;
        private System.Windows.Forms.Label LblGasto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBusquedaHacienda;
        private System.Windows.Forms.Label lblconfigFactura;
        private System.Windows.Forms.Label lblNombreHacienda;
        private System.Windows.Forms.Label lblMunicipio;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox PicLogo;
        public System.Windows.Forms.DataGridView DtgFactura;
        private System.Windows.Forms.Label lblPropietario;
        private System.Windows.Forms.Label LblNumFactura;
        private System.Windows.Forms.Label LblReunion;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label LblValorTotal;
        private System.Windows.Forms.PictureBox PicLimpiarBusquedaCliente;
        private System.Windows.Forms.PictureBox PicBuscarCliente;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.PictureBox PicAgregarFactura;
        private System.Windows.Forms.DataGridViewTextBoxColumn idFactura;
        private System.Windows.Forms.DataGridViewTextBoxColumn reunion;
        private System.Windows.Forms.DataGridViewTextBoxColumn propietario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gastos;
        private System.Windows.Forms.DataGridViewTextBoxColumn valortotal;
        private System.Windows.Forms.DataGridViewImageColumn Modificar;
        private System.Windows.Forms.DataGridViewImageColumn Eliminar;
    }
}