﻿using OFLP.Controlador;
using OFLP.Model;
using OFLP.Modelo;
using OFLP.Views;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;
using System.Windows.Shapes;

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
        public string IdFactura { get; set; }
        public int IdComprador { get; set; }
        string claseGanado;
        string numeroCorral;
        string numeroCabezas;
        string genero;
        string cantidadKilos;
        string valorKilo;

        string nombreComprador;
        string valorTotal;

        string totaliva;
        int idClase;
        int idGenero;


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
            hiloPropietarios.Start();
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
            foreach (MCliente item in ClsInicio.clientes)
            {
                cmbPropietario.Items.Add(item.NombreCliente + " " + item.PrimerApellido);
            }
        }
        private void LlenarComboCompradores()
        {
            foreach (MCliente item in ClsInicio.clientes)
            {
                if (!cmbPropietario.Text.Equals(item.NombreCliente + " " + item.PrimerApellido)) CmbComprador.Items.Add(item.NombreCliente + " " + item.PrimerApellido);
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
                //valorTotalGuardar = ValorTotal.ToString();
                TxtValorTotal.Text = ValorTotal.ToString("0,0");
            }
        }

        private void ChkNoIva_CheckedChanged(object sender, EventArgs e)
        {
            if (chkNoIva.Checked)
            {
                chkSiIva.Checked = false;
                CalcularValorTotal();
                // valorTotalGuardar = ValorTotal.ToString();
                TxtValorTotal.Text = ValorTotal.ToString("0,0");
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
        private void TxtValorKilo_TextChanged(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(txtValorKilo.Text) && !txtValorKilo.Text.Equals("0"))
            {
                PicAgregar.Visible = true;
                GrpIva.Enabled = true;
                CalcularValorTotal();
                TxtValorTotal.Text = ValorTotal.ToString("0,0");
            }
            else
            {
                TxtValorTotal.Text = "0";
                GrpIva.Enabled = false;
                chkNoIva.Checked = true;
                PicAgregar.Visible = false;
            }

        }
        private void LlenarDatos(int indexRow)
        {
            claseGanado = DtgAgregaFactura.Rows[indexRow].Cells["claseAgregaFactura"].Value.ToString();
            numeroCorral = DtgAgregaFactura.Rows[indexRow].Cells["corralAgregaFactura"].Value.ToString();
            numeroCabezas = DtgAgregaFactura.Rows[indexRow].Cells["cabezasAgregaFactura"].Value.ToString();
            genero = DtgAgregaFactura.Rows[indexRow].Cells["sexoAgregaFactura"].Value.ToString();
            IdComprador = ExtraerIdComprador(DtgAgregaFactura.Rows[indexRow].Cells["compradorAgregaFactura"].Value.ToString());
            idGenero = ClsInicio.sexo.FirstOrDefault(p => p.Descripcion.Equals(genero)).Id;
            idClase = ClsInicio.ganado.FirstOrDefault(x => claseGanado.Contains(x.Descripcion)).IdGanado;
            cantidadKilos = DtgAgregaFactura.Rows[indexRow].Cells["kilosAgregaFactura"].Value.ToString();
            valorKilo = DtgAgregaFactura.Rows[indexRow].Cells["valor_kiloAgregaFactura"].Value.ToString().Replace(",", string.Empty);
            valorTotal = DtgAgregaFactura.Rows[indexRow].Cells["valor_totalAgregaFactura"].Value.ToString().Replace(",", string.Empty);
        }

        private void AgregarFilaGrid()
        {
            claseGanado = cmbClase.SelectedItem.ToString();
            numeroCorral = txtCorral.Text;
            numeroCabezas = txtCabezas.Text;
            genero = cmbSexo.SelectedItem.ToString();
            idGenero = ClsInicio.sexo.FirstOrDefault(p => p.Descripcion.Equals(genero)).Id;
            idClase = ClsInicio.ganado.FirstOrDefault(x => claseGanado.Contains(x.Descripcion)).IdGanado;
            cantidadKilos = txtKilos.Text;
            valorKilo = Convert.ToDouble(txtValorKilo.Text).ToString("0,0");
            valorTotal = TxtValorTotal.Text;
            totaliva = ValorIva.ToString();
        }
        private void PictureBox1_Click(object sender, EventArgs e)
        {
            btnTerminarGuardar.Visible = true;
            picAceptar.Visible = true;
            AgregarFilaGrid();

            if (string.IsNullOrEmpty(claseGanado) || string.IsNullOrEmpty(numeroCorral) ||
                string.IsNullOrEmpty(numeroCabezas) || string.IsNullOrEmpty(genero) ||
                string.IsNullOrEmpty(cantidadKilos) || string.IsNullOrEmpty(valorKilo) ||
                CmbComprador.SelectedIndex.Equals(-1))
            {

                MessageBox.Show("Debe ingresar todos los datos necesarios", "Ingresa datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                nombreComprador = CmbComprador.SelectedItem.ToString();
                DtgAgregaFactura.Rows.Add(claseGanado, numeroCorral, numeroCabezas, genero, nombreComprador, cantidadKilos, totaliva, valorKilo, valorTotal);
                DtgAgregaFactura.Rows[DtgAgregaFactura.Rows.Count - 1].Cells[9].Value = Image.FromFile(@".\editar.png");
                DtgAgregaFactura.Rows[DtgAgregaFactura.Rows.Count - 1].Cells[10].Value = Image.FromFile(@".\eliminar.png");

                CmbComprador.SelectedItem = null;
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
                for (int i = 0; i < DtgAgregaFactura.RowCount; i++)
                {
                        LlenarDatos(i);
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
                            valorkilo = Convert.ToInt32(string.Format("{0:n}",valorKilo)),
                            valortotal = Convert.ToInt32(string.Format("{0:n}",valorTotal)),
                            anio = DateTime.Now.Year,
                            clienteID = IdPropietario,
                            claseID = idClase,
                            sexoID = idGenero,
                            gastoID = idGasto,
                            compradorID = IdComprador,

                        }
                    };
                    CtrlFactura factura = new CtrlFactura();
                    factura.AgregarFactura(listFactura);
                }
                DtgFormFactura.Rows.Add(lblNumeroFact.Text, lblReunion.Text, Propietario, gasto.ToString(), valorTotal);
                this.Close();
            }
        }
        //private int ExtraerIdClaseGanado(string claseganado)
        //{
        //    int retorno = 0;
        //    foreach (Ganado item in ClsInicio.ganado)
        //    {
        //        if (claseganado.Equals(item.ClaseGanado))
        //        {
        //            retorno = item.IdGanado;
        //        }
        //    }
        //    return retorno;
        //}
        //private int ExtraerIdSexo(string genero)
        //{
        //    int retorno = 0;
        //    foreach (ModSexo item in ClsInicio.sexo)
        //    {
        //        if (genero.Equals(item.Descripcion))
        //        {
        //            retorno = item.Id;
        //        }
        //    }
        //    return retorno;
        //}
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
        private void CmbPropietario_SelectedIndexChanged(object sender, EventArgs e)
        {
            Propietario = cmbPropietario.SelectedItem.ToString();
            Thread hiloCompradores = new Thread(LlenarComboCompradores);
            hiloCompradores.Start();
            foreach (MCliente item in ClsInicio.clientes)
            {
                if (Propietario.Contains(item.PrimerApellido) && Propietario.Contains(item.NombreCliente))
                {
                    IdPropietario = item.CedulaCliente;
                }
            }
            CmbComprador.Visible = true;
        }
        private void CmbComprador_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CmbComprador.SelectedItem != null)
            {
                PnlAgregar.Visible = true;
                nombreComprador = CmbComprador.SelectedItem.ToString();
                foreach (MCliente item in ClsInicio.clientes)
                {
                    if (nombreComprador.Contains(item.PrimerApellido) && nombreComprador.Contains(item.NombreCliente))
                    {
                        IdComprador = item.CedulaCliente;
                    }
                }
            }
        }

        private void TxtKilos_TextChanged(object sender, EventArgs e)
        {
            CalcularValorTotal();
            //valorTotalGuardar = ValorTotal.ToString();
            TxtValorTotal.Text = ValorTotal.ToString("0,0");
        }
    }
}
