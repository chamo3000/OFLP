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
    public partial class FrmAgregarBanco : Form
    {
        public FrmAgregarBanco()
        {
            InitializeComponent();
        }

        private void BtnAceptaAgregarBanco_Click(object sender, EventArgs e)
        {
            string nombreBanco = TxtNombreBanco.Text;
            string descripcionBanco = TxtDescripcionBanco.Text;
         
            if (string.IsNullOrEmpty(nombreBanco) || string.IsNullOrEmpty(descripcionBanco))
            {
                MessageBox.Show(this, "Es necesario ingresar los campos completos para realizar el proceso.", "Agregar Banco", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                CtrlBanco objBanco = new CtrlBanco();
                if (objBanco.AgregarBanco(nombreBanco, descripcionBanco))
                {
                    MessageBox.Show(this, "El registro ha sido agregado exitosamente", "Agregar Banco", MessageBoxButtons.OK, MessageBoxIcon.Information);
               
                    CtrlUtilidades util = new CtrlUtilidades();
                    util.CerrarFormulario<FrmBanco>(Program.objfrmPpal.pnlContenedor);
                    util.AbrirFormulario<FrmBanco>(Program.objfrmPpal.pnlContenedor);
                    this.Close();
                }
                else
                {
                    MessageBox.Show(this, "El registro no ha sido agregado, intente nuevamen", "Agregar Banco", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                TxtNombreBanco.Text = string.Empty;
                TxtDescripcionBanco.Text = string.Empty;

                objBanco = null;
            }


        }

        private void BtnCancelarBanco_Click(object sender, EventArgs e)
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

        private void TxtNombreBanco_TextChanged(object sender, EventArgs e)
        {
            Validar_Texto(TxtNombreBanco, e);
        }

        private void TxtDescripcionBanco_TextChanged(object sender, EventArgs e)
        {
            Validar_Texto(TxtDescripcionBanco,e);
        }
    }
}
