using OFLP.Controlador;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OFLP.Vistas
{
    public partial class FrmActualizaSexo : Form
    {
        private string[] datosActualizar { get; set; }
      

        public FrmActualizaSexo(string[] datos)
        {
            InitializeComponent();
            datosActualizar = datos;
        }

        private void FrmActualizarSexo_Load(object sender, EventArgs e)
        {
            TxtActualizarSexo.Text = datosActualizar[1];
            TxtActualizarDescripcion.Text = datosActualizar[2];
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnAceptarActualizar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esta seguro que desea Actualizar el cliente?", "Eliminar Cliente", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                if (TxtActualizarSexo.Text.Equals(string.Empty) || TxtActualizarDescripcion.Text.Equals(string.Empty))
                {
                    MessageBox.Show("Debe ingresar nombre del banco ", "Ingrese datos del Banco", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {

                    datosActualizar[1] = TxtActualizarSexo.Text;
                    datosActualizar[2] = TxtActualizarDescripcion.Text;


                    CtrlSexo objCtrSexo = new CtrlSexo();

                    if (objCtrSexo.ActualizarSexo(datosActualizar))
                    {
                        MessageBox.Show("Hacienda actualizada exitosamente", "Actualizar Hacienda", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ActualizarSexo();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Error al actualizar la hacienda, valide e intente nuevamente", "Actualizar Hacienda", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }


        private void ActualizarSexo()
        {
            CtrlUtilidades util = new CtrlUtilidades();

            util.CerrarFormulario<FrmSexo>(Program.objfrmPpal.pnlContenedor);
            Thread.Sleep(1000);
            util.AbrirFormulario<FrmSexo>(Program.objfrmPpal.pnlContenedor);


        }

        private void Validar_Texto(TextBox Elemento, EventArgs e)
        {

            if (Controlador.Restricciones.Tiene_Letras(Elemento.Text.Trim()))
            {
                Elemento.Text = string.Empty;
                MessageBox.Show(this, "Este campo no permite números", "Advertencia ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
            }
        }


        private void TxtActualizarSexo_TextChanged(object sender, EventArgs e)
        {
            Validar_Texto(TxtActualizarSexo,e);
        }

        private void TxtActualizarDescripcion_TextChanged(object sender, EventArgs e)
        {
            Validar_Texto(TxtActualizarDescripcion,e);
        }
    }
}
