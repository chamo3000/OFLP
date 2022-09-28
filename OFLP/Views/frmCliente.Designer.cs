namespace OFLP.Vistas
{
    partial class FrmCliente
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
            this.dtgPropietario = new System.Windows.Forms.DataGridView();
            this.lblError = new System.Windows.Forms.Label();
            this.pnlConfiguraPropietario = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.PicAgregarCliente = new System.Windows.Forms.PictureBox();
            this.PicLimpiarBusquedaCliente = new System.Windows.Forms.PictureBox();
            this.PicBuscarCliente = new System.Windows.Forms.PictureBox();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBusquedaPropietario = new System.Windows.Forms.TextBox();
            this.lblTipoCliente = new System.Windows.Forms.Label();
            this.lblCedula = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblconfiguser = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblApellidoUno = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblApellidoDos = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.primerApellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.segundoApellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Modificar = new System.Windows.Forms.DataGridViewImageColumn();
            this.Eliminar = new System.Windows.Forms.DataGridViewImageColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtgPropietario)).BeginInit();
            this.pnlConfiguraPropietario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicAgregarCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicLimpiarBusquedaCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicBuscarCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgPropietario
            // 
            this.dtgPropietario.AllowUserToAddRows = false;
            this.dtgPropietario.AllowUserToDeleteRows = false;
            this.dtgPropietario.AllowUserToResizeColumns = false;
            this.dtgPropietario.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.dtgPropietario.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgPropietario.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dtgPropietario.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dtgPropietario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgPropietario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.primerApellido,
            this.segundoApellido,
            this.nombre,
            this.Modificar,
            this.Eliminar});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgPropietario.DefaultCellStyle = dataGridViewCellStyle2;
            this.dtgPropietario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgPropietario.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke;
            this.dtgPropietario.ImeMode = System.Windows.Forms.ImeMode.Close;
            this.dtgPropietario.Location = new System.Drawing.Point(0, 263);
            this.dtgPropietario.Name = "dtgPropietario";
            this.dtgPropietario.ReadOnly = true;
            this.dtgPropietario.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dtgPropietario.RowHeadersVisible = false;
            this.dtgPropietario.RowHeadersWidth = 51;
            this.dtgPropietario.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dtgPropietario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
            this.dtgPropietario.Size = new System.Drawing.Size(858, 187);
            this.dtgPropietario.TabIndex = 0;
            this.dtgPropietario.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DtgPropietario_CellClick);
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Location = new System.Drawing.Point(12, 129);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 13);
            this.lblError.TabIndex = 1;
            // 
            // pnlConfiguraPropietario
            // 
            this.pnlConfiguraPropietario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pnlConfiguraPropietario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlConfiguraPropietario.Controls.Add(this.label6);
            this.pnlConfiguraPropietario.Controls.Add(this.PicAgregarCliente);
            this.pnlConfiguraPropietario.Controls.Add(this.PicLimpiarBusquedaCliente);
            this.pnlConfiguraPropietario.Controls.Add(this.PicBuscarCliente);
            this.pnlConfiguraPropietario.Controls.Add(this.picLogo);
            this.pnlConfiguraPropietario.Controls.Add(this.label5);
            this.pnlConfiguraPropietario.Controls.Add(this.txtBusquedaPropietario);
            this.pnlConfiguraPropietario.Controls.Add(this.lblTipoCliente);
            this.pnlConfiguraPropietario.Controls.Add(this.lblCedula);
            this.pnlConfiguraPropietario.Controls.Add(this.label2);
            this.pnlConfiguraPropietario.Controls.Add(this.lblconfiguser);
            this.pnlConfiguraPropietario.Controls.Add(this.lblNombre);
            this.pnlConfiguraPropietario.Controls.Add(this.lblApellidoUno);
            this.pnlConfiguraPropietario.Controls.Add(this.label4);
            this.pnlConfiguraPropietario.Controls.Add(this.label3);
            this.pnlConfiguraPropietario.Controls.Add(this.lblApellidoDos);
            this.pnlConfiguraPropietario.Controls.Add(this.label1);
            this.pnlConfiguraPropietario.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlConfiguraPropietario.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlConfiguraPropietario.Location = new System.Drawing.Point(0, 0);
            this.pnlConfiguraPropietario.Name = "pnlConfiguraPropietario";
            this.pnlConfiguraPropietario.Size = new System.Drawing.Size(858, 263);
            this.pnlConfiguraPropietario.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(19, 212);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(134, 20);
            this.label6.TabIndex = 49;
            this.label6.Text = "Agregar Cliente";
            // 
            // PicAgregarCliente
            // 
            this.PicAgregarCliente.Image = global::OFLP.Properties.Resources.Agregar;
            this.PicAgregarCliente.Location = new System.Drawing.Point(159, 203);
            this.PicAgregarCliente.Name = "PicAgregarCliente";
            this.PicAgregarCliente.Size = new System.Drawing.Size(77, 37);
            this.PicAgregarCliente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PicAgregarCliente.TabIndex = 48;
            this.PicAgregarCliente.TabStop = false;
            this.PicAgregarCliente.Click += new System.EventHandler(this.PicAgregarCliente_Click);
            // 
            // PicLimpiarBusquedaCliente
            // 
            this.PicLimpiarBusquedaCliente.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PicLimpiarBusquedaCliente.Image = global::OFLP.Properties.Resources._2376996;
            this.PicLimpiarBusquedaCliente.Location = new System.Drawing.Point(810, 207);
            this.PicLimpiarBusquedaCliente.Name = "PicLimpiarBusquedaCliente";
            this.PicLimpiarBusquedaCliente.Size = new System.Drawing.Size(39, 23);
            this.PicLimpiarBusquedaCliente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PicLimpiarBusquedaCliente.TabIndex = 47;
            this.PicLimpiarBusquedaCliente.TabStop = false;
            this.PicLimpiarBusquedaCliente.Click += new System.EventHandler(this.PicLimpiarBusquedaCliente_Click);
            // 
            // PicBuscarCliente
            // 
            this.PicBuscarCliente.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PicBuscarCliente.Image = global::OFLP.Properties.Resources._639375;
            this.PicBuscarCliente.Location = new System.Drawing.Point(775, 207);
            this.PicBuscarCliente.Name = "PicBuscarCliente";
            this.PicBuscarCliente.Size = new System.Drawing.Size(33, 23);
            this.PicBuscarCliente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PicBuscarCliente.TabIndex = 46;
            this.PicBuscarCliente.TabStop = false;
            this.PicBuscarCliente.Click += new System.EventHandler(this.PicBuscarCliente_Click);
            // 
            // picLogo
            // 
            this.picLogo.BackColor = System.Drawing.Color.White;
            this.picLogo.Image = global::OFLP.Properties.Resources.FACTBYA;
            this.picLogo.Location = new System.Drawing.Point(635, 11);
            this.picLogo.Margin = new System.Windows.Forms.Padding(2);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(211, 148);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogo.TabIndex = 45;
            this.picLogo.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(458, 209);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Buscar Cliente";
            // 
            // txtBusquedaPropietario
            // 
            this.txtBusquedaPropietario.Location = new System.Drawing.Point(590, 209);
            this.txtBusquedaPropietario.Name = "txtBusquedaPropietario";
            this.txtBusquedaPropietario.Size = new System.Drawing.Size(185, 20);
            this.txtBusquedaPropietario.TabIndex = 11;
            this.txtBusquedaPropietario.TextChanged += new System.EventHandler(this.txtBusquedaPropietario_TextChanged);
            // 
            // lblTipoCliente
            // 
            this.lblTipoCliente.AutoSize = true;
            this.lblTipoCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoCliente.ForeColor = System.Drawing.Color.White;
            this.lblTipoCliente.Location = new System.Drawing.Point(173, 180);
            this.lblTipoCliente.Name = "lblTipoCliente";
            this.lblTipoCliente.Size = new System.Drawing.Size(0, 20);
            this.lblTipoCliente.TabIndex = 10;
            // 
            // lblCedula
            // 
            this.lblCedula.AutoSize = true;
            this.lblCedula.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCedula.ForeColor = System.Drawing.Color.White;
            this.lblCedula.Location = new System.Drawing.Point(166, 144);
            this.lblCedula.Name = "lblCedula";
            this.lblCedula.Size = new System.Drawing.Size(0, 20);
            this.lblCedula.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 144);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Cedula:";
            // 
            // lblconfiguser
            // 
            this.lblconfiguser.AutoSize = true;
            this.lblconfiguser.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblconfiguser.ForeColor = System.Drawing.Color.White;
            this.lblconfiguser.Location = new System.Drawing.Point(11, 4);
            this.lblconfiguser.Name = "lblconfiguser";
            this.lblconfiguser.Size = new System.Drawing.Size(109, 29);
            this.lblconfiguser.TabIndex = 6;
            this.lblconfiguser.Text = "Clientes";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.Color.White;
            this.lblNombre.Location = new System.Drawing.Point(166, 57);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(0, 20);
            this.lblNombre.TabIndex = 5;
            // 
            // lblApellidoUno
            // 
            this.lblApellidoUno.AutoSize = true;
            this.lblApellidoUno.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellidoUno.ForeColor = System.Drawing.Color.White;
            this.lblApellidoUno.Location = new System.Drawing.Point(166, 87);
            this.lblApellidoUno.Name = "lblApellidoUno";
            this.lblApellidoUno.Size = new System.Drawing.Size(0, 20);
            this.lblApellidoUno.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(12, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Segundo Apellido:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(12, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Primer Apellido:";
            // 
            // lblApellidoDos
            // 
            this.lblApellidoDos.AutoSize = true;
            this.lblApellidoDos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellidoDos.ForeColor = System.Drawing.Color.White;
            this.lblApellidoDos.Location = new System.Drawing.Point(166, 115);
            this.lblApellidoDos.Name = "lblApellidoDos";
            this.lblApellidoDos.Size = new System.Drawing.Size(0, 20);
            this.lblApellidoDos.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre:";
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewImageColumn1.FillWeight = 10F;
            this.dataGridViewImageColumn1.HeaderText = "Modificar";
            this.dataGridViewImageColumn1.Image = global::OFLP.Properties.Resources.edit;
            this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.ReadOnly = true;
            this.dataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewImageColumn1.Width = 75;
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewImageColumn2.FillWeight = 5F;
            this.dataGridViewImageColumn2.HeaderText = "Eliminar";
            this.dataGridViewImageColumn2.Image = global::OFLP.Properties.Resources.eliminar;
            this.dataGridViewImageColumn2.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            this.dataGridViewImageColumn2.ReadOnly = true;
            this.dataGridViewImageColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewImageColumn2.Width = 68;
            // 
            // id
            // 
            this.id.Frozen = true;
            this.id.HeaderText = "Cedula";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 65;
            // 
            // primerApellido
            // 
            this.primerApellido.Frozen = true;
            this.primerApellido.HeaderText = "Primer Apellido";
            this.primerApellido.MinimumWidth = 6;
            this.primerApellido.Name = "primerApellido";
            this.primerApellido.ReadOnly = true;
            this.primerApellido.Width = 101;
            // 
            // segundoApellido
            // 
            this.segundoApellido.Frozen = true;
            this.segundoApellido.HeaderText = "Segundo Apellido";
            this.segundoApellido.MinimumWidth = 6;
            this.segundoApellido.Name = "segundoApellido";
            this.segundoApellido.ReadOnly = true;
            this.segundoApellido.Width = 106;
            // 
            // nombre
            // 
            this.nombre.Frozen = true;
            this.nombre.HeaderText = "Nombre";
            this.nombre.MinimumWidth = 6;
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            this.nombre.Width = 69;
            // 
            // Modificar
            // 
            this.Modificar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Modificar.FillWeight = 10F;
            this.Modificar.HeaderText = "Modificar";
            this.Modificar.Image = global::OFLP.Properties.Resources.edit;
            this.Modificar.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Modificar.Name = "Modificar";
            this.Modificar.ReadOnly = true;
            this.Modificar.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Modificar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Modificar.Width = 55;
            // 
            // Eliminar
            // 
            this.Eliminar.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Eliminar.FillWeight = 5F;
            this.Eliminar.HeaderText = "Eliminar";
            this.Eliminar.Image = global::OFLP.Properties.Resources.eliminar2;
            this.Eliminar.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.ReadOnly = true;
            this.Eliminar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Eliminar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Eliminar.Width = 50;
            // 
            // FrmCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(858, 450);
            this.Controls.Add(this.dtgPropietario);
            this.Controls.Add(this.pnlConfiguraPropietario);
            this.Controls.Add(this.lblError);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmCliente";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FrmCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgPropietario)).EndInit();
            this.pnlConfiguraPropietario.ResumeLayout(false);
            this.pnlConfiguraPropietario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicAgregarCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicLimpiarBusquedaCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PicBuscarCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Panel pnlConfiguraPropietario;
        private System.Windows.Forms.Label lblconfiguser;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblApellidoUno;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblApellidoDos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTipoCliente;
        private System.Windows.Forms.Label lblCedula;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBusquedaPropietario;
        public System.Windows.Forms.DataGridView dtgPropietario;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.PictureBox PicBuscarCliente;
        private System.Windows.Forms.PictureBox PicLimpiarBusquedaCliente;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.PictureBox PicAgregarCliente;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn primerApellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn segundoApellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewImageColumn Modificar;
        private System.Windows.Forms.DataGridViewImageColumn Eliminar;
    }
}