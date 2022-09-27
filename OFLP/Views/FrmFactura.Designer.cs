
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.DtgFactura = new System.Windows.Forms.DataGridView();
            this.idFactura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reunion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.propietario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clase = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.corral = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cabezas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sexo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comprador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kilos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valorkilo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valortotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iva = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlConfiguraHacienda = new System.Windows.Forms.Panel();
            this.LblValorTotal = new System.Windows.Forms.Label();
            this.LblComprador = new System.Windows.Forms.Label();
            this.LblKilos = new System.Windows.Forms.Label();
            this.lblPropietario = new System.Windows.Forms.Label();
            this.LblCabezas = new System.Windows.Forms.Label();
            this.LblNumFactura = new System.Windows.Forms.Label();
            this.LblReunion = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.PicLogo = new System.Windows.Forms.PictureBox();
            this.LblClase = new System.Windows.Forms.Label();
            this.LblValorKilo = new System.Windows.Forms.Label();
            this.LblCorral = new System.Windows.Forms.Label();
            this.LblSexo = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnActualizaHacienda = new System.Windows.Forms.Button();
            this.btnEliminarHacienda = new System.Windows.Forms.Button();
            this.BtnAgregarFactura = new System.Windows.Forms.Button();
            this.btnLimpiarBusquedaPropietario = new System.Windows.Forms.Button();
            this.btnBuscarHacienda = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBusquedaHacienda = new System.Windows.Forms.TextBox();
            this.lblconfigFactura = new System.Windows.Forms.Label();
            this.lblNombreHacienda = new System.Windows.Forms.Label();
            this.lblMunicipio = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DtgFactura)).BeginInit();
            this.pnlConfiguraHacienda.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicLogo)).BeginInit();
            this.groupBox1.SuspendLayout();
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
            this.fecha,
            this.propietario,
            this.clase,
            this.corral,
            this.cabezas,
            this.sexo,
            this.comprador,
            this.kilos,
            this.valorkilo,
            this.valortotal,
            this.iva});
            this.DtgFactura.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DtgFactura.Location = new System.Drawing.Point(0, 342);
            this.DtgFactura.Name = "DtgFactura";
            this.DtgFactura.Size = new System.Drawing.Size(1182, 108);
            this.DtgFactura.TabIndex = 7;
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
            // fecha
            // 
            this.fecha.HeaderText = "FECHA";
            this.fecha.Name = "fecha";
            this.fecha.ReadOnly = true;
            this.fecha.Width = 67;
            // 
            // propietario
            // 
            this.propietario.HeaderText = "PROPIETARIO";
            this.propietario.Name = "propietario";
            this.propietario.ReadOnly = true;
            this.propietario.Width = 105;
            // 
            // clase
            // 
            this.clase.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clase.HeaderText = "CLASE";
            this.clase.Name = "clase";
            this.clase.ReadOnly = true;
            this.clase.Width = 66;
            // 
            // corral
            // 
            this.corral.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.corral.HeaderText = "CORRAL";
            this.corral.Name = "corral";
            this.corral.ReadOnly = true;
            this.corral.Width = 76;
            // 
            // cabezas
            // 
            this.cabezas.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.cabezas.HeaderText = "CABEZAS";
            this.cabezas.Name = "cabezas";
            this.cabezas.ReadOnly = true;
            this.cabezas.Width = 81;
            // 
            // sexo
            // 
            this.sexo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.sexo.HeaderText = "SEXO";
            this.sexo.Name = "sexo";
            this.sexo.ReadOnly = true;
            this.sexo.Width = 61;
            // 
            // comprador
            // 
            this.comprador.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.comprador.HeaderText = "COMPRADOR";
            this.comprador.Name = "comprador";
            this.comprador.ReadOnly = true;
            this.comprador.Width = 102;
            // 
            // kilos
            // 
            this.kilos.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.kilos.HeaderText = "KILOS";
            this.kilos.Name = "kilos";
            this.kilos.ReadOnly = true;
            this.kilos.Width = 63;
            // 
            // valorkilo
            // 
            this.valorkilo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.valorkilo.HeaderText = "VALOR KILO";
            this.valorkilo.Name = "valorkilo";
            this.valorkilo.ReadOnly = true;
            this.valorkilo.Width = 88;
            // 
            // valortotal
            // 
            this.valortotal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.valortotal.HeaderText = "VALOR TOTAL";
            this.valortotal.Name = "valortotal";
            this.valortotal.ReadOnly = true;
            this.valortotal.Width = 97;
            // 
            // iva
            // 
            this.iva.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.iva.HeaderText = "IVA";
            this.iva.Name = "iva";
            this.iva.ReadOnly = true;
            this.iva.Visible = false;
            // 
            // pnlConfiguraHacienda
            // 
            this.pnlConfiguraHacienda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pnlConfiguraHacienda.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlConfiguraHacienda.Controls.Add(this.LblValorTotal);
            this.pnlConfiguraHacienda.Controls.Add(this.LblComprador);
            this.pnlConfiguraHacienda.Controls.Add(this.LblKilos);
            this.pnlConfiguraHacienda.Controls.Add(this.lblPropietario);
            this.pnlConfiguraHacienda.Controls.Add(this.LblCabezas);
            this.pnlConfiguraHacienda.Controls.Add(this.LblNumFactura);
            this.pnlConfiguraHacienda.Controls.Add(this.LblReunion);
            this.pnlConfiguraHacienda.Controls.Add(this.label18);
            this.pnlConfiguraHacienda.Controls.Add(this.label12);
            this.pnlConfiguraHacienda.Controls.Add(this.label11);
            this.pnlConfiguraHacienda.Controls.Add(this.label10);
            this.pnlConfiguraHacienda.Controls.Add(this.label9);
            this.pnlConfiguraHacienda.Controls.Add(this.label8);
            this.pnlConfiguraHacienda.Controls.Add(this.PicLogo);
            this.pnlConfiguraHacienda.Controls.Add(this.LblClase);
            this.pnlConfiguraHacienda.Controls.Add(this.LblValorKilo);
            this.pnlConfiguraHacienda.Controls.Add(this.LblCorral);
            this.pnlConfiguraHacienda.Controls.Add(this.LblSexo);
            this.pnlConfiguraHacienda.Controls.Add(this.groupBox1);
            this.pnlConfiguraHacienda.Controls.Add(this.btnLimpiarBusquedaPropietario);
            this.pnlConfiguraHacienda.Controls.Add(this.btnBuscarHacienda);
            this.pnlConfiguraHacienda.Controls.Add(this.label5);
            this.pnlConfiguraHacienda.Controls.Add(this.txtBusquedaHacienda);
            this.pnlConfiguraHacienda.Controls.Add(this.lblconfigFactura);
            this.pnlConfiguraHacienda.Controls.Add(this.lblNombreHacienda);
            this.pnlConfiguraHacienda.Controls.Add(this.lblMunicipio);
            this.pnlConfiguraHacienda.Controls.Add(this.label7);
            this.pnlConfiguraHacienda.Controls.Add(this.label6);
            this.pnlConfiguraHacienda.Controls.Add(this.label4);
            this.pnlConfiguraHacienda.Controls.Add(this.label14);
            this.pnlConfiguraHacienda.Controls.Add(this.label3);
            this.pnlConfiguraHacienda.Controls.Add(this.label2);
            this.pnlConfiguraHacienda.Controls.Add(this.lblFecha);
            this.pnlConfiguraHacienda.Controls.Add(this.label1);
            this.pnlConfiguraHacienda.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlConfiguraHacienda.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlConfiguraHacienda.Location = new System.Drawing.Point(0, 0);
            this.pnlConfiguraHacienda.Name = "pnlConfiguraHacienda";
            this.pnlConfiguraHacienda.Size = new System.Drawing.Size(1182, 342);
            this.pnlConfiguraHacienda.TabIndex = 6;
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
            // LblComprador
            // 
            this.LblComprador.AutoSize = true;
            this.LblComprador.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblComprador.ForeColor = System.Drawing.Color.White;
            this.LblComprador.Location = new System.Drawing.Point(233, 235);
            this.LblComprador.Name = "LblComprador";
            this.LblComprador.Size = new System.Drawing.Size(59, 20);
            this.LblComprador.TabIndex = 52;
            this.LblComprador.Text = "11111";
            // 
            // LblKilos
            // 
            this.LblKilos.AutoSize = true;
            this.LblKilos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblKilos.ForeColor = System.Drawing.Color.White;
            this.LblKilos.Location = new System.Drawing.Point(233, 258);
            this.LblKilos.Name = "LblKilos";
            this.LblKilos.Size = new System.Drawing.Size(49, 20);
            this.LblKilos.TabIndex = 50;
            this.LblKilos.Text = "1111";
            // 
            // lblPropietario
            // 
            this.lblPropietario.AutoSize = true;
            this.lblPropietario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPropietario.ForeColor = System.Drawing.Color.White;
            this.lblPropietario.Location = new System.Drawing.Point(233, 121);
            this.lblPropietario.Name = "lblPropietario";
            this.lblPropietario.Size = new System.Drawing.Size(49, 20);
            this.lblPropietario.TabIndex = 51;
            this.lblPropietario.Text = "1111";
            // 
            // LblCabezas
            // 
            this.LblCabezas.AutoSize = true;
            this.LblCabezas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCabezas.ForeColor = System.Drawing.Color.White;
            this.LblCabezas.Location = new System.Drawing.Point(233, 191);
            this.LblCabezas.Name = "LblCabezas";
            this.LblCabezas.Size = new System.Drawing.Size(49, 20);
            this.LblCabezas.TabIndex = 50;
            this.LblCabezas.Text = "1111";
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
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.White;
            this.label18.Location = new System.Drawing.Point(399, 149);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(0, 20);
            this.label18.TabIndex = 47;
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
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(11, 281);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(90, 20);
            this.label11.TabIndex = 46;
            this.label11.Text = "Valor Kilo:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(11, 258);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 20);
            this.label10.TabIndex = 46;
            this.label10.Text = "Kilos:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(12, 235);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(102, 20);
            this.label9.TabIndex = 46;
            this.label9.Text = "Comprador:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(12, 212);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 20);
            this.label8.TabIndex = 46;
            this.label8.Text = "Sexo:";
            // 
            // PicLogo
            // 
            this.PicLogo.BackColor = System.Drawing.Color.White;
            this.PicLogo.Image = global::OFLP.Properties.Resources.FACTBYA;
            this.PicLogo.Location = new System.Drawing.Point(960, 96);
            this.PicLogo.Margin = new System.Windows.Forms.Padding(2);
            this.PicLogo.Name = "PicLogo";
            this.PicLogo.Size = new System.Drawing.Size(211, 148);
            this.PicLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PicLogo.TabIndex = 45;
            this.PicLogo.TabStop = false;
            // 
            // LblClase
            // 
            this.LblClase.AutoSize = true;
            this.LblClase.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblClase.ForeColor = System.Drawing.Color.White;
            this.LblClase.Location = new System.Drawing.Point(233, 144);
            this.LblClase.Name = "LblClase";
            this.LblClase.Size = new System.Drawing.Size(39, 20);
            this.LblClase.TabIndex = 18;
            this.LblClase.Text = "111";
            // 
            // LblValorKilo
            // 
            this.LblValorKilo.AutoSize = true;
            this.LblValorKilo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblValorKilo.ForeColor = System.Drawing.Color.White;
            this.LblValorKilo.Location = new System.Drawing.Point(233, 281);
            this.LblValorKilo.Name = "LblValorKilo";
            this.LblValorKilo.Size = new System.Drawing.Size(39, 20);
            this.LblValorKilo.TabIndex = 16;
            this.LblValorKilo.Text = "111";
            // 
            // LblCorral
            // 
            this.LblCorral.AutoSize = true;
            this.LblCorral.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCorral.ForeColor = System.Drawing.Color.White;
            this.LblCorral.Location = new System.Drawing.Point(233, 169);
            this.LblCorral.Name = "LblCorral";
            this.LblCorral.Size = new System.Drawing.Size(39, 20);
            this.LblCorral.TabIndex = 17;
            this.LblCorral.Text = "111";
            // 
            // LblSexo
            // 
            this.LblSexo.AutoSize = true;
            this.LblSexo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSexo.ForeColor = System.Drawing.Color.White;
            this.LblSexo.Location = new System.Drawing.Point(233, 212);
            this.LblSexo.Name = "LblSexo";
            this.LblSexo.Size = new System.Drawing.Size(39, 20);
            this.LblSexo.TabIndex = 16;
            this.LblSexo.Text = "111";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnActualizaHacienda);
            this.groupBox1.Controls.Add(this.btnEliminarHacienda);
            this.groupBox1.Controls.Add(this.BtnAgregarFactura);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(650, 96);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(211, 148);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Configuración Factura";
            // 
            // btnActualizaHacienda
            // 
            this.btnActualizaHacienda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizaHacienda.ForeColor = System.Drawing.Color.Black;
            this.btnActualizaHacienda.Location = new System.Drawing.Point(16, 62);
            this.btnActualizaHacienda.Name = "btnActualizaHacienda";
            this.btnActualizaHacienda.Size = new System.Drawing.Size(181, 26);
            this.btnActualizaHacienda.TabIndex = 14;
            this.btnActualizaHacienda.Text = "Actualiza Factura";
            this.btnActualizaHacienda.UseVisualStyleBackColor = true;
            // 
            // btnEliminarHacienda
            // 
            this.btnEliminarHacienda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarHacienda.ForeColor = System.Drawing.Color.Black;
            this.btnEliminarHacienda.Location = new System.Drawing.Point(16, 94);
            this.btnEliminarHacienda.Name = "btnEliminarHacienda";
            this.btnEliminarHacienda.Size = new System.Drawing.Size(181, 26);
            this.btnEliminarHacienda.TabIndex = 14;
            this.btnEliminarHacienda.Text = "Eliminar Factura";
            this.btnEliminarHacienda.UseVisualStyleBackColor = true;
            this.btnEliminarHacienda.Click += new System.EventHandler(this.btnEliminarHacienda_Click);
            // 
            // BtnAgregarFactura
            // 
            this.BtnAgregarFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAgregarFactura.ForeColor = System.Drawing.Color.Black;
            this.BtnAgregarFactura.Location = new System.Drawing.Point(16, 30);
            this.BtnAgregarFactura.Name = "BtnAgregarFactura";
            this.BtnAgregarFactura.Size = new System.Drawing.Size(181, 26);
            this.BtnAgregarFactura.TabIndex = 14;
            this.BtnAgregarFactura.Text = "Agregar Factura";
            this.BtnAgregarFactura.UseVisualStyleBackColor = true;
            this.BtnAgregarFactura.Click += new System.EventHandler(this.BtnAgregarHacienda_Click);
            // 
            // btnLimpiarBusquedaPropietario
            // 
            this.btnLimpiarBusquedaPropietario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiarBusquedaPropietario.Location = new System.Drawing.Point(488, 142);
            this.btnLimpiarBusquedaPropietario.Name = "btnLimpiarBusquedaPropietario";
            this.btnLimpiarBusquedaPropietario.Size = new System.Drawing.Size(86, 23);
            this.btnLimpiarBusquedaPropietario.TabIndex = 13;
            this.btnLimpiarBusquedaPropietario.Text = "Limpiar";
            this.btnLimpiarBusquedaPropietario.UseVisualStyleBackColor = true;
            // 
            // btnBuscarHacienda
            // 
            this.btnBuscarHacienda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarHacienda.Location = new System.Drawing.Point(398, 142);
            this.btnBuscarHacienda.Name = "btnBuscarHacienda";
            this.btnBuscarHacienda.Size = new System.Drawing.Size(86, 23);
            this.btnBuscarHacienda.TabIndex = 13;
            this.btnBuscarHacienda.Text = "Buscar";
            this.btnBuscarHacienda.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(394, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Buscar Factura";
            // 
            // txtBusquedaHacienda
            // 
            this.txtBusquedaHacienda.Location = new System.Drawing.Point(397, 111);
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
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(12, 191);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 20);
            this.label7.TabIndex = 3;
            this.label7.Text = "Cabezas:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(12, 169);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 20);
            this.label6.TabIndex = 2;
            this.label6.Text = "Corral:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(12, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Propietario:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(12, 96);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(64, 20);
            this.label14.TabIndex = 2;
            this.label14.Text = "Fecha:";
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
            this.label2.Location = new System.Drawing.Point(12, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Clase:";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.ForeColor = System.Drawing.Color.White;
            this.lblFecha.Location = new System.Drawing.Point(233, 96);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(49, 20);
            this.lblFecha.TabIndex = 1;
            this.lblFecha.Text = "1111";
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
            ((System.ComponentModel.ISupportInitialize)(this.PicLogo)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnlConfiguraHacienda;
        private System.Windows.Forms.Label LblClase;
        private System.Windows.Forms.Label LblCorral;
        private System.Windows.Forms.Label LblSexo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnActualizaHacienda;
        private System.Windows.Forms.Button btnEliminarHacienda;
        private System.Windows.Forms.Button BtnAgregarFactura;
        private System.Windows.Forms.Button btnLimpiarBusquedaPropietario;
        private System.Windows.Forms.Button btnBuscarHacienda;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBusquedaHacienda;
        private System.Windows.Forms.Label lblconfigFactura;
        private System.Windows.Forms.Label lblNombreHacienda;
        private System.Windows.Forms.Label lblMunicipio;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox PicLogo;
        public System.Windows.Forms.DataGridView DtgFactura;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label LblComprador;
        private System.Windows.Forms.Label lblPropietario;
        private System.Windows.Forms.Label LblCabezas;
        private System.Windows.Forms.Label LblNumFactura;
        private System.Windows.Forms.Label LblReunion;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label LblValorTotal;
        private System.Windows.Forms.Label LblKilos;
        private System.Windows.Forms.Label LblValorKilo;
        private System.Windows.Forms.DataGridViewTextBoxColumn idFactura;
        private System.Windows.Forms.DataGridViewTextBoxColumn reunion;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn propietario;
        private System.Windows.Forms.DataGridViewTextBoxColumn clase;
        private System.Windows.Forms.DataGridViewTextBoxColumn corral;
        private System.Windows.Forms.DataGridViewTextBoxColumn cabezas;
        private System.Windows.Forms.DataGridViewTextBoxColumn sexo;
        private System.Windows.Forms.DataGridViewTextBoxColumn comprador;
        private System.Windows.Forms.DataGridViewTextBoxColumn kilos;
        private System.Windows.Forms.DataGridViewTextBoxColumn valorkilo;
        private System.Windows.Forms.DataGridViewTextBoxColumn valortotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn iva;
    }
}