using OFLP.Controlador;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OFLP.Vistas
{
    public partial class FrmAgregarSexo : Form
    {
        public FrmAgregarSexo()
        {
            InitializeComponent();
        }

        private void BtnAceptarInsertar_Click(object sender, EventArgs e)
        {
            string sexo = TxtInsertarSexo.Text;
            string descripcion = TxtInsertarDescripcion.Text;

            if (string.IsNullOrEmpty(sexo) || string.IsNullOrEmpty(descripcion))
            {
                MessageBox.Show(this, "Es necesario ingresar los campos completos para realizar el proceso.", "Agregar Hacienda", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                CtrlSexo objSexo = new CtrlSexo();
                if (objSexo.AgregarSexo(sexo, descripcion))
                {
                    MessageBox.Show(this, "El registro ha sido agregado exitosamente", "Agregar Banco", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    CtrlUtilidades util = new CtrlUtilidades();
                    util.CerrarFormulario<FrmSexo>(Program.objfrmPpal.pnlContenedor);
                    util.AbrirFormulario<FrmSexo>(Program.objfrmPpal.pnlContenedor);
                    this.Close();
                }
                else
                {
                    MessageBox.Show(this, "El registro no ha sido agregado, intente nuevamen", "Agregar Banco", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                TxtInsertarSexo.Text = string.Empty;
                TxtInsertarDescripcion.Text = string.Empty;

                objSexo = null;
            }

        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Validar_Texto(TextBox Elemento, EventArgs e)
        {

            if (Controlador.Restricciones.Tiene_Letras(Elemento.Text.Trim()))
            {
                Elemento.Text = string.Empty;
                MessageBox.Show(this, "Este campo no permite números", "Advertencia ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
            }
        }

        private void TxtInsertarSexo_TextChanged(object sender, EventArgs e)
        {
            Validar_Texto(TxtInsertarSexo,e);
        }

     
    }
}
