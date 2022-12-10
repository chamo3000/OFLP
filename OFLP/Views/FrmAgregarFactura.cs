using OFLP.Controlador;
using OFLP.Modelo;
using System;
using System.Drawing;
using System.Globalization;
using System.Threading;
using System.Windows.Forms;

namespace OFLP.Vistas
{
    public partial class FrmAgregarFactura : Form
    {
        public DataGridView DtgFormFactura { get; set; }
        private double ValorIva { get; set; }
        private double ValorTotal { get; set; }
        public int Reunion { get; set; }
        private int CantFacturas { get; set; }
        public string Propietario { get; set; }
        public int IdPropietario { get; set; }
        string claseGanado;
        string numeroCorral;
        string numeroCabezas;
        string genero;
        string cantidadKilos;
        string valorKilo;
        string nombreComprador;
        string valorTotal;
        string totaliva;


        public FrmAgregarFactura(DataGridView dtgFrm)
        {
            InitializeComponent();
            this.DtgFormFactura = dtgFrm;
            this.CantFacturas = dtgFrm.Rows.Count;



        }

        private void Button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmAgregarFactura_Load(object sender, EventArgs e)
        {
            PnlAgregar.Visible = false;
            LimpiarControles();
            CalcularReunion();
            Thread hiloPropietarios = new Thread(LlenarComboPropietarios);
            Thread hiloCompradores = new Thread(LlenarComboCompradores);
            hiloPropietarios.Start();
            hiloCompradores.Start();
            CargarDatosListas();
            LlenarCombos();

        }

        private void CalcularReunion()
        {
            DateTime v2 = new DateTime(dtpicFechaFactura.Value.Year, dtpicFechaFactura.Value.Month, dtpicFechaFactura.Value.Day);
            Reunion = System.Globalization.CultureInfo.CurrentUICulture.Calendar.GetWeekOfYear(v2, CalendarWeekRule.FirstDay, v2.DayOfWeek);
            lblNumeroFact.Text = CalcularConsecutivo();
            lblReunion.Text = Reunion.ToString();
        }

        private void CargarDatosListas()
        {
            CheckForIllegalCrossThreadCalls = false;
            if (ClsInicio.clientes.Count == 0)
            {
                CtrlCliente ObjCliente = new CtrlCliente();
                ObjCliente.LlenarGridCliente();
            }

            if (ClsInicio.haciendas.Count == 0)
            {
                ctrlHacienda ObjHacienda = new ctrlHacienda();
                ObjHacienda.LlenarGridHacienda();
            }

            if (ClsInicio.ganado.Count == 0)
            {
                CtrlGanado objGanado = new CtrlGanado();
                objGanado.LlenarGridGanado();
            }

            if (ClsInicio.sexo.Count == 0)
            {
                CtrlSexo objSexo = new CtrlSexo();
                objSexo.LlenarGridSexo();
            }

        }

        private void LlenarComboPropietarios()
        {
            foreach (ModCliente item in ClsInicio.clientes)
            {
                cmbPropietario.Items.Add(item.NombreCliente + " " + item.PrimerApellido);
            }
        }

        private void LlenarComboCompradores()
        {
            foreach (ModCliente item in ClsInicio.Compradores)
            {
                CmbComprador.Items.Add(item.NombreCliente + " " + item.PrimerApellido);
            }
        }

        private void LlenarCombos()
        {

            //foreach (ModHacienda item in clsInicio.haciendas)
            //{
            //    cmbHacienda.Items.Add(item.nombreHacienda);
            //}

            foreach (ModGanado item in ClsInicio.ganado)
            {
                cmbClase.Items.Add(item.claseGanado + ": "+item.descripcion);
            }
            foreach (ModSexo item in ClsInicio.sexo)
            {
                cmbSexo.Items.Add(item.Descripcion);
            }


        }

