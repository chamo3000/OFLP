using OFLP.Controlador;
using OFLP.Model;
using OFLP.Modelo;
using OFLP.Views;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace OFLP.Vistas
{
    public partial class ActualizarFactura : Form
    {
        public DataGridView DtgFormFactura { get; set; }
        private double ValorIva { get; set; }
        private double ValorTotal { get; set; }
        public int Reunion { get; set; }
        private int CantFacturas { get; set; }
        public string Propietario { get; set; }
        public int IdPropietario { get; set; }
        public string IdFactura { get; set; }
        public int IdComprador { get; set; }

        readonly int IndexFactura;
        string claseGanado;
        string numeroCorral;
        string numeroCabezas;
        string genero;
        string cantidadKilos;
        string valorKilo;
        private string valorKiloGuardar;
        string nombreComprador;
        string valorTotal;
        string valorTotalGuardar;
        int idClase;
        int idGenero;

        List<string> idActualizar = new List<string>();
        string idauxActualizar;

        public ActualizarFactura(DataGridView dtgFrm, string idFactura, int idpropietario, int index)
        {
            InitializeComponent();
            this.IdFactura = idFactura;
            this.IdPropietario = idpropietario;
            this.IndexFactura = index;
            this.DtgFormFactura = dtgFrm;

        }
        private void Button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void ActualizarFactura_Load(object sender, EventArgs e)
        {
            int idFact = Convert.ToInt32(IdFactura);
            PnlAgregar.Visible = false;
            LimpiarControles();
            CargarDatosListas();
            LlenarCombos();
            LlenarGrid();
            lblTotal.Text = FormatoNumeros(DtgFormFactura.Rows[IndexFactura].Cells["valortotal"].Value.ToString());
            LblPropietario.Text = ClsInicio.FacturaActualizar.Where(p => p.PropietarioID == IdPropietario).Take(1).First().Propietario;
            LblGasto.Text = ClsInicio.FacturaActualizar.Where(p => p.NumeroFactura == idFact).Take(1).First().Gasto.ToString("0,00");
            DtgDetalleFactura.ClearSelection();
            CmbComprador.Visible = true;
            CmbComprador.Enabled = true;
            PnlAgregar.Visible = true;

        }
        private void LlenarGrid()
        {
            CtrlFactura objPropietario = new CtrlFactura();
            objPropietario.LlenarGridFacturaActualizar(IdFactura);
            DtgDetalleFactura.ScrollBars = ScrollBars.Both;
            DtgDetalleFactura.Enabled = true;
            DtgDetalleFactura.AutoGenerateColumns = false;
            DtgDetalleFactura.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 12);


            if (ClsInicio.FacturaActualizar.Count > 0)
            {
                dtpicFechaFactura.Text = string.Empty;
                foreach (MFactura item in ClsInicio.FacturaActualizar)
                {
                    DtgDetalleFactura.Rows.Add(item.Clase, item.Corral, item.Cabezas, item.Sexo, item.Comprador, item.Kilos, item.ValorKilo.ToString("0,00"), item.ValorTotal.ToString("0,00"), item.Id);
                }
            }

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
        private void LlenarComboCompradores()
        {
            foreach (MCliente item in ClsInicio.clientes)
            {
                if (!LblPropietario.Text.Equals(item.NombreCliente + " " + item.PrimerApellido)) CmbComprador.Items.Add(item.NombreCliente + " " + item.PrimerApellido);
            }
        }
        private void LlenarCombos()
        {
            foreach (Ganado item in ClsInicio.ganado)
            {
                cmbClase.Items.Add(item.ClaseGanado + ": " + item.Descripcion);
            }
            foreach (ModSexo item in ClsInicio.sexo)
            {
                cmbSexo.Items.Add(item.Descripcion);
            }
            foreach (MCliente item in ClsInicio.clientes)
            {
                if (item.CedulaCliente != IdPropietario)
                    CmbComprador.Items.Add($"{item.NombreCliente} {item.PrimerApellido} {item.SegundoApellido}");
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
                CalcularValorTotal();
                valorTotalGuardar = ValorTotal.ToString();
                TxtValorTotal.Text = string.Format("{0:n}", ValorTotal);
            }
        }
        private void ChkNoIva_CheckedChanged(object sender, EventArgs e)
        {
            if (chkNoIva.Checked)
            {
                chkSiIva.Checked = false;
                CalcularValorTotal();
                valorTotalGuardar = ValorTotal.ToString();
                TxtValorTotal.Text = string.Format("{0:n}", ValorTotal);
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
        private void TxtValorKilo_TextChanged(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(txtValorKilo.Text) && !txtValorKilo.Text.Equals("0"))
            {
                PicAgregar.Visible = true;
                GrpIva.Enabled = true;
                CalcularValorTotal();
                valorTotalGuardar = ValorTotal.ToString();
                TxtValorTotal.Text = ValorTotal.ToString("#,##0");
            }
            else
            {
                TxtValorTotal.Text = "0";
                GrpIva.Enabled = false;
                chkNoIva.Checked = true;
                PicAgregar.Visible = false;
            }
        }
        private void PictureBox1_Click(object sender, EventArgs e)
        {
            btnTerminarGuardar.Visible = true;
            picAceptar.Visible = true;
            claseGanado = cmbClase.SelectedItem.ToString();
            numeroCorral = txtCorral.Text;
            numeroCabezas = txtCabezas.Text;
            genero = cmbSexo.SelectedItem.ToString();
            idGenero = ClsInicio.sexo.FirstOrDefault(p => p.Descripcion.Equals(genero)).Id;
            idClase = ClsInicio.ganado.FirstOrDefault(x => claseGanado.Contains(x.Descripcion)).IdGanado;
            cantidadKilos = txtKilos.Text;
            valorKiloGuardar = txtValorKilo.Text;
            valorKilo = Convert.ToDouble(txtValorKilo.Text).ToString("N");
            valorTotal = TxtValorTotal.Text;


            if (string.IsNullOrEmpty(claseGanado) || string.IsNullOrEmpty(numeroCorral) ||
                string.IsNullOrEmpty(numeroCabezas) || string.IsNullOrEmpty(genero) ||
                string.IsNullOrEmpty(cantidadKilos) || string.IsNullOrEmpty(valorKilo) ||
                string.IsNullOrEmpty(CmbComprador.SelectedItem.ToString()))
            {

                MessageBox.Show("Debe ingresar todos los datos necesarios", "Ingresa datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                var datos = ExtraerDatos();
                if (datos != null)
                {
                    if(ValidarRegistro(datos, DtgDetalleFactura))
                    {
                        MessageBox.Show("El registro ya existe, no lo puede agregar nuevamente", "Ingresa datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        nombreComprador = CmbComprador.SelectedItem.ToString();
                        DtgDetalleFactura.Rows.Add(claseGanado, numeroCorral, numeroCabezas, genero, nombreComprador, cantidadKilos, FormatoNumeros(valorKilo), valorTotal, idauxActualizar);
                        lblTotal.Text = CalcularTotalFactura();
                        cmbClase.SelectedItem = null;
                        txtCorral.Text = string.Empty;
                        txtCabezas.Text = string.Empty;
                        cmbSexo.SelectedItem = null;
                        txtKilos.Text = string.Empty;
                        txtValorKilo.Text = string.Empty;
                        TxtValorTotal.Text = string.Empty;
                        chkNoIva.Checked = true;
                        PicAgregar.Visible = false;
                    }
                }
            }
        }
        private string[] ExtraerDatos()
        {
            string[] datosActualizar = new string[7];
            try
            {
                
                datosActualizar[0] = cmbClase.Text;
                datosActualizar[1] = txtCorral.Text;
                datosActualizar[2] = txtCabezas.Text;
                datosActualizar[3] = cmbSexo.Text;
                datosActualizar[4] = txtKilos.Text;
                datosActualizar[5] = txtValorKilo.Text;
                datosActualizar[6] = TxtValorTotal.Text;
            }
            catch (Exception)
            {

                return null;
            }



            return datosActualizar;
        }
        private bool ValidaRegistroExistente()
        {
            return true;
        }

        public string FormatoNumeros(string numero)
        {

            if (numero.Contains(".")) numero = numero.Split('.')[0];
            return numero;
        }
        private string CalcularConsecutivo()
        {
            var fecha = dtpicFechaFactura.Value.ToString("yyyyMMdd");
            IdFactura = fecha + Reunion + CantFacturas;
            return IdFactura;
        }
        private string CalcularTotalFactura()
        {
            int suma = 0;
            string valor;
            foreach (DataGridViewRow item in DtgDetalleFactura.Rows)
            {
                valor = item.Cells["valor_totalActualizaFactura"].Value.ToString();
                if (valor.Contains(",")) valor = valor.Replace(",", string.Empty);
                if (valor.Contains(".")) valor = FormatoNumeros(valor);
                suma += Convert.ToInt32(valor);
            }
            return suma.ToString("#,##0");
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
                ValorTotal = txtValorKilo.Text.Contains(",") ? (Convert.ToInt32(txtKilos.Text) * Convert.ToInt32(txtValorKilo.Text.Replace(",", ""))) : Convert.ToInt32(txtKilos.Text) * Convert.ToInt32(txtValorKilo.Text);
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
        private void DtgDetalleFactura_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var opcion = DtgDetalleFactura.Columns[e.ColumnIndex].Name;

            switch (opcion)
            {
                case "Modificar":
                    PnlAgregar.Visible = true;
                    CmbComprador.Visible = true;
                    SeleccionarDatoCombo(cmbClase, DtgDetalleFactura.Rows[e.RowIndex].Cells[0].Value.ToString());
                    SeleccionarDatoCombo(cmbSexo, DtgDetalleFactura.Rows[e.RowIndex].Cells[3].Value.ToString());
                    SeleccionarDatoCombo(CmbComprador, DtgDetalleFactura.Rows[e.RowIndex].Cells[4].Value.ToString());
                    txtCorral.Text = DtgDetalleFactura.Rows[e.RowIndex].Cells[1].Value.ToString();
                    txtCabezas.Text = DtgDetalleFactura.Rows[e.RowIndex].Cells[2].Value.ToString();
                    txtKilos.Text = DtgDetalleFactura.Rows[e.RowIndex].Cells[5].Value.ToString();
                    txtValorKilo.Text = DtgDetalleFactura.Rows[e.RowIndex].Cells[6].Value.ToString();
                    TxtValorTotal.Text = DtgDetalleFactura.Rows[e.RowIndex].Cells[7].Value.ToString();
                    idActualizar.Add(DtgDetalleFactura.Rows[e.RowIndex].Cells[8].Value.ToString());
                    idauxActualizar = DtgDetalleFactura.Rows[e.RowIndex].Cells["id"].Value.ToString();
                    int idact = Convert.ToInt32(idauxActualizar);
                    dtpicFechaFactura.Value = ClsInicio.FacturaActualizar.Where(p => p.Id == idact).Select(x => x.Fecha).FirstOrDefault();
                    break;
                case "eliminar":
                    if (MessageBox.Show("Esta seguro que desea eliminar el cliente?", "Eliminar Cliente", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                    {
                        CtrlFactura delFact = new CtrlFactura();
                        if (delFact.EliminarFactura(DtgDetalleFactura.Rows[e.RowIndex].Cells["id"].Value.ToString()))
                        {
                            DtgDetalleFactura.Rows.Remove(DtgDetalleFactura.CurrentRow);
                            MessageBox.Show("Factura eliminada correctamente", "Eliminar Factura", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else MessageBox.Show("La factura no ha sido eliminada", "Eliminar Factura", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    break;
            }
        }
        private void LlenarDatos(int indexRow)
        {
            claseGanado = DtgDetalleFactura.Rows[indexRow].Cells["claseActualizaFactura"].Value.ToString();
            numeroCorral = DtgDetalleFactura.Rows[indexRow].Cells["corralActualizaFactura"].Value.ToString();
            numeroCabezas = DtgDetalleFactura.Rows[indexRow].Cells["cabezasActualizaFactura"].Value.ToString();
            genero = DtgDetalleFactura.Rows[indexRow].Cells["sexoActualizaFactura"].Value.ToString();
            IdComprador = ExtraerIdComprador(DtgDetalleFactura.Rows[indexRow].Cells["compradorActualizaFactura"].Value.ToString());
            idGenero = ClsInicio.sexo.FirstOrDefault(p => p.Descripcion.Equals(genero)).Id;
            idClase = ClsInicio.ganado.FirstOrDefault(x => claseGanado.Contains(x.Descripcion)).IdGanado;
            cantidadKilos = DtgDetalleFactura.Rows[indexRow].Cells["kilosActualizaFactura"].Value.ToString();
            valorKilo = DtgDetalleFactura.Rows[indexRow].Cells["valor_kiloActualizaFactura"].Value.ToString().Replace(",", string.Empty);
            ValorTotal = (Convert.ToInt32(valorKilo) * Convert.ToInt32(cantidadKilos));
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
            cmbClase.SelectedItem = null;
            txtCorral.Text = string.Empty;
            txtCabezas.Text = string.Empty;
            cmbSexo.SelectedItem = null;
            txtKilos.Text = string.Empty;
            txtValorKilo.Text = string.Empty;
            TxtValorTotal.Text = string.Empty;
            chkNoIva.Checked = true;
            PicAgregar.Visible = false;

        }
        private void SeleccionarDatoCombo(ComboBox combo, string dato)
        {
            int index = 0;
            foreach (var item in combo.Items)
            {
                if (item.ToString().Contains(dato))
                {
                    combo.Visible = true;
                    combo.SelectedIndex = index;
                    break;
                }
                index++;

            }
        }
        private void DtpicFechaFactura_ValueChanged(object sender, EventArgs e)
        {
            CalcularReunion();
        }
        private void BtnTerminarGuardar_Click(object sender, EventArgs e)
        {
            DtgFormFactura.Rows.RemoveAt(IndexFactura);
            int idGasto;
            int gasto;

            int IdFact = Convert.ToInt32(IdFactura);
            using (MIGANEntities db = new MIGANEntities())
            {
                idGasto = db.GASTO.FirstOrDefault(p => p.idfactura == IdFact).id;
                gasto = db.GASTO.FirstOrDefault(p => p.idfactura == IdFact).Total;

            }
            for (int i = 0; i < idActualizar.Count; i++)
            {

                foreach (DataGridViewRow item in DtgDetalleFactura.Rows)
                {
                    if (item.Cells[8].Value.Equals(idActualizar[i]))
                    {
                        LlenarDatos(item.Index);
                        List<FACTURA> listFactura = new List<FACTURA>()
                        {
                            new FACTURA
                            {
                            id=Convert.ToInt32(idActualizar[i]),
                            consecutivo = IdFact,
                            reunion = Reunion,
                            cabezas = Convert.ToInt32(numeroCabezas),
                            corral = Convert.ToInt32(numeroCorral),
                            kilos = Convert.ToInt32(cantidadKilos),
                            valorkilo = Convert.ToInt32(valorKilo.Replace(",",string.Empty)),
                            valortotal = Convert.ToInt32(ValorTotal),
                            anio = DateTime.Now.Year,
                            clienteID = IdPropietario,
                            claseID = idClase,
                            sexoID = idGenero,
                            gastoID = idGasto,
                            fecha=dtpicFechaFactura.Value
                            }
                        };
                        CtrlFactura factura = new CtrlFactura();
                        factura.ActualizarFactura(listFactura, 0);
                    }
                }
            }
            CtrlUtilidades util = new CtrlUtilidades();
            util.CerrarFormulario<FrmFactura>(Program.objfrmPpal.pnlContenedor);
            util.AbrirFormulario<FrmFactura>(Program.objfrmPpal.pnlContenedor);
            this.Close();
        }

        private int ExtraerIdClaseGanado(string claseganado)
        {
            int retorno = 0;
            foreach (Ganado item in ClsInicio.ganado)
            {
                if (claseganado.Equals(item.ClaseGanado))
                {
                    retorno = item.IdGanado;
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
            foreach (MCliente item in ClsInicio.clientes)
            {
                if (comprador.Contains(item.PrimerApellido) && comprador.Contains(item.NombreCliente))
                {
                    retorno = item.CedulaCliente;
                }
            }
            return retorno;
        }
        private void CmbComprador_SelectedIndexChanged(object sender, EventArgs e)
        {
            PnlAgregar.Visible = true;
            nombreComprador = CmbComprador.SelectedItem.ToString();
            Thread hiloCompradores = new Thread(LlenarComboCompradores);
            hiloCompradores.Start();
            foreach (MCliente item in ClsInicio.clientes)
            {
                if (nombreComprador.Contains(item.PrimerApellido) && nombreComprador.Contains(item.NombreCliente))
                {
                    IdComprador = item.CedulaCliente;
                }
            }
        }

        private void TxtKilos_TextChanged(object sender, EventArgs e)
        {
            CalcularValorTotal();
            TxtValorTotal.Text = ValorTotal.ToString("0,0");
        }
        private bool ValidarRegistro(string[] reg, DataGridView datos)
        {
            foreach (DataGridViewRow item in datos.Rows)
            {
                var clase = item.Cells[0].Value.ToString();
                var corral = item.Cells[1].Value.ToString();
                var cabezas = item.Cells[2].Value.ToString();
                var sexo = item.Cells[3].Value.ToString();
                var kilos = item.Cells[4].Value.ToString();
                var valorKilo = item.Cells[5].Value.ToString();
                var total = item.Cells[6].Value.ToString();
                if(
                    ValidarClase(clase, reg[0].Split(':')[1]) &&
                    ValidarCorral(corral, reg[1])&&
                    ValidarCabezas(cabezas, reg[2])&&
                    ValidarSexo(sexo, reg[3])&&
                    ValidarKilos(kilos, reg[4])&&
                    ValidarValorKilo(valorKilo, reg[5])&&
                    ValidarValorTotal(total, reg[6])
                )
                {
                    return true;
                }
            }
            return false;
        }
        private bool ValidarClase(string claseDtg,string claseRegistro)
        {
            return claseDtg.Equals(claseRegistro);
        }
        private bool ValidarCorral(string corralDtg, string corralRegistro)
        {
            return corralDtg.Equals(corralRegistro);
        }

        private bool ValidarCabezas(string cabezasDtg, string cabezasRegistro)
        {
            return cabezasDtg.Equals(cabezasRegistro);
        }

        private bool ValidarSexo(string sexoDtg, string sexoRegistro)
        {
            return sexoDtg.Equals(sexoRegistro);
        }

        private bool ValidarKilos(string kilosDtg, string kilosRegistro)
        {
            return kilosDtg.Equals(kilosRegistro);
        }
        private bool ValidarValorKilo(string valorKiloDtg, string valorKiloRegistro)
        {
            return valorKiloDtg.Equals(valorKiloRegistro);
        }
        private bool ValidarValorTotal(string valorKiloTDtg, string valorKiloTRegistro)
        {
            return valorKiloTDtg.Equals(valorKiloTRegistro);
        }
    }
}
