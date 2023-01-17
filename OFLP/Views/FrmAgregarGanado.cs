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
    public partial class FrmAgregarGanado : Form
    {
        public FrmAgregarGanado()
        {
            InitializeComponent();
        }
        private void BtnAceptarInsertar_Click(object sender, EventArgs e)
        {
            string claseGanado = TxtInsertarGanado.Text.ToUpper();
            string clase = TxtInsertarClase.Text;
            string descripcion = TxtInsertarDescripcion.Text;

            if (string.IsNullOrEmpty(claseGanado) || string.IsNullOrEmpty(clase) || string.IsNullOrEmpty(descripcion))
            {
                MessageBox.Show(this, "Es necesario ingresar los campos completos para realizar el proceso.", "Agregar Ganado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                CtrlGanado objGanado = new CtrlGanado();
                if (objGanado.AgregarGanado(claseGanado, clase, descripcion))
                {
                    MessageBox.Show(this, "El registro ha sido agregado exitosamente", "Agregar Ganado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    CtrlUtilidades util = new CtrlUtilidades();
                    util.CerrarFormulario<FrmGanado>(Program.objfrmPpal.pnlContenedor);
                    util.AbrirFormulario<FrmGanado>(Program.objfrmPpal.pnlContenedor);
                    this.Close();
                }
                else
                {
                    MessageBox.Show(this, "El registro no ha sido agregado, intente nuevamente", "Agregar Ganado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                TxtInsertarGanado.Text = string.Empty;
                TxtInsertarClase.Text = string.Empty;
                TxtInsertarDescripcion.Text = string.Empty;
            }
        }
        private void Validar_Texto(TextBox Elemento)
        {
            if (Controlador.Restricciones.Tiene_Letras(Elemento.Text.Trim()))
            {
                Elemento.Text = string.Empty;
                MessageBox.Show(this, "Este campo no permite números", "Advertencia ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
            }
        }
        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void TxtInsertarGanado_TextChanged(object sender, EventArgs e)
        {
            Validar_Texto(TxtInsertarGanado);
        }
        private void TxtInsertarClase_TextChanged(object sender, EventArgs e)
        {
            Validar_Texto(TxtInsertarClase);
        }

    }
}
