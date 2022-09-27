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
    public partial class FrmActualizarGanado : Form
    {
        private string[] DatosActualizar { get; set; }
   

        public FrmActualizarGanado(string[] datosActualizar)
        {
            CtrlGanado objCtrlGanado = new CtrlGanado();
            
            InitializeComponent();
            DatosActualizar = datosActualizar;

        }

        private void FrmActualizarGanado_Load(object sender, EventArgs e)
        {
            TxtActualizarGanado.Text = DatosActualizar[1];
            TxtActualizarClase.Text = DatosActualizar[2];
            TxtActualizarDescripcion.Text = DatosActualizar[3];
        }

      
        private void BtnAceptarActualizar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esta seguro que desea Actualizar la Clase de ganado?", "Actualizar Ganado", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                if (TxtActualizarGanado.Text.Equals(string.Empty) || TxtActualizarClase.Text.Equals(string.Empty) || TxtActualizarDescripcion.Text.Equals(string.Empty))
                {
                    MessageBox.Show("Debe ingresar tipo ganado, la clase y descripcion ", "Ingrese datos del Ganado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    DatosActualizar[1] = TxtActualizarGanado.Text;
                    DatosActualizar[2] = TxtActualizarClase.Text;
                    DatosActualizar[3] = TxtActualizarDescripcion.Text;

                    CtrlGanado objCtrlGanado = new CtrlGanado();

                    if (objCtrlGanado.ActualizarGanado(DatosActualizar))
                    {
                        MessageBox.Show("Hacienda actualizada exitosamente", "Actualizar Ganado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ActualizarGanado();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Error al actualizar Clase de ganado, valide e intente nuevamente", "Actualizar Ganado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }


        private void ActualizarGanado()
        {
            CtrlUtilidades util = new CtrlUtilidades();

            util.CerrarFormulario<FrmGanado>(Program.objfrmPpal.pnlContenedor);
            Thread.Sleep(1000);
            util.AbrirFormulario<FrmGanado>(Program.objfrmPpal.pnlContenedor);


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


        private void TxtActualizarGanado_TextChanged(object sender, EventArgs e)
        {
            Validar_Texto(TxtActualizarGanado,e);
        }

        private void TxtActualizarClase_TextChanged(object sender, EventArgs e)
        {
            Validar_Texto(TxtActualizarClase,e);
        }

        private void TxtActualizarDescripcion_TextChanged(object sender, EventArgs e)
        {
            Validar_Texto(TxtActualizarDescripcion,e);
        }
    }
}
