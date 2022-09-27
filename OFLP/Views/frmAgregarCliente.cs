﻿using OFLP.Controlador;
using System;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;


namespace OFLP.Vistas
{
    public partial class frmAgregarCliente : Form
    {

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        public int idTipoCliente { get; set; }


        private void pnlBarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);

        }
        public frmAgregarCliente(int idTipoCliente)
        {
            InitializeComponent();
            this.idTipoCliente = idTipoCliente;

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnAceptaAgregarCliente_Click(object sender, EventArgs e)
        {
            CtrlUtilidades.ImprimirLog("Loggg");



            if (txtPrimerApellido.Text.Equals(string.Empty) || txtNombre.Text.Equals(string.Empty))
            {
                MessageBox.Show("Debe ingresar el primer apellido y nombre ", "Ingrese datos del Cliente", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string[] lstDatosIngresar = new string[5];
                lstDatosIngresar[0] = txtPrimerApellido.Text;
                lstDatosIngresar[1] = txtSegundoApellido.Text;
                lstDatosIngresar[2] = txtNombre.Text;
                lstDatosIngresar[3] = txtCedula.Text;
                lstDatosIngresar[4] = idTipoCliente.ToString();

                var queryLondonCustomers = (from cust in ClsInicio.clientes
                                            where cust.primerApellido == lstDatosIngresar[0]
                                            where cust.nombreCliente == lstDatosIngresar[0]
                                            select cust).ToList();
                if (queryLondonCustomers.Count() > 0)
                {
                    MessageBox.Show("El cliente ya existe", "Agregar Cliente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    CtrlCliente objCtrlCliente = new CtrlCliente();
                    if (objCtrlCliente.InsertarCliente(lstDatosIngresar))
                    {

                        CtrlUtilidades util = new CtrlUtilidades();
                        util.CerrarFormulario<FrmCliente>(Program.objfrmPpal.pnlContenedor);
                        util.AbrirFormulario<FrmCliente>(Program.objfrmPpal.pnlContenedor);
                        MessageBox.Show("Cliente agregado exitosamente", "Agregar Cliente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        util = null;
                    }
                    else
                    {
                        MessageBox.Show("Error al agregar el cliente, valide e intente nuevamente", "Agregar Cliente", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    objCtrlCliente = null;
                }



                txtPrimerApellido.Text = string.Empty;
                txtSegundoApellido.Text = string.Empty;
                txtNombre.Text = string.Empty;
                txtCedula.Text = string.Empty;

            }
        }

        private void txtCedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtPrimerApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtSegundoApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void frmAgregarCliente_Load(object sender, EventArgs e)
        {
            if (FrmPpal.TipoCliente == 2) lblAddUser.Text = "Agregar Nuevo Comprador";
            else lblAddUser.Text = "Agregar Nuevo Propietario";
        }

        private void Validar_Texto(TextBox Elemento, EventArgs e)
        {

            if (Controlador.Restricciones.Tiene_Letras(Elemento.Text.Trim()))
            {
                Elemento.Text = string.Empty;
                MessageBox.Show(this, "Este campo no permite números", "Advertencia ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
            }
        }

        private void Validar_Numero(TextBox Elemento, EventArgs e)
        {

            if (Controlador.Restricciones.Tiene_Numeros(Elemento.Text.Trim()))
            {
                Elemento.Text = string.Empty;
                MessageBox.Show(this, "Este campo no permite letras", "Advertencia ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
            }
        }


        private void txtPrimerApellido_TextChanged(object sender, EventArgs e)
        {
            Validar_Texto(txtPrimerApellido,e);
        }

        private void txtSegundoApellido_TextChanged(object sender, EventArgs e)
        {
            Validar_Texto(txtSegundoApellido,e);
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            Validar_Texto(txtNombre,e);
        }

        private void txtCedula_TextChanged(object sender, EventArgs e)
        {
            Validar_Numero(txtCedula,e);
        }
    }
}
