using OFLP.Controlador;
using OFLP.Controller;
using OFLP.Vistas;
using System;
using System.Windows.Forms;

namespace OFLP.Views
{
    public partial class FrmGasto : Form
    {
        private string IdFactura { get; set; }
        private int IdCliente { get; set; }
        private int Reunion { get; set; }
        

        public FrmGasto(string idFactura, int idCliente, int reunion)
        {
            InitializeComponent();
            IdFactura = idFactura;
            IdCliente = idCliente;
            Reunion = reunion;
        }
        private void BtnTerminarGuardar_Click(object sender, EventArgs e)
        {
            CtrlUtilidades.ImprimirLog("Ingresa a modulo gastos");
            string[] lstDatosIngresar = new string[13];
            lstDatosIngresar[0] = Reunion.ToString();
            lstDatosIngresar[1] = IdCliente.ToString();
            lstDatosIngresar[2] = TxtFeriaBascula.Text;
            lstDatosIngresar[3] = TxtTranposte.Text;
            lstDatosIngresar[4] = txtBaños.Text;
            lstDatosIngresar[5] = TxtRecibida.Text;
            lstDatosIngresar[6] = txtComiFlaco.Text;
            lstDatosIngresar[7] = TxtComiGordo.Text;
            lstDatosIngresar[8] = TxtVacunas.Text;
            lstDatosIngresar[9] = TxtAnticipos.Text;
            lstDatosIngresar[10] = TxtOtros.Text;
            lstDatosIngresar[11] = TxtObservaciones.Text;
            lstDatosIngresar[12] = IdFactura;
            
            GastosContoller objCtrlCliente = new GastosContoller(lstDatosIngresar);
            if (objCtrlCliente.InsertarGasto())
            {
                MessageBox.Show("Gasto agregado exitosamente", "Agregar Gasto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CtrlUtilidades.ImprimirLog("Gasto Agregado exitosamente");
                this.Close();
            }
            else
            {
                CtrlUtilidades.ImprimirLog("Error al agregar el gasto");
                MessageBox.Show("Error al agregar el gasto, valide e intente nuevamente", "Agregar Gasto", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
