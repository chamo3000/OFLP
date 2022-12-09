using OFLP.Controlador;
using System;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;


namespace OFLP.Vistas
{
    public partial class FrmAgregarCliente : Form
    {

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        public int IdTipoCliente { get; set; }


        private void PnlBarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);

        }
        public FrmAgregarCliente(int idTipoCliente)
        {
            InitializeComponent();
            this.IdTipoCliente = idTipoCliente;

        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnAceptaAgregarCliente_Click(object sender, EventArgs e)
        {
            CtrlUtilidades.ImprimirLog("Ingresa a modulo agregar cliente");

            if (string.IsNullOrEmpty(txtPrimerApellido.Text) || string.IsNullOrEmpty(txtNombre.Text) || string.IsNullOrEmpty(txtCedula.Text))
            {
                MessageBox.Show("Debe ingresar el primer apellido y nombre ", "Ingrese datos del Cliente", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string[] lstDatosIngresar = new string[4];
                lstDatosIngresar[0] = txtPrimerApellido.Text.ToUpper();
                lstDatosIngresar[1] = txtSegundoApellido.Text.ToUpper();
                lstDatosIngresar[2] = txtNombre.Text.ToUpper();
                lstDatosIngresar[3] = txtCedula.Text;


                var queryLondonCustomers = (from cust in ClsInicio.clientes
                                            where cust.CedulaCliente == Convert.ToUInt32(txtCedula.Text)
                                            select cust).ToList();

                if (queryLondonCustomers.Count() > 0)
                {
                    MessageBox.Show("El cliente ya existe, intente nuevamente", "Agregar Cliente", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

                }

                txtPrimerApellido.Text = string.Empty;
                txtSegundoApellido.Text = string.Empty;
                txtNombre.Text = string.Empty;
                txtCedula.Text = string.Empty;
                CtrlUtilidades.ImprimirLog("Cliente Agregado exitosamente");

            }
        }

        private void TxtCedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != (char)Keys.Enter))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
            else if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;//elimina el sonido
                BtnAceptaAgregarCliente_Click(sender, e);//llama al evento click del boton
            }

        }

        private void TxtPrimerApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
            else if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;//elimina el sonido
                BtnAceptaAgregarCliente_Click(sender, e);//llama al evento click del boton
            }
        }

        private void TxtSegundoApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
            else if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;//elimina el sonido
                BtnAceptaAgregarCliente_Click(sender, e);//llama al evento click del boton
            }
        }

        private void TxtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
            else if (e.KeyChar == (char)Keys.Enter)
            {
                e.Handled = true;//elimina el sonido
                BtnAceptaAgregarCliente_Click(sender, e);//llama al evento click del boton
            }
        }

        private void FrmAgregarCliente_Load(object sender, EventArgs e)
        {
            if (FrmPpal.TipoCliente == 2) lblAddUser.Text = "Agregar Nuevo Comprador";
            else lblAddUser.Text = "Agregar Nuevo Propietario";
        }

        private void Validar_Texto(TextBox Elemento)
        {
            if (Controlador.Restricciones.Tiene_Letras(Elemento.Text.Trim()))
            {
                Elemento.Text = string.Empty;
                MessageBox.Show(this, "Este campo no permite números", "Advertencia ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
            }
        }

        private void Validar_Numero(TextBox Elemento)
        {
            if (Controlador.Restricciones.Tiene_Numeros(Elemento.Text.Trim()))
            {
                Elemento.Text = string.Empty;
                MessageBox.Show(this, "Este campo no permite letras", "Advertencia ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
            }
            else if (Elemento.Text.Length >= 6)
            {
                btnAceptaAgregarCliente.Enabled = true;
            }
            else
            {
                btnAceptaAgregarCliente.Enabled = false;
            }
        }


        private void TxtPrimerApellido_TextChanged(object sender, EventArgs e)
        {
            Validar_Texto(txtPrimerApellido);
        }

        private void TxtSegundoApellido_TextChanged(object sender, EventArgs e)
        {
            Validar_Texto(txtSegundoApellido);
        }

        private void TxtNombre_TextChanged(object sender, EventArgs e)
        {
            Validar_Texto(txtNombre);
        }

        private void TxtCedula_TextChanged(object sender, EventArgs e)
        {
            Validar_Numero(txtCedula);
        }
    }
}
