namespace OFLP.Vistas
{
    partial class FrmHaciendas
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHaciendas));
            this.pnlConfiguraHacienda = new System.Windows.Forms.Panel();
            this.lblPrimerAp = new System.Windows.Forms.Label();
            this.lblSegundoAp = new System.Windows.Forms.Label();
            this.lblCedula = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnActualizaHacienda = new System.Windows.Forms.Button();
            this.btnEliminarHacienda = new System.Windows.Forms.Button();
            this.btnAgregarHacienda = new System.Windows.Forms.Button();
            this.btnLimpiarBusquedaPropietario = new System.Windows.Forms.Button();
            this.btnBuscarHacienda = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBusquedaHacienda = new System.Windows.Forms.TextBox();
            this.lblconfigHacienda = new System.Windows.Forms.Label();
            this.lblNombreHacienda = new System.Windows.Forms.Label();
            this.lblMunicipio = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblNombreCliente = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtgHacienda = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.municipio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.primerApellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.segundoApellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cedula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlConfiguraHacienda.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgHacienda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlConfiguraHacienda
            // 
            this.pnlConfiguraHacienda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pnlConfiguraHacienda.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlConfiguraHacienda.Controls.Add(this.pictureBox5);
            this.pnlConfiguraHacienda.Controls.Add(this.lblPrimerAp);
            this.pnlConfiguraHacienda.Controls.Add(this.lblSegundoAp);
            this.pnlConfiguraHacienda.Controls.Add(this.lblCedula);
            this.pnlConfiguraHacienda.Controls.Add(this.groupBox1);
            this.pnlConfiguraHacienda.Controls.Add(this.btnLimpiarBusquedaPropietario);
            this.pnlConfiguraHacienda.Controls.Add(this.btnBuscarHacienda);
            this.pnlConfiguraHacienda.Controls.Add(this.label5);
            this.pnlConfiguraHacienda.Controls.Add(this.txtBusquedaHacienda);
            this.pnlConfiguraHacienda.Controls.Add(this.lblconfigHacienda);
            this.pnlConfiguraHacienda.Controls.Add(this.lblNombreHacienda);
            this.pnlConfiguraHacienda.Controls.Add(this.lblMunicipio);
            this.pnlConfiguraHacienda.Controls.Add(this.label7);
            this.pnlConfiguraHacienda.Controls.Add(this.label6);
            this.pnlConfiguraHacienda.Controls.Add(this.label4);
            this.pnlConfiguraHacienda.Controls.Add(this.label3);
            this.pnlConfiguraHacienda.Controls.Add(this.label2);
            this.pnlConfiguraHacienda.Controls.Add(this.lblNombreCliente);
            this.pnlConfiguraHacienda.Controls.Add(this.label1);
            this.pnlConfiguraHacienda.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlConfiguraHacienda.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlConfiguraHacienda.Location = new System.Drawing.Point(0, 0);
            this.pnlConfiguraHacienda.Name = "pnlConfiguraHacienda";
            this.pnlConfiguraHacienda.Size = new System.Drawing.Size(800, 244);
            this.pnlConfiguraHacienda.TabIndex = 4;
            // 
            // lblPrimerAp
            // 
            this.lblPrimerAp.AutoSize = true;
            this.lblPrimerAp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrimerAp.ForeColor = System.Drawing.Color.White;
            this.lblPrimerAp.Location = new System.Drawing.Point(173, 158);
            this.lblPrimerAp.Name = "lblPrimerAp";
            this.lblPrimerAp.Size = new System.Drawing.Size(0, 20);
            this.lblPrimerAp.TabIndex = 18;
            // 
            // lblSegundoAp
            // 
            this.lblSegundoAp.AutoSize = true;
            this.lblSegundoAp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSegundoAp.ForeColor = System.Drawing.Color.White;
            this.lblSegundoAp.Location = new System.Drawing.Point(173, 183);
            this.lblSegundoAp.Name = "lblSegundoAp";
            this.lblSegundoAp.Size = new System.Drawing.Size(0, 20);
            this.lblSegundoAp.TabIndex = 17;
            // 
            // lblCedula
            // 
            this.lblCedula.AutoSize = true;
            this.lblCedula.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCedula.ForeColor = System.Drawing.Color.White;
            this.lblCedula.Location = new System.Drawing.Point(173, 208);
            this.lblCedula.Name = "lblCedula";
            this.lblCedula.Size = new System.Drawing.Size(0, 20);
            this.lblCedula.TabIndex = 16;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnActualizaHacienda);
            this.groupBox1.Controls.Add(this.btnEliminarHacienda);
            this.groupBox1.Controls.Add(this.btnAgregarHacienda);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(650, 62);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(211, 148);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Configuración Hacienda";
            // 
            // btnActualizaHacienda
            // 
            this.btnActualizaHacienda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizaHacienda.ForeColor = System.Drawing.Color.Black;
            this.btnActualizaHacienda.Location = new System.Drawing.Point(16, 62);
            this.btnActualizaHacienda.Name = "btnActualizaHacienda";
            this.btnActualizaHacienda.Size = new System.Drawing.Size(181, 26);
            this.btnActualizaHacienda.TabIndex = 14;
            this.btnActualizaHacienda.Text = "Actualiza Hacienda";
            this.btnActualizaHacienda.UseVisualStyleBackColor = true;
            this.btnActualizaHacienda.Click += new System.EventHandler(this.BtnActualizaHacienda_Click);
            // 
            // btnEliminarHacienda
            // 
            this.btnEliminarHacienda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarHacienda.ForeColor = System.Drawing.Color.Black;
            this.btnEliminarHacienda.Location = new System.Drawing.Point(16, 94);
            this.btnEliminarHacienda.Name = "btnEliminarHacienda";
            this.btnEliminarHacienda.Size = new System.Drawing.Size(181, 26);
            this.btnEliminarHacienda.TabIndex = 14;
            this.btnEliminarHacienda.Text = "Eliminar Hacienda";
            this.btnEliminarHacienda.UseVisualStyleBackColor = true;
            this.btnEliminarHacienda.Click += new System.EventHandler(this.BtnEliminarHacienda_Click);
            // 
            // btnAgregarHacienda
            // 
            this.btnAgregarHacienda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarHacienda.ForeColor = System.Drawing.Color.Black;
            this.btnAgregarHacienda.Location = new System.Drawing.Point(16, 30);
            this.btnAgregarHacienda.Name = "btnAgregarHacienda";
            this.btnAgregarHacienda.Size = new System.Drawing.Size(181, 26);
            this.btnAgregarHacienda.TabIndex = 14;
            this.btnAgregarHacienda.Text = "Agregar Hacienda";
            this.btnAgregarHacienda.UseVisualStyleBackColor = true;
            this.btnAgregarHacienda.Click += new System.EventHandler(this.BtnAgregarHacienda_Click);
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
            this.btnLimpiarBusquedaPropietario.Click += new System.EventHandler(this.BtnLimpiarBusquedaPropietario_Click);
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
            this.btnBuscarHacienda.Click += new System.EventHandler(this.BtnBuscarHacienda_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(394, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(146, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Buscar Hacienda";
            // 
            // txtBusquedaHacienda
            // 
            this.txtBusquedaHacienda.Location = new System.Drawing.Point(397, 111);
            this.txtBusquedaHacienda.Name = "txtBusquedaHacienda";
            this.txtBusquedaHacienda.Size = new System.Drawing.Size(177, 20);
            this.txtBusquedaHacienda.TabIndex = 11;
            this.txtBusquedaHacienda.TextChanged += new System.EventHandler(this.txtBusquedaHacienda_TextChanged);
            // 
            // lblconfigHacienda
            // 
            this.lblconfigHacienda.AutoSize = true;
            this.lblconfigHacienda.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblconfigHacienda.ForeColor = System.Drawing.Color.White;
            this.lblconfigHacienda.Location = new System.Drawing.Point(11, 11);
            this.lblconfigHacienda.Name = "lblconfigHacienda";
            this.lblconfigHacienda.Size = new System.Drawing.Size(399, 29);
            this.lblconfigHacienda.TabIndex = 6;
            this.lblconfigHacienda.Text = "Modulo Configuracion Haciendas";
            // 
            // lblNombreHacienda
            // 
            this.lblNombreHacienda.AutoSize = true;
            this.lblNombreHacienda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreHacienda.ForeColor = System.Drawing.Color.White;
            this.lblNombreHacienda.Location = new System.Drawing.Point(172, 85);
            this.lblNombreHacienda.Name = "lblNombreHacienda";
            this.lblNombreHacienda.Size = new System.Drawing.Size(0, 20);
            this.lblNombreHacienda.TabIndex = 5;
            // 
            // lblMunicipio
            // 
            this.lblMunicipio.AutoSize = true;
            this.lblMunicipio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMunicipio.ForeColor = System.Drawing.Color.White;
            this.lblMunicipio.Location = new System.Drawing.Point(172, 110);
            this.lblMunicipio.Name = "lblMunicipio";
            this.lblMunicipio.Size = new System.Drawing.Size(0, 20);
            this.lblMunicipio.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(12, 207);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 20);
            this.label7.TabIndex = 3;
            this.label7.Text = "Cedula:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(12, 183);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(155, 20);
            this.label6.TabIndex = 2;
            this.label6.Text = "Segundo Apellido:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(12, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nombre Cliente:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(12, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Municipio:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Primer Apellido:";
            // 
            // lblNombreCliente
            // 
            this.lblNombreCliente.AutoSize = true;
            this.lblNombreCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreCliente.ForeColor = System.Drawing.Color.White;
            this.lblNombreCliente.Location = new System.Drawing.Point(172, 135);
            this.lblNombreCliente.Name = "lblNombreCliente";
            this.lblNombreCliente.Size = new System.Drawing.Size(0, 20);
            this.lblNombreCliente.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre Hacienda:";
            // 
            // dtgHacienda
            // 
            this.dtgHacienda.AllowUserToAddRows = false;
            this.dtgHacienda.AllowUserToDeleteRows = false;
            this.dtgHacienda.AllowUserToResizeColumns = false;
            this.dtgHacienda.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            this.dtgHacienda.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgHacienda.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgHacienda.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtgHacienda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgHacienda.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.descripcion,
            this.municipio,
            this.nombre,
            this.primerApellido,
            this.segundoApellido,
            this.cedula});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgHacienda.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtgHacienda.Dock = System.Windows.Forms.DockStyle.Top;
            this.dtgHacienda.Location = new System.Drawing.Point(0, 244);
            this.dtgHacienda.Name = "dtgHacienda";
            this.dtgHacienda.ReadOnly = true;
            this.dtgHacienda.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgHacienda.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dtgHacienda.RowHeadersWidth = 51;
            this.dtgHacienda.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dtgHacienda.Size = new System.Drawing.Size(800, 620);
            this.dtgHacienda.TabIndex = 3;
            this.dtgHacienda.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DtgHacienda_CellClick);
            // 
            // id
            // 
            this.id.HeaderText = "ID Hacienda";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // descripcion
            // 
            this.descripcion.HeaderText = "Nombre Hacienda";
            this.descripcion.MinimumWidth = 6;
            this.descripcion.Name = "descripcion";
            this.descripcion.ReadOnly = true;
            // 
            // municipio
            // 
            this.municipio.HeaderText = "Municipio";
            this.municipio.MinimumWidth = 6;
            this.municipio.Name = "municipio";
            this.municipio.ReadOnly = true;
            // 
            // nombre
            // 
            this.nombre.HeaderText = "Nombre Cliente";
            this.nombre.MinimumWidth = 6;
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            // 
            // primerApellido
            // 
            this.primerApellido.HeaderText = "Primer Apellido";
            this.primerApellido.MinimumWidth = 6;
            this.primerApellido.Name = "primerApellido";
            this.primerApellido.ReadOnly = true;
            // 
            // segundoApellido
            // 
            this.segundoApellido.HeaderText = "Segundo Apellido";
            this.segundoApellido.MinimumWidth = 6;
            this.segundoApellido.Name = "segundoApellido";
            this.segundoApellido.ReadOnly = true;
            // 
            // cedula
            // 
            this.cedula.HeaderText = "Cedula";
            this.cedula.MinimumWidth = 6;
            this.cedula.Name = "cedula";
            this.cedula.ReadOnly = true;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.White;
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(960, 66);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(211, 148);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 45;
            this.pictureBox5.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dtgHacienda);
            this.panel1.Controls.Add(this.pnlConfiguraHacienda);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 450);
            this.panel1.TabIndex = 5;
            // 
            // FrmHaciendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmHaciendas";
            this.Text = "frmHaciendas";
            this.Load += new System.EventHandler(this.FrmHaciendas_Load);
            this.pnlConfiguraHacienda.ResumeLayout(false);
            this.pnlConfiguraHacienda.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgHacienda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlConfiguraHacienda;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnActualizaHacienda;
        private System.Windows.Forms.Button btnEliminarHacienda;
        private System.Windows.Forms.Button btnAgregarHacienda;
        private System.Windows.Forms.Button btnLimpiarBusquedaPropietario;
        private System.Windows.Forms.Button btnBuscarHacienda;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBusquedaHacienda;
        private System.Windows.Forms.Label lblconfigHacienda;
        private System.Windows.Forms.Label lblNombreHacienda;
        private System.Windows.Forms.Label lblMunicipio;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblNombreCliente;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.DataGridView dtgHacienda;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn municipio;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn primerApellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn segundoApellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn cedula;
        private System.Windows.Forms.Label lblPrimerAp;
        private System.Windows.Forms.Label lblSegundoAp;
        private System.Windows.Forms.Label lblCedula;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Panel panel1;
    }
}