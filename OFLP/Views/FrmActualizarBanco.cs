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
    public partial class FrmActualizarBanco : Form
    {
    
        private string[] datosActualizar { get; set; }
        public FrmActualizarBanco(string[] datos)
        {
            InitializeComponent();
            datosActualizar = datos;
           

        }


        private void FrmActualizarBanco_Load(object sender, EventArgs e)
        {
            TxtActualizarBanco.Text = datosActualizar[1];
            TxtActualizarDescripcion.Text = datosActualizar[2];
        }


        private void ActualizarBancos()
        {
            CtrlUtilidades util = new CtrlUtilidades();

            util.CerrarFormulario<FrmBanco>(Program.objfrmPpal.pnlContenedor);
            Thread.Sleep(1000);
           util.AbrirFormulario<FrmBanco>(Program.objfrmPpal.pnlContenedor);


        }

        private void btnAceptaActualizarAceptar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esta seguro que desea Actualizar el Banco?", "Actualizar Banco", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                if (TxtActualizarBanco.Text.Equals(string.Empty) || TxtActualizarDescripcion.Text.Equals(string.Empty))
                {
                    MessageBox.Show("Debe ingresar nombre del banco ", "Ingrese datos del Banco", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                 
                    datosActualizar[1] = TxtActualizarBanco.Text;
                    datosActualizar[2] = TxtActualizarDescripcion.Text;


                    CtrlBanco objCtrBanco = new CtrlBanco();

                    if (objCtrBanco.ActualizarBanco(datosActualizar))
                    {
                        MessageBox.Show("Banco actualizado exitosamente", "Actualizar Banco", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ActualizarBancos();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Error al actualizar la hacienda, valide e intente nuevamente", "Actualizar Banco", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
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

        private void TxtActualizarBanco_TextChanged(object sender, EventArgs e)
        {
            Validar_Texto(TxtActualizarBanco,e);
        }

        private void TxtActualizarDescripcion_TextChanged(object sender, EventArgs e)
        {
            Validar_Texto(TxtActualizarDescripcion,e);
        }
    }
}


