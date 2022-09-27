using OFLP.Controlador;
using OFLP.Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace OFLP.Vistas
{

    public partial class FrmActualizarHacienda : Form
    {

        private string[] DatosActualizar { get; set; }
        List<ModCliente> compradores = new List<ModCliente>();

        public FrmActualizarHacienda(string[] datosActualizar)
        {
            InitializeComponent();
            this.DatosActualizar = datosActualizar;

        }

        private void FrmActualizarHacienda_Load(object sender, EventArgs e)
        {
            cmbDueñoHacienda.SelectedIndex = 0;
            LlenaComboCliente();
            SelecionaDueño();
            txtNombreHacienda.Text = DatosActualizar[1];
            txtxtMunicipioHacienda.Text = DatosActualizar[2];
        }

        private void LlenaComboCliente()
        {

            List<ModCliente> noExisten = new List<ModCliente>();
            ModCliente ObjCliente = new ModCliente();
            try
            {
                ObjCliente.LlenarGrid();
                compradores = ClsInicio.clientes;
                compradores = compradores.OrderBy(x => x.primerApellido).ToList();
                //ObjCliente.LlenarGrid();
                //ObjCliente = null;
                bool band = false;
                foreach (ModCliente item in ClsInicio.clientes)
                {
                    band = false;
                    foreach (ModCliente item2 in compradores)
                    {
                        if (item2.idCliente == item.idCliente) band = true;
                    }

                    if (!band)
                    {
                        noExisten.Add(item);
                    }
                }
                compradores.AddRange(noExisten);
                foreach (ModCliente item in compradores)
                {
                    if (!item.nombreCliente.Equals(string.Empty))
                    {
                        cmbDueñoHacienda.Items.Add(item.primerApellido + " " + item.nombreCliente);
                    }

                }
            }
            catch
            {
                // error
            }

        }

        private void SelecionaDueño()
        {
            int cont = 0;
            string nombre = DatosActualizar[3];
            string apellido = DatosActualizar[4];
            foreach (string item in cmbDueñoHacienda.Items)
            {
                if (item.Contains(nombre.Trim()) && item.Contains(apellido.Trim()))
                {
                    cmbDueñoHacienda.SelectedIndex = cont;
                    break;
                }
                cont++;
            }

        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnAceptaActualizarHacienda_Click(object sender, EventArgs e)
        {
        if (MessageBox.Show("Esta seguro que desea Actualizar el cliente?", "Eliminar Cliente", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                if (txtNombreHacienda.Text.Equals(string.Empty) || txtxtMunicipioHacienda.Text.Equals(string.Empty))
                {
                    MessageBox.Show("Debe ingresar el primer apellido y nombre ", "Ingrese datos del Cliente", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    DatosActualizar[1] = txtNombreHacienda.Text;
                    DatosActualizar[2] = txtxtMunicipioHacienda.Text;
                    DatosActualizar[3] = cmbDueñoHacienda.Text;

                    ctrlHacienda objCtrlHacienda = new ctrlHacienda();

                    if (objCtrlHacienda.ActualizarHacienda(DatosActualizar))
                    {
                        MessageBox.Show("Hacienda actualizada exitosamente", "Actualizar Hacienda", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ActualizarGridHacienda();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Error al actualizar la hacienda, valide e intente nuevamente", "Actualizar Hacienda", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }    

        }

        private void ActualizarGridHacienda()
        {
            CtrlUtilidades util = new CtrlUtilidades();

            util.CerrarFormulario<FrmHaciendas>(Program.objfrmPpal.pnlContenedor);
            util.AbrirFormulario<FrmHaciendas>(Program.objfrmPpal.pnlContenedor);


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
    }
}
