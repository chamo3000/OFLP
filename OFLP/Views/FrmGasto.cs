using OFLP.Controlador;
using OFLP.Controller;
using OFLP.Model;
using OFLP.Vistas;
using System;
using System.Linq;
using System.Windows.Forms;

namespace OFLP.Views
{
    public partial class FrmGasto : Form
    {
        private long IdFactura { get; set; }
        private int IdCliente { get; set; }
        private int Reunion { get; set; }
        private readonly int total;
        

        public FrmGasto(string idFactura, int idCliente, int reunion,int total)
        {
            InitializeComponent();
            IdFactura = Convert.ToInt64(idFactura);
            IdCliente = idCliente;
            Reunion = reunion;
            this.total= total;
            CargaPorcentajes();
        }
        private void BtnTerminarGuardar_Click(object sender, EventArgs e)
        {
            CtrlUtilidades.ImprimirLog("Ingresa a modulo gastos");
            string[] lstDatosIngresar = new string[13];
            lstDatosIngresar[0] = Reunion.ToString();
            lstDatosIngresar[1] = IdCliente.ToString();
            lstDatosIngresar[2] = TxtFeriaBascula.Text;
            lstDatosIngresar[3] = TxtTranposte.Text;
            lstDatosIngresar[4] = "0";
            lstDatosIngresar[5] = TxtRecibida.Text;
            lstDatosIngresar[6] = txtComision.Text;
            lstDatosIngresar[7] = "0";
            lstDatosIngresar[8] = TxtVacunas.Text;
            lstDatosIngresar[9] = TxtAnticipos.Text;
            lstDatosIngresar[10] = TxtOtros.Text;
            lstDatosIngresar[11] = TxtObservaciones.Text;
            lstDatosIngresar[12] = IdFactura.ToString();
            
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

        private void CargaPorcentajes()
        {
            CtrlPorcentaje objPorcentajes= new CtrlPorcentaje();
            if (!objPorcentajes.LlenarGridPorcentaje())
            {
                MessageBox.Show("Error al cargar los porcentajes de gasto");
                CtrlUtilidades.ImprimirLog("Error al cargar los porcentajes de gasto");
            }

        }

        private void PnlContenedorGasto_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FrmGasto_Load(object sender, EventArgs e)
        {
            foreach(MPorcentaje item in ClsInicio.Porcentajes)
            {
                TxtFeriaBascula.Text = (total * (item.Feria / 100)).ToString("0,0");
                TxtRecibida.Text = (total * (item.Recibida / 100)).ToString("0,0");
                txtComision.Text= (total * (item.Comision / 100)).ToString("0,0");
            }
        }
    }
}
