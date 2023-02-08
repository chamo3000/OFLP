﻿using OFLP.Controlador;
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
        string claseGanado;
        string numeroCorral;
        string numeroCabezas;
        string genero;
        string cantidadKilos;
        string valorKilo;
        string valorKiloGuardar;
        string nombreComprador;
        string valorTotal;
        string valorTotalGuardar;
        string totaliva;
        int idClase;
        int idGenero;

        public ActualizarFactura(string idFactura,int idpropietario)
        {
            InitializeComponent();
            this.IdFactura = idFactura;
            this.IdPropietario= idpropietario;

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
            LblPropietario.Text = ClsInicio.FacturaActualizar.Where(p => p.PropietarioID == IdPropietario).Take(1).First().Propietario;
            LblGasto.Text= ClsInicio.FacturaActualizar.Where(p => p.NumeroFactura == idFact).Take(1).First().Gasto.ToString("0,00");
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

                foreach (MFactura item in ClsInicio.FacturaActualizar)
                {
                    DtgDetalleFactura.Rows.Add(item.Clase, item.Corral, item.Cabezas, item.Sexo, item.Comprador, item.Kilos, item.ValorKilo.ToString("0,00"), item.ValorTotal.ToString("0,00"));
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
            foreach ( MCliente item in ClsInicio.clientes)
            {
                if(item.CedulaCliente!=IdPropietario)
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
                DtgDetalleFactura.Rows.Add(claseGanado, numeroCorral, numeroCabezas, genero, nombreComprador, cantidadKilos, totaliva, valorKilo, valorTotal);
                DtgDetalleFactura.Rows[DtgDetalleFactura.Rows.Count - 1].Cells[9].Value = Image.FromFile(@".\editar.png");
                DtgDetalleFactura.Rows[DtgDetalleFactura.Rows.Count - 1].Cells[10].Value = Image.FromFile(@".\eliminar.png");

                //claseGanado = string.Empty;
                //numeroCorral = string.Empty;
                //numeroCabezas = string.Empty;
                //genero = string.Empty;
                //cantidadKilos = string.Empty;
                //valorKilo = string.Empty;
                //nombreComprador = string.Empty;
                //valorTotal = string.Empty;
                //totaliva = string.Empty;

                //cmbClase.SelectedItem = null;
                //txtCorral.Text = string.Empty;
                //txtCabezas.Text = string.Empty;
                //cmbSexo.SelectedItem = null;
                //txtKilos.Text = string.Empty;
                //txtValorKilo.Text = string.Empty;
                //TxtValorTotal.Text = string.Empty;
                //chkNoIva.Checked = true;
                //PicAgregar.Visible = false;
                //cmbPropietario.Enabled = false;

            }
        }
        private string CalcularConsecutivo()
        {
            var fecha = dtpicFechaFactura.Value.ToString("yyyyMMdd");
            IdFactura = fecha + Reunion + CantFacturas;
            return IdFactura;
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
                ValorTotal = (Convert.ToInt32(txtKilos.Text) * Convert.ToInt32(txtValorKilo.Text.Replace(",", "")));
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
                    SeleccionarDatoCombo(cmbClase, DtgDetalleFactura.Rows[e.RowIndex].Cells[0].Value.ToString());
                    SeleccionarDatoCombo(cmbSexo, DtgDetalleFactura.Rows[e.RowIndex].Cells[3].Value.ToString());
                    SeleccionarDatoCombo(CmbComprador, DtgDetalleFactura.Rows[e.RowIndex].Cells[4].Value.ToString());
                    txtCorral.Text = DtgDetalleFactura.Rows[e.RowIndex].Cells[1].Value.ToString();
                    txtCabezas.Text = DtgDetalleFactura.Rows[e.RowIndex].Cells[2].Value.ToString();
                    txtKilos.Text = DtgDetalleFactura.Rows[e.RowIndex].Cells[5].Value.ToString();
                    txtValorKilo.Text = DtgDetalleFactura.Rows[e.RowIndex].Cells[6].Value.ToString();
                    TxtValorTotal.Text = DtgDetalleFactura.Rows[e.RowIndex].Cells[7].Value.ToString();
                    break;
                case "eliminar":
                    if (MessageBox.Show("Esta seguro que desea eliminar el cliente?", "Eliminar Cliente", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                    {
                        //CtrlFactura delFact = new CtrlFactura();
                        //delFact.EliminarFactura(idFactura);
                    }

                    break;
                default:
                    //lblApellidoUno.Text = dtgPropietario.CurrentRow.Cells[1].Value.ToString();
                    //lblApellidoDos.Text = dtgPropietario.CurrentRow.Cells[2].Value.ToString();
                    //lblNombre.Text = dtgPropietario.CurrentRow.Cells[3].Value.ToString();
                    //lblCedula.Text = dtgPropietario.CurrentRow.Cells[4].Value.ToString();
                    break;
            }

            //if (e.ColumnIndex == 10)
            //{
            //    DtgDetalleFactura.Rows.RemoveAt(DtgDetalleFactura.CurrentRow.Index);
            //}
            //else if (e.ColumnIndex == 9)
            //{
            //    DialogResult result = MessageBox.Show("Esta seguro que desea actualizar el registro?", "Actualizar", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            //    if (result == DialogResult.Yes)
            //    {
            //        LimpiarDatos();

            //        claseGanado = DtgDetalleFactura.CurrentRow.Cells[0].Value.ToString();
            //        numeroCorral = DtgDetalleFactura.CurrentRow.Cells[1].Value.ToString();
            //        numeroCabezas = DtgDetalleFactura.CurrentRow.Cells[2].Value.ToString();
            //        genero = DtgDetalleFactura.CurrentRow.Cells[3].Value.ToString();
            //        nombreComprador = DtgDetalleFactura.CurrentRow.Cells[4].Value.ToString();
            //        cantidadKilos = DtgDetalleFactura.CurrentRow.Cells[5].Value.ToString();
            //        valorKilo = DtgDetalleFactura.CurrentRow.Cells[6].Value.ToString();
            //        valorTotal = DtgDetalleFactura.CurrentRow.Cells[7].Value.ToString();

            //        cmbClase.Text = claseGanado;
            //        txtCorral.Text = numeroCorral;
            //        txtCabezas.Text = numeroCabezas;
            //        cmbSexo.Text = genero;
            //        txtKilos.Text = cantidadKilos;
            //        txtValorKilo.Text = valorKilo;
            //        CmbComprador.Text = nombreComprador;
            //        TxtValorTotal.Text = valorTotal;
            //        chkNoIva.Checked = true;
            //        PicAgregar.Visible = true;
            //        DtgDetalleFactura.Rows.RemoveAt(DtgDetalleFactura.CurrentRow.Index);
            //    }
            //}
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
            
        }
        private void SeleccionarDatoCombo(ComboBox combo,string dato)
        {
            int index = 0;
            foreach (var item in combo.Items)
            {
                if (item.ToString().Contains(dato))
                {
                    combo.Visible=true;
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

            if (MessageBox.Show("Desea agregar gastos a la factura", "Agregar Gastos", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {

                int idGasto;
                int gasto;
                FrmGasto OGasto = new FrmGasto(IdFactura, IdPropietario, Reunion);
                OGasto.ShowDialog();
                int IdFact = Convert.ToInt32(IdFactura);
                using (MIGANEntities db = new MIGANEntities())
                {
                    idGasto = db.GASTO.FirstOrDefault(p => p.idfactura == IdFact).id;
                    gasto = db.GASTO.FirstOrDefault(p => p.idfactura == IdFact).Total;
                }
                List<FACTURA> listFactura = new List<FACTURA>()
                {
                    new FACTURA
                    {
                                    consecutivo = IdFact,
                    reunion = Reunion,
                    fecha = DateTime.Now,
                    cabezas = Convert.ToInt32(numeroCabezas),
                    corral = Convert.ToInt32(numeroCorral),
                    kilos = Convert.ToInt32(cantidadKilos),
                    valorkilo = Convert.ToInt32(valorKiloGuardar),
                    valortotal = Convert.ToInt32(valorTotalGuardar),
                    anio = DateTime.Now.Year,
                    clienteID = IdPropietario,
                    claseID = idClase,
                    sexoID = idGenero,
                    gastoID = idGasto,
                    compradorID = IdComprador,

                    }
                };
                CtrlFactura factura= new CtrlFactura();
                factura.AgregarFactura(listFactura);
                DtgFormFactura.Rows.Add(lblNumeroFact.Text, lblReunion.Text, Propietario, gasto.ToString(),valorTotalGuardar);
                this.Close();
            }

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
            foreach (MCliente item in ClsInicio.Compradores)
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

    }
}