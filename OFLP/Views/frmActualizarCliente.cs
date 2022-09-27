using OFLP.Controlador;
using System;
using System.Windows.Forms;

namespace OFLP.Vistas
{
    public partial class FrmActualizarCliente : Form
    {
        private string[] datosActualizar { get; set; }
        public FrmActualizarCliente(string[] datos)
        {
            InitializeComponent();
            datosActualizar = datos;
        }



        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnAceptaActualizarCliente_Click(object sender, EventArgs e)
        {
            CtrlUtilidades.ImprimirLog("Loggg");
            if (MessageBox.Show("Esta seguro que desea Actualizar el cliente?", "Eliminar Cliente", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                if (txtPrimerApellido.Text.Equals(string.Empty) || txtNombre.Text.Equals(string.Empty))
                {
                    MessageBox.Show("Debe ingresar el primer apellido y nombre ", "Ingrese datos del Cliente", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {

                    datosActualizar[1] = txtPrimerApellido.Text;
                    datosActualizar[2] = txtSegundoApellido.Text;
                    datosActualizar[3] = txtNombre.Text;
                    datosActualizar[4] = txtCedula.Text;



                    CtrlCliente objCtrlCliente = new CtrlCliente();
                    if (objCtrlCliente.ActualizarCliente(datosActualizar))
                    {
                        MessageBox.Show("Cliente actualizado exitosamente", "Actualizar Cliente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Error al actualizar el cliente, valide e intente nuevamente", "Actualizar Cliente", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    objCtrlCliente = null;


                }
            }
        }

        private void FrmActualizarCliente_Load(object sender, EventArgs e)
        {
            txtPrimerApellido.Text = datosActualizar[1];
            txtSegundoApellido.Text = datosActualizar[2];
            txtNombre.Text = datosActualizar[3];
            txtCedula.Text = datosActualizar[4];
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

        private void TxtPrimerApellido_TextChanged(object sender, EventArgs e)
        {
            Validar_Texto(txtPrimerApellido, e);

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