        private void CmbClase_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                if (!string.IsNullOrEmpty(cmbClase.Text))
                {
                    txtCorral.Select();
                }
                else
                {
                    MessageBox.Show("Debe ingresar una clase de ganado");
                }

            }

        }

        private void TxtCorral_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                if (!string.IsNullOrEmpty(txtCorral.Text))
                {
                    txtCabezas.Select();
                }
                else
                {
                    MessageBox.Show("Debe ingresar un numero de corral");
                }

            }
            else if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void TxtCabezas_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                if (!string.IsNullOrEmpty(txtCabezas.Text))
                {
                    cmbSexo.Select();
                }
                else
                {
                    MessageBox.Show("Debe ingresar un numero de cabezas");
                }

            }
            else if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void CmbSexo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                if (!string.IsNullOrEmpty(cmbSexo.Text))
                {
                    txtKilos.Select();
                }
                else
                {
                    MessageBox.Show("Debe ingresar el sexo del lote");
                }

            }

        }

        private void TxtKilos_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                if (!string.IsNullOrEmpty(txtKilos.Text))
                {
                    txtValorKilo.Select();
                }
                else
                {
                    MessageBox.Show("Debe ingresar la cantidad total de kilos");
                }

            }
            else if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void TxtValorKilo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {

                if (!string.IsNullOrEmpty(txtValorKilo.Text))
                {
                    GrpIva.Enabled = true;
                    chkNoIva.Checked = true;
                }
                else
                {
                    MessageBox.Show("Debe ingresar la cantidad total de kilos");
                }

            }
            else if (Char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }


        }

        private void ChkSiIva_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSiIva.Checked)
            {
                chkNoIva.Checked = false;
                //ValorTotal = (Convert.ToInt32(txtKilos.Text) * Convert.ToInt32(txtValorKilo.Text));
                CalcularValorTotal();
                TxtValorTotal.Text = string.Format("{0:n}", ValorTotal);
            }
        }

        private void ChkNoIva_CheckedChanged(object sender, EventArgs e)
        {
            if (chkNoIva.Checked)
            {
                chkSiIva.Checked = false;


                CalcularValorTotal();
                TxtValorTotal.Text = string.Format("{0:n}", ValorTotal);
            }
        }

        private void DateTimePicker1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                cmbPropietario.Select();
            }

        }

        private void CmbPropietario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                if (!string.IsNullOrEmpty(cmbPropietario.Text))
                {
                    cmbHacienda.Select();
                }
                else
                {
                    MessageBox.Show("Debe Seleccionar un propiertario");
                }

            }
        }

        private void CmbHacienda_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                cmbClase.Select();
            }

        }

        private void LimpiarControles()
        {
            lblNumeroFact.Text = string.Empty;
            lblMunicipio.Text = string.Empty;
            lblReunion.Text = string.Empty;
        }

        private void TxtValorKilo_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void TxtValorKilo_TextChanged(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(txtValorKilo.Text) && !txtValorKilo.Text.Equals("0"))
            {
                PicAgregar.Visible = true;
                GrpIva.Enabled = true;
                //ValorTotal = (Convert.ToInt32(txtKilos.Text) * Convert.ToInt32(txtValorKilo.Text));
                CalcularValorTotal();
                TxtValorTotal.Text = string.Format("{0:n}", ValorTotal);
            }
            else
            {
                TxtValorTotal.Text = "0";
                GrpIva.Enabled = false;
                chkNoIva.Checked = true;
                PicAgregar.Visible = false;
            }

        }

        private void CmbHacienda_SelectedValueChanged(object sender, EventArgs e)
        {

        }

        private void CmbHacienda_TextChanged(object sender, EventArgs e)
        {

        }

        private void CmbHacienda_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CmbHacienda_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string hacienda = cmbHacienda.SelectedItem.ToString();

            foreach (ModHacienda item in ClsInicio.haciendas)
            {
                if (item.nombreHacienda.Equals(hacienda))
                {
                    lblMunicipio.Text = item.municipio;
                }
            }


        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            btnTerminarGuardar.Visible = true;
            claseGanado = cmbClase.SelectedItem.ToString();
            numeroCorral = txtCorral.Text;
            numeroCabezas = txtCabezas.Text;
            genero = cmbSexo.SelectedItem.ToString();
            cantidadKilos = txtKilos.Text;
            valorKilo = Convert.ToDouble(txtValorKilo.Text).ToString("N");  
            valorTotal = TxtValorTotal.Text;
            totaliva = ValorIva.ToString();


            if (string.IsNullOrEmpty(claseGanado) || string.IsNullOrEmpty(numeroCorral) ||
                string.IsNullOrEmpty(numeroCabezas) || string.IsNullOrEmpty(genero) ||
                string.IsNullOrEmpty(cantidadKilos) || string.IsNullOrEmpty(valorKilo) ||
                string.IsNullOrEmpty(CmbComprador.SelectedItem.ToString()))
            {

                MessageBox.Show("Debe ingresar todos los datos necesarios", "Ingresa datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {

                nombreComprador = CmbComprador.SelectedItem.ToString();
                DtgAgregaFactura.Rows.Add(claseGanado, numeroCorral, numeroCabezas, genero, nombreComprador, cantidadKilos, totaliva, valorKilo, valorTotal);
                DtgAgregaFactura.Rows[DtgAgregaFactura.Rows.Count - 1].Cells[9].Value = Image.FromFile(@".\editar.png");
                DtgAgregaFactura.Rows[DtgAgregaFactura.Rows.Count - 1].Cells[10].Value = Image.FromFile(@".\eliminar.png");

                claseGanado = string.Empty;
                numeroCorral = string.Empty;
                numeroCabezas = string.Empty;
                genero = string.Empty;
                cantidadKilos = string.Empty;
                valorKilo = string.Empty;
                nombreComprador = string.Empty;
                valorTotal = string.Empty;
                totaliva = string.Empty;

                cmbClase.SelectedItem = null;
                txtCorral.Text = string.Empty;
                txtCabezas.Text = string.Empty;
                cmbSexo.SelectedItem = null;
                txtKilos.Text = string.Empty;
                txtValorKilo.Text = string.Empty;
                TxtValorTotal.Text = string.Empty;
                chkNoIva.Checked = true;
                PicAgregar.Visible = false;
                cmbPropietario.Enabled = false;

            }



        }

        private string CalcularConsecutivo()
        {
            string consecutivo;
            var fecha = dtpicFechaFactura.Value.ToString("yyyyMMdd");
            consecutivo = fecha + Reunion + CantFacturas;
            return consecutivo;
        }

        private void CalcularValorTotal()
        {
            double Total;
            if (string.IsNullOrEmpty(txtKilos.Text) || string.IsNullOrEmpty(txtValorKilo.Text))
            {
                ValorTotal = 0;
            }
            else
            {
                ValorTotal = (Convert.ToInt32(txtKilos.Text) * Convert.ToInt32(txtValorKilo.Text));
            }
            Total = ValorTotal;

            if (chkSiIva.Checked)
            {
                ValorIva = (Total * 0.19);
            }
            else
            {
                ValorIva = 0;
            }

            ValorTotal = Total + ValorIva;
        }

        private void DtgAgregaFactura_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {





        }

        private void DtgAgregaFactura_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {




        }

        private void DtgAgregaFactura_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {

        }

        private void DtgAgregaFactura_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {



        }

        private void DtgAgregaFactura_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 10)
            {
                DtgAgregaFactura.Rows.RemoveAt(DtgAgregaFactura.CurrentRow.Index);
            }
            else if (e.ColumnIndex == 9)
            {
                DialogResult result = MessageBox.Show("Esta seguro que desea actualizar el registro?", "Actualizar", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (result == DialogResult.Yes)
                {
                    LimpiarDatos();

                    claseGanado = DtgAgregaFactura.CurrentRow.Cells[0].Value.ToString();
                    numeroCorral = DtgAgregaFactura.CurrentRow.Cells[1].Value.ToString();
                    numeroCabezas = DtgAgregaFactura.CurrentRow.Cells[2].Value.ToString();
                    genero = DtgAgregaFactura.CurrentRow.Cells[3].Value.ToString();
                    nombreComprador = DtgAgregaFactura.CurrentRow.Cells[4].Value.ToString();
                    cantidadKilos = DtgAgregaFactura.CurrentRow.Cells[5].Value.ToString();
                    valorKilo = DtgAgregaFactura.CurrentRow.Cells[6].Value.ToString();
                    valorTotal = DtgAgregaFactura.CurrentRow.Cells[7].Value.ToString();

                    cmbClase.Text = claseGanado;
                    txtCorral.Text = numeroCorral;
                    txtCabezas.Text = numeroCabezas;
                    cmbSexo.Text = genero;
                    txtKilos.Text = cantidadKilos;
                    txtValorKilo.Text = valorKilo;
                    CmbComprador.Text = nombreComprador;
                    TxtValorTotal.Text = valorTotal;
                    chkNoIva.Checked = true;
                    PicAgregar.Visible = true;
                    DtgAgregaFactura.Rows.RemoveAt(DtgAgregaFactura.CurrentRow.Index);
                }
            }
        }

        private void LimpiarDatos()
        {
            claseGanado = string.Empty;
            numeroCorral = string.Empty;
            numeroCabezas = string.Empty;
            genero = string.Empty;
            cantidadKilos = string.Empty;
            valorKilo = string.Empty;
            nombreComprador = string.Empty;
            valorTotal = string.Empty;
            totaliva = string.Empty;

            cmbClase.SelectedItem = null;
            txtCorral.Text = string.Empty;
            txtCabezas.Text = string.Empty;
            cmbSexo.SelectedItem = null;
            txtKilos.Text = string.Empty;
            txtValorKilo.Text = string.Empty;
            TxtValorTotal.Text = string.Empty;
            chkNoIva.Checked = true;
            PicAgregar.Visible = false;
            cmbPropietario.Enabled = false;
        }


        private void DtpicFechaFactura_ValueChanged(object sender, EventArgs e)
        {
            CalcularReunion();
        }

        private void BtnTerminarGuardar_Click(object sender, EventArgs e)
        {
            string[] datos = new string[13];
            CtrlFactura objCtrlFactura = new CtrlFactura();
            CantFacturas++;
            foreach (DataGridViewRow item in DtgAgregaFactura.Rows)
            {
                string fecha = dtpicFechaFactura.Value.ToString("dd-MM-yyyy");
                datos[0] = lblNumeroFact.Text;
                datos[1] = lblReunion.Text;
                datos[2] = fecha;
                datos[3] = IdPropietario.ToString();
                datos[4] = ExtraerIdClaseGanado(item.Cells[0].Value.ToString().Split(':')[0]).ToString() ;
                datos[5] = item.Cells[1].Value.ToString();
                datos[6] = item.Cells[2].Value.ToString();
                datos[7] = ExtraerIdSexo(item.Cells[3].Value.ToString()).ToString();
                datos[8] = item.Cells[5].Value.ToString();
                datos[9] = item.Cells[7].Value.ToString();
                datos[10] = item.Cells[8].Value.ToString();
                datos[11] = DateTime.ParseExact(fecha, "dd-MM-yyyy", CultureInfo.InvariantCulture).Year.ToString();
                datos[12] = ExtraerIdComprador(item.Cells[4].Value.ToString()).ToString();

                objCtrlFactura.AgregarFactura(datos);
                DtgFormFactura.Rows.Add(lblNumeroFact.Text, lblReunion.Text, fecha, Propietario, item.Cells[0].Value, item.Cells[1].Value, item.Cells[2].Value, item.Cells[3].Value, item.Cells[4].Value, item.Cells[5].Value, item.Cells[7].Value, item.Cells[8].Value);
            }

            this.Close();

        }

        private int ExtraerIdClaseGanado(string claseganado)
        {
            int retorno=0;
            foreach(ModGanado item in ClsInicio.ganado)
            {
                if (claseganado.Equals(item.claseGanado))
                {
                    retorno = item.idGanado;
                }
            }
            return retorno;
        }

        private int ExtraerIdSexo(string genero)
        {
            int retorno = 0;
            foreach (ModSexo item in ClsInicio.sexo)
            {
                if (genero.Equals(item.Descripcion))
                {
                    retorno = item.Id;
                }
            }
            return retorno;
        }

        private int ExtraerIdComprador(string comprador)
        {
            int retorno = 0;
            foreach (ModCliente item in ClsInicio.Compradores)
            {
                if (comprador.Contains(item.PrimerApellido) && comprador.Contains(item.NombreCliente))
                {
                    retorno = item.CedulaCliente;
                }
            }
            return retorno;
        }

        private void CmbPropietario_SelectedIndexChanged(object sender, EventArgs e)
        {
            pictureBox2.Visible = true;
            Propietario = cmbPropietario.SelectedItem.ToString();
            foreach (ModCliente item in ClsInicio.clientes)
            {
                if(Propietario.Contains(item.PrimerApellido) && Propietario.Contains(item.NombreCliente))
                {
                    IdPropietario = item.CedulaCliente;
                }
            }
            
            CmbComprador.Visible = true;
        }

        private void CmbComprador_SelectedIndexChanged(object sender, EventArgs e)
        {
            PnlAgregar.Visible = true;
        }
    }
}
