using OFLP.Controlador;
using System;
using System.Linq;
using System.Windows.Forms;

namespace OFLP.Vistas
{
    public partial class FrmActualizarCliente : Form
    {
        private string[] DatosActualizar { get; set; }
        public FrmActualizarCliente(string[] datos)
        {
            InitializeComponent();
            DatosActualizar = datos;
        }
        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void BtnAceptaActualizarCliente_Click(object sender, EventArgs e)
        {
            CtrlUtilidades.ImprimirLog("Actualizar cliente");
            string AuxiliarCedula = "";

            if (MessageBox.Show("Esta seguro que desea Actualizar el cliente?", "Actualizar Cliente", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                if (string.IsNullOrEmpty(txtPrimerApellido.Text) || string.IsNullOrEmpty(txtNombre.Text) || string.IsNullOrEmpty(txtCedula.Text))
                {
                    MessageBox.Show("Debe ingresar el primer apellido y nombre ", "Ingrese datos del Cliente", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    var queryLondonCustomers = (from cust in ClsInicio.clientes
                                                where cust.CedulaCliente == Convert.ToInt32(txtCedula.Text)
                                                select cust.CedulaCliente).ToList();

                    if (!queryLondonCustomers.Any())AuxiliarCedula= DatosActualizar[0];

                    DatosActualizar[1] = txtPrimerApellido.Text.ToUpper();
                    DatosActualizar[2] = txtSegundoApellido.Text.ToUpper();
                    DatosActualizar[3] = txtNombre.Text.ToUpper();
                    DatosActualizar[0] = txtCedula.Text;

                    CtrlCliente objCtrlCliente = new CtrlCliente();
                    if (objCtrlCliente.ActualizarCliente(DatosActualizar))
                    {
                        MessageBox.Show("Cliente actualizado exitosamente", "Actualizar Cliente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        CtrlUtilidades util = new CtrlUtilidades();
                        util.CerrarFormulario<FrmCliente>(Program.objfrmPpal.pnlContenedor);
                        util.AbrirFormulario<FrmCliente>(Program.objfrmPpal.pnlContenedor);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Error al actualizar el cliente, valide e intente nuevamente", "Actualizar Cliente", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        private void FrmActualizarCliente_Load(object sender, EventArgs e)
        {
            txtPrimerApellido.Text = DatosActualizar[1];
            txtSegundoApellido.Text = DatosActualizar[2];
            txtNombre.Text = DatosActualizar[3];
            txtCedula.Text = DatosActualizar[0];
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
