
namespace OFLP.Vistas
{
    partial class FrmAgregarFactura
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAgregarFactura));
            this.panel1 = new System.Windows.Forms.Panel();
            this.DtgAgregaFactura = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iva = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valor_kilo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valor_total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.editar = new System.Windows.Forms.DataGridViewImageColumn();
            this.eliminar = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.PnlAgregar = new System.Windows.Forms.Panel();
            this.txtKilos = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.PicAgregar = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.GrpIva = new System.Windows.Forms.GroupBox();
            this.chkNoIva = new System.Windows.Forms.CheckBox();
            this.chkSiIva = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.TxtValorTotal = new System.Windows.Forms.TextBox();
            this.cmbClase = new System.Windows.Forms.ComboBox();
            this.txtValorKilo = new System.Windows.Forms.TextBox();
            this.cmbSexo = new System.Windows.Forms.ComboBox();
            this.txtCorral = new System.Windows.Forms.TextBox();
            this.txtCabezas = new System.Windows.Forms.TextBox();
            this.pnlBarraTitulo = new System.Windows.Forms.Panel();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.btnTerminarGuardar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.cmbHacienda = new System.Windows.Forms.ComboBox();
            this.CmbComprador = new System.Windows.Forms.ComboBox();
            this.cmbPropietario = new System.Windows.Forms.ComboBox();
            this.dtpicFechaFactura = new System.Windows.Forms.DateTimePicker();
            this.lblReunion = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblNumeroFact = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblMunicipio = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.clase = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.corral = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cabezas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sexo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comprador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kilo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DtgAgregaFactura)).BeginInit();
            this.panel2.SuspendLayout();
            this.PnlAgregar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicAgregar)).BeginInit();
            this.GrpIva.SuspendLayout();
            this.pnlBarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkGray;
            this.panel1.Controls.Add(this.DtgAgregaFactura);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(944, 551);
            this.panel1.TabIndex = 0;
            // 
            // DtgAgregaFactura
            // 
            this.DtgAgregaFactura.AllowUserToAddRows = false;
            this.DtgAgregaFactura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtgAgregaFactura.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn5,
            this.iva,
            this.valor_kilo,
            this.valor_total,
            this.editar,
            this.eliminar});
            this.DtgAgregaFactura.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.DtgAgregaFactura.Location = new System.Drawing.Point(0, 307);
            this.DtgAgregaFactura.Name = "DtgAgregaFactura";
            this.DtgAgregaFactura.Size = new System.Drawing.Size(944, 244);
            this.DtgAgregaFactura.TabIndex = 2;
            this.DtgAgregaFactura.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DtgAgregaFactura_CellClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn1.FillWeight = 50F;
            this.dataGridViewTextBoxColumn1.HeaderText = "CLASE";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 66;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn2.HeaderText = "CORRAL";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 76;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn3.HeaderText = "CABEZAS";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 81;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn4.HeaderText = "SEXO";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 61;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn6.HeaderText = "COMPRADOR";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 102;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn5.HeaderText = "KILO";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 56;
            // 
            // iva
            // 
            this.iva.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.iva.HeaderText = "IVA";
            this.iva.Name = "iva";
            this.iva.ReadOnly = true;
            this.iva.Visible = false;
            // 
            // valor_kilo
            // 
            this.valor_kilo.HeaderText = "VALOR KILO";
            this.valor_kilo.Name = "valor_kilo";
            // 
            // valor_total
            // 
            this.valor_total.HeaderText = "VALOR TOTAL";
            this.valor_total.Name = "valor_total";
            // 
            // editar
            // 
            this.editar.HeaderText = "EDITAR";
            this.editar.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.editar.Name = "editar";
            this.editar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.editar.Width = 52;
            // 
            // eliminar
            // 
            this.eliminar.HeaderText = "ELIMINAR";
            this.eliminar.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.eliminar.Name = "eliminar";
            this.eliminar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.eliminar.Width = 62;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel2.Controls.Add(this.PnlAgregar);
            this.panel2.Controls.Add(this.pnlBarraTitulo);
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.btnTerminarGuardar);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(944, 551);
            this.panel2.TabIndex = 1;
            // 
            // PnlAgregar
            // 
            this.PnlAgregar.Controls.Add(this.txtKilos);
            this.PnlAgregar.Controls.Add(this.label3);
            this.PnlAgregar.Controls.Add(this.label4);
            this.PnlAgregar.Controls.Add(this.label5);
            this.PnlAgregar.Controls.Add(this.PicAgregar);
            this.PnlAgregar.Controls.Add(this.label6);
            this.PnlAgregar.Controls.Add(this.label7);
            this.PnlAgregar.Controls.Add(this.label8);
            this.PnlAgregar.Controls.Add(this.GrpIva);
            this.PnlAgregar.Controls.Add(this.label9);
            this.PnlAgregar.Controls.Add(this.TxtValorTotal);
            this.PnlAgregar.Controls.Add(this.cmbClase);
            this.PnlAgregar.Controls.Add(this.txtValorKilo);
            this.PnlAgregar.Controls.Add(this.cmbSexo);
            this.PnlAgregar.Controls.Add(this.txtCorral);
            this.PnlAgregar.Controls.Add(this.txtCabezas);
            this.PnlAgregar.Location = new System.Drawing.Point(0, 192);
            this.PnlAgregar.Name = "PnlAgregar";
            this.PnlAgregar.Size = new System.Drawing.Size(876, 58);
            this.PnlAgregar.TabIndex = 48;
            // 
            // txtKilos
            // 
            this.txtKilos.Location = new System.Drawing.Point(402, 25);
            this.txtKilos.Name = "txtKilos";
            this.txtKilos.Size = new System.Drawing.Size(58, 20);
            this.txtKilos.TabIndex = 4;
            this.txtKilos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtKilos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtKilos_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(48, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Clase";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(194, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Corral";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(259, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "Cabezas";
            // 
            // PicAgregar
            // 
            this.PicAgregar.Image = global::OFLP.Properties.Resources.Agregar;
            this.PicAgregar.Location = new System.Drawing.Point(833, 14);
            this.PicAgregar.Name = "PicAgregar";
            this.PicAgregar.Size = new System.Drawing.Size(36, 33);
            this.PicAgregar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PicAgregar.TabIndex = 7;
            this.PicAgregar.TabStop = false;
            this.PicAgregar.Visible = false;
            this.PicAgregar.Click += new System.EventHandler(this.PictureBox1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(335, 3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 20);
            this.label6.TabIndex = 1;
            this.label6.Text = "Sexos";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(405, 3);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 20);
            this.label7.TabIndex = 1;
            this.label7.Text = "Kilos";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(463, 3);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(100, 20);
            this.label8.TabIndex = 1;
            this.label8.Text = "$ Valor Kilo";
            // 
            // GrpIva
            // 
            this.GrpIva.Controls.Add(this.chkNoIva);
            this.GrpIva.Controls.Add(this.chkSiIva);
            this.GrpIva.Enabled = false;
            this.GrpIva.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrpIva.ForeColor = System.Drawing.Color.White;
            this.GrpIva.Location = new System.Drawing.Point(737, 9);
            this.GrpIva.Name = "GrpIva";
            this.GrpIva.Size = new System.Drawing.Size(90, 38);
            this.GrpIva.TabIndex = 5;
            this.GrpIva.TabStop = false;
            this.GrpIva.Text = "IVA";
            // 
            // chkNoIva
            // 
            this.chkNoIva.AutoSize = true;
            this.chkNoIva.Checked = true;
            this.chkNoIva.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkNoIva.Location = new System.Drawing.Point(42, 16);
            this.chkNoIva.Name = "chkNoIva";
            this.chkNoIva.Size = new System.Drawing.Size(44, 17);
            this.chkNoIva.TabIndex = 1;
            this.chkNoIva.Text = "NO";
            this.chkNoIva.UseVisualStyleBackColor = true;
            this.chkNoIva.CheckedChanged += new System.EventHandler(this.ChkNoIva_CheckedChanged);
            // 
            // chkSiIva
            // 
            this.chkSiIva.AutoSize = true;
            this.chkSiIva.Location = new System.Drawing.Point(5, 16);
            this.chkSiIva.Name = "chkSiIva";
            this.chkSiIva.Size = new System.Drawing.Size(38, 17);
            this.chkSiIva.TabIndex = 0;
            this.chkSiIva.Text = "SI";
            this.chkSiIva.UseVisualStyleBackColor = true;
            this.chkSiIva.CheckedChanged += new System.EventHandler(this.ChkSiIva_CheckedChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(591, 2);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(116, 20);
            this.label9.TabIndex = 1;
            this.label9.Text = "$ Valor Total ";
            // 
            // TxtValorTotal
            // 
            this.TxtValorTotal.Location = new System.Drawing.Point(576, 24);
            this.TxtValorTotal.Name = "TxtValorTotal";
            this.TxtValorTotal.Size = new System.Drawing.Size(155, 20);
            this.TxtValorTotal.TabIndex = 4;
            this.TxtValorTotal.Text = "0";
            this.TxtValorTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // cmbClase
            // 
            this.cmbClase.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbClase.FormattingEnabled = true;
            this.cmbClase.Location = new System.Drawing.Point(14, 26);
            this.cmbClase.Name = "cmbClase";
            this.cmbClase.Size = new System.Drawing.Size(169, 21);
            this.cmbClase.TabIndex = 3;
            this.cmbClase.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CmbClase_KeyPress);
            // 
            // txtValorKilo
            // 
            this.txtValorKilo.Location = new System.Drawing.Point(471, 24);
            this.txtValorKilo.Name = "txtValorKilo";
            this.txtValorKilo.Size = new System.Drawing.Size(92, 20);
            this.txtValorKilo.TabIndex = 4;
            this.txtValorKilo.Text = "0";
            this.txtValorKilo.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtValorKilo.TextChanged += new System.EventHandler(this.TxtValorKilo_TextChanged);
            this.txtValorKilo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtValorKilo_KeyPress);
            // 
            // cmbSexo
            // 
            this.cmbSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSexo.FormattingEnabled = true;
            this.cmbSexo.Location = new System.Drawing.Point(338, 25);
            this.cmbSexo.Name = "cmbSexo";
            this.cmbSexo.Size = new System.Drawing.Size(55, 21);
            this.cmbSexo.TabIndex = 3;
            this.cmbSexo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CmbSexo_KeyPress);
            // 
            // txtCorral
            // 
            this.txtCorral.Location = new System.Drawing.Point(198, 26);
            this.txtCorral.Name = "txtCorral";
            this.txtCorral.Size = new System.Drawing.Size(53, 20);
            this.txtCorral.TabIndex = 4;
            this.txtCorral.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtCorral.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtCorral_KeyPress);
            // 
            // txtCabezas
            // 
            this.txtCabezas.Location = new System.Drawing.Point(264, 25);
            this.txtCabezas.Name = "txtCabezas";
            this.txtCabezas.Size = new System.Drawing.Size(58, 20);
            this.txtCabezas.TabIndex = 4;
            this.txtCabezas.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtCabezas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtCabezas_KeyPress);
            // 
            // pnlBarraTitulo
            // 
            this.pnlBarraTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.pnlBarraTitulo.Controls.Add(this.pictureBox6);
            this.pnlBarraTitulo.Controls.Add(this.pictureBox4);
            this.pnlBarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBarraTitulo.Location = new System.Drawing.Point(0, 0);
            this.pnlBarraTitulo.Name = "pnlBarraTitulo";
            this.pnlBarraTitulo.Size = new System.Drawing.Size(944, 33);
            this.pnlBarraTitulo.TabIndex = 47;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox6.Image = global::OFLP.Properties.Resources.FACTBYA_Icono;
            this.pictureBox6.Location = new System.Drawing.Point(851, 0);
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
            // pictureBox3
            // 
            this.pictureBox3.Image = global::OFLP.Properties.Resources.cancelar;
            this.pictureBox3.Location = new System.Drawing.Point(537, 259);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(45, 39);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 9;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(18, 258);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(46, 40);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 8;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Visible = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button2.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonShadow;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(537, 258);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(221, 39);
            this.button2.TabIndex = 6;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
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
            this.btnTerminarGuardar.Location = new System.Drawing.Point(18, 258);
            this.btnTerminarGuardar.Name = "btnTerminarGuardar";
            this.btnTerminarGuardar.Size = new System.Drawing.Size(221, 39);
            this.btnTerminarGuardar.TabIndex = 6;
            this.btnTerminarGuardar.Text = "Terminar";
            this.btnTerminarGuardar.UseVisualStyleBackColor = false;
            this.btnTerminarGuardar.Visible = false;
            this.btnTerminarGuardar.Click += new System.EventHandler(this.BtnTerminarGuardar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox5);
            this.groupBox1.Controls.Add(this.cmbHacienda);
            this.groupBox1.Controls.Add(this.CmbComprador);
            this.groupBox1.Controls.Add(this.cmbPropietario);
            this.groupBox1.Controls.Add(this.dtpicFechaFactura);
            this.groupBox1.Controls.Add(this.lblReunion);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.lblNumeroFact);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.lblMunicipio);
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(0, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(876, 151);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Agregar Factura";
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.White;
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(595, 49);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(99, 79);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 43;
            this.pictureBox5.TabStop = false;
            // 
            // cmbHacienda
            // 
            this.cmbHacienda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbHacienda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbHacienda.FormattingEnabled = true;
            this.cmbHacienda.Location = new System.Drawing.Point(119, 150);
            this.cmbHacienda.Name = "cmbHacienda";
            this.cmbHacienda.Size = new System.Drawing.Size(284, 28);
            this.cmbHacienda.TabIndex = 4;
            this.cmbHacienda.Visible = false;
            this.cmbHacienda.SelectedIndexChanged += new System.EventHandler(this.CmbHacienda_SelectedIndexChanged);
            this.cmbHacienda.SelectionChangeCommitted += new System.EventHandler(this.CmbHacienda_SelectionChangeCommitted);
            this.cmbHacienda.SelectedValueChanged += new System.EventHandler(this.CmbHacienda_SelectedValueChanged);
            this.cmbHacienda.TextChanged += new System.EventHandler(this.CmbHacienda_TextChanged);
            this.cmbHacienda.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CmbHacienda_KeyPress);
            // 
            // CmbComprador
            // 
            this.CmbComprador.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CmbComprador.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbComprador.FormattingEnabled = true;
            this.CmbComprador.ItemHeight = 20;
            this.CmbComprador.Location = new System.Drawing.Point(119, 111);
            this.CmbComprador.Name = "CmbComprador";
            this.CmbComprador.Size = new System.Drawing.Size(284, 28);
            this.CmbComprador.TabIndex = 3;
            this.CmbComprador.Visible = false;
            this.CmbComprador.SelectedIndexChanged += new System.EventHandler(this.CmbComprador_SelectedIndexChanged);
            this.CmbComprador.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CmbPropietario_KeyPress);
            // 
            // cmbPropietario
            // 
            this.cmbPropietario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPropietario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPropietario.FormattingEnabled = true;
            this.cmbPropietario.ItemHeight = 20;
            this.cmbPropietario.Location = new System.Drawing.Point(119, 77);
            this.cmbPropietario.Name = "cmbPropietario";
            this.cmbPropietario.Size = new System.Drawing.Size(284, 28);
            this.cmbPropietario.TabIndex = 3;
            this.cmbPropietario.SelectedIndexChanged += new System.EventHandler(this.CmbPropietario_SelectedIndexChanged);
            this.cmbPropietario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CmbPropietario_KeyPress);
            // 
            // dtpicFechaFactura
            // 
            this.dtpicFechaFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpicFechaFactura.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpicFechaFactura.Location = new System.Drawing.Point(119, 44);
            this.dtpicFechaFactura.Name = "dtpicFechaFactura";
            this.dtpicFechaFactura.Size = new System.Drawing.Size(150, 26);
            this.dtpicFechaFactura.TabIndex = 2;
            this.dtpicFechaFactura.ValueChanged += new System.EventHandler(this.DtpicFechaFactura_ValueChanged);
            this.dtpicFechaFactura.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DateTimePicker1_KeyPress);
            // 
            // lblReunion
            // 
            this.lblReunion.AutoSize = true;
            this.lblReunion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReunion.ForeColor = System.Drawing.Color.White;
            this.lblReunion.Location = new System.Drawing.Point(374, 47);
            this.lblReunion.Name = "lblReunion";
            this.lblReunion.Size = new System.Drawing.Size(22, 20);
            this.lblReunion.TabIndex = 1;
            this.lblReunion.Text = "R";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(13, 117);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(102, 20);
            this.label10.TabIndex = 1;
            this.label10.Text = "Comprador:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(14, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Fecha:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(13, 83);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(101, 20);
            this.label11.TabIndex = 1;
            this.label11.Text = "Propietario:";
            // 
            // lblNumeroFact
            // 
            this.lblNumeroFact.AutoSize = true;
            this.lblNumeroFact.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNumeroFact.ForeColor = System.Drawing.Color.White;
            this.lblNumeroFact.Location = new System.Drawing.Point(692, 20);
            this.lblNumeroFact.Name = "lblNumeroFact";
            this.lblNumeroFact.Size = new System.Drawing.Size(143, 20);
            this.lblNumeroFact.TabIndex = 1;
            this.lblNumeroFact.Text = "Número Factura:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(543, 20);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(143, 20);
            this.label12.TabIndex = 1;
            this.label12.Text = "Número Factura:";
            // 
            // lblMunicipio
            // 
            this.lblMunicipio.AutoSize = true;
            this.lblMunicipio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMunicipio.ForeColor = System.Drawing.Color.White;
            this.lblMunicipio.Location = new System.Drawing.Point(530, 160);
            this.lblMunicipio.Name = "lblMunicipio";
            this.lblMunicipio.Size = new System.Drawing.Size(90, 20);
            this.lblMunicipio.TabIndex = 1;
            this.lblMunicipio.Text = "Hacienda:";
            this.lblMunicipio.Visible = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(435, 160);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(89, 20);
            this.label14.TabIndex = 1;
            this.label14.Text = "Municipio:";
            this.label14.Visible = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(12, 156);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(90, 20);
            this.label13.TabIndex = 1;
            this.label13.Text = "Hacienda:";
            this.label13.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(292, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Reunion:";
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "Editar";
            this.dataGridViewImageColumn1.Image = global::OFLP.Properties.Resources.editar;
            this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn1.Width = 50;
            // 
            // clase
            // 
            this.clase.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.clase.FillWeight = 50F;
            this.clase.HeaderText = "CLASE";
            this.clase.Name = "clase";
            this.clase.ReadOnly = true;
            // 
            // corral
            // 
            this.corral.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.corral.HeaderText = "CORRAL";
            this.corral.Name = "corral";
            this.corral.ReadOnly = true;
            // 
            // cabezas
            // 
            this.cabezas.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.cabezas.HeaderText = "CABEZAS";
            this.cabezas.Name = "cabezas";
            this.cabezas.ReadOnly = true;
            // 
            // sexo
            // 
            this.sexo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.sexo.HeaderText = "SEXO";
            this.sexo.Name = "sexo";
            this.sexo.ReadOnly = true;
            // 
            // comprador
            // 
            this.comprador.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.comprador.HeaderText = "COMPRADOR";
            this.comprador.Name = "comprador";
            this.comprador.ReadOnly = true;
            // 
            // kilo
            // 
            this.kilo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.kilo.HeaderText = "KILO";
            this.kilo.Name = "kilo";
            this.kilo.ReadOnly = true;
            // 
            // FrmAgregarFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 551);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAgregarFactura";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar nueva factura";
            this.Load += new System.EventHandler(this.FrmAgregarFactura_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DtgAgregaFactura)).EndInit();
            this.panel2.ResumeLayout(false);
            this.PnlAgregar.ResumeLayout(false);
            this.PnlAgregar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicAgregar)).EndInit();
            this.GrpIva.ResumeLayout(false);
            this.GrpIva.PerformLayout();
            this.pnlBarraTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbHacienda;
        private System.Windows.Forms.ComboBox cmbPropietario;
        private System.Windows.Forms.DateTimePicker dtpicFechaFactura;
        private System.Windows.Forms.Label lblReunion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblNumeroFact;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblMunicipio;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbClase;
        private System.Windows.Forms.TextBox txtCorral;
        private System.Windows.Forms.TextBox txtCabezas;
        private System.Windows.Forms.GroupBox GrpIva;
        private System.Windows.Forms.CheckBox chkNoIva;
        private System.Windows.Forms.CheckBox chkSiIva;
        private System.Windows.Forms.TextBox TxtValorTotal;
        private System.Windows.Forms.TextBox txtValorKilo;
        private System.Windows.Forms.TextBox txtKilos;
        private System.Windows.Forms.ComboBox cmbSexo;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnTerminarGuardar;
        private System.Windows.Forms.PictureBox PicAgregar;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel pnlBarraTitulo;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.ComboBox CmbComprador;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel PnlAgregar;
        private System.Windows.Forms.DataGridViewTextBoxColumn clase;
        private System.Windows.Forms.DataGridViewTextBoxColumn corral;
        private System.Windows.Forms.DataGridViewTextBoxColumn cabezas;
        private System.Windows.Forms.DataGridViewTextBoxColumn sexo;
        private System.Windows.Forms.DataGridViewTextBoxColumn comprador;
        private System.Windows.Forms.DataGridViewTextBoxColumn kilo;
        private System.Windows.Forms.DataGridView DtgAgregaFactura;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn iva;
        private System.Windows.Forms.DataGridViewTextBoxColumn valor_kilo;
        private System.Windows.Forms.DataGridViewTextBoxColumn valor_total;
        private System.Windows.Forms.DataGridViewImageColumn editar;
        private System.Windows.Forms.DataGridViewImageColumn eliminar;
    }
}