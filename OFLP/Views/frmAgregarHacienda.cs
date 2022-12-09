using OFLP.Controlador;
using OFLP.Modelo;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace OFLP.Vistas
{
    public partial class frmAgregarHacienda : Form
    {
        public frmAgregarHacienda()
        {
            InitializeComponent();
            LlenaComboCliente();
        }

        private void LlenaComboCliente()
        {
            ModCliente ObjCliente = new ModCliente();
            try
            {
                ObjCliente.LlenarGrid();
                ObjCliente = null;
                ClsInicio.clientes = ClsInicio.clientes.OrderBy(x => x.PrimerApellido).ToList();
                foreach (ModCliente item in ClsInicio.clientes)
                {
                    if (!item.NombreCliente.Equals(string.Empty))
                        cmbDueñoHacienda.Items.Add(item.PrimerApellido + " " + item.NombreCliente);
                }
            }
            catch
            {
                // error
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnAceptaAgregarHacienda_Click(object sender, EventArgs e)
        {
            string nombreHacienda = txtNombreHacienda.Text;
            string municipioHacienda = txtxtMunicipioHacienda.Text;
            string dueno = cmbDueñoHacienda.SelectedItem.ToString();
            if (string.IsNullOrEmpty(nombreHacienda) || string.IsNullOrEmpty(municipioHacienda))
            {
                MessageBox.Show(this, "Es necesario ingresar los campos completos para realizar el proceso.", "Agregar Hacienda", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                ctrlHacienda objHacienda = new ctrlHacienda();
                if (objHacienda.AgregarHacienda(nombreHacienda, municipioHacienda, dueno))
                {
                    MessageBox.Show(this, "El registro ha sido agregado exitosamente", "Agregar Hacienda", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnAceptaAgregarHacienda.Visible = false;
                    CtrlUtilidades util = new CtrlUtilidades();
                    util.CerrarFormulario<FrmHaciendas>(Program.objfrmPpal.pnlContenedor);
                    util.AbrirFormulario<FrmHaciendas>(Program.objfrmPpal.pnlContenedor);
                    util = null;
                }
                else
                {
                    MessageBox.Show(this, "El registro no ha sido agregado, intente nuevamen", "Agregar Hacienda", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                txtNombreHacienda.Text = string.Empty;
                txtxtMunicipioHacienda.Text = string.Empty;
                cmbDueñoHacienda.Text = string.Empty;
                objHacienda = null;
            }
        }

        private void Validar_Texto(TextBox Elemento, EventArgs e)
        {

            if (Controlador.Restricciones.Tiene_Letras(Elemento.Text.Trim()))
            {
                Elemento.Text = string.Empty;
                MessageBox.Show(this, "Este campo no permite números", "Advertencia ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
            }
        }

        private void txtNombreHacienda_TextChanged(object sender, EventArgs e)
        {
            Validar_Texto(txtNombreHacienda,e);

        }

        private void txtxtMunicipioHacienda_TextChanged(object sender, EventArgs e)
        {
            Validar_Texto(txtxtMunicipioHacienda,e);
        }

        private void frmAgregarHacienda_Load(object sender, EventArgs e)
        {
            cmbDueñoHacienda.SelectedIndex = 0;
        }
    }


}
