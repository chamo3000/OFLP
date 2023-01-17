using OFLP.Controlador;
using OFLP.Model;
using OFLP.Modelo;
using System;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OFLP.Vistas
{
    public partial class FrmFactura : Form
    {
        public FrmFactura()
        {
            InitializeComponent();
        }
        private void FrmFactura_Load(object sender, EventArgs e)
        {
            LimpiarControles();
            var @delegate = new delegadoLLenarGrid(LlenarGrid);
            new Task(() => this.label1.BeginInvoke(@delegate)).Start();
            Thread hilo = new Thread(CargarClientes);
            hilo.Start();
        }
        delegate void delegadoLLenarGrid();

        private void CargarClientes()
        {
            CtrlCliente ObjCliente = new CtrlCliente();
            if (ClsInicio.clientes.Count == 0)
            {
                
                ObjCliente.LlenarGridCliente();
            }

        }
        private void LlenarGrid()
        {
            CtrlFactura objFactura = new CtrlFactura();
            objFactura.LlenarGridFactura();
            DtgFactura.ScrollBars = ScrollBars.Both;
            DtgFactura.Enabled = true;
            pnlConfiguraHacienda.Visible = true;
            DtgFactura.AutoGenerateColumns = false;
            DtgFactura.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 12);
            DtgFactura.Rows.Clear();
            foreach (MFactura item in ClsInicio.Factura)
            {
                int gasto;
                string propietario;
                int IdFact = Convert.ToInt32(item.NumeroFactura);
                int IdPropietario = Convert.ToInt32(item.PropietarioID);
                using (MIGANEntities db = new MIGANEntities())
                {
                    
                     gasto = db.GASTO.FirstOrDefault(p => p.idfactura == IdFact).Total;
                    propietario = $"{db.CLIENTE.FirstOrDefault(p => p.CEDULA == IdPropietario).NOMBRE} {db.CLIENTE.FirstOrDefault(p => p.CEDULA == IdPropietario).PRIMERAPELLIDO}";

                }
                
                DtgFactura.Rows.Add(item.NumeroFactura, item.Reunion, propietario, gasto.ToString(), Convert.ToInt32(item.ValorTotal).ToString("N") );
            }

        }
        private void LimpiarControles()
        {
            LblNumFactura.Text = string.Empty;
            LblReunion.Text = string.Empty;
            lblFecha.Text = string.Empty;
            lblPropietario.Text = string.Empty;
            LblClase.Text = string.Empty;
            LblCorral.Text = string.Empty;
            LblCabezas.Text = string.Empty;
            LblSexo.Text = string.Empty;
            LblComprador.Text = string.Empty;
            LblKilos.Text = string.Empty;
            LblValorKilo.Text = string.Empty;
            LblValorTotal.Text = string.Empty;
        }
        private void BtnEliminarHacienda_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esta seguro que desea eliminar la Factura?", "Eliminar Factura", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {

                string consecutivo = DtgFactura.Rows[DtgFactura.CurrentRow.Index].Cells[0].Value.ToString();

                CtrlFactura ObjCtrlFactura = new CtrlFactura();

                if (ObjCtrlFactura.EliminarFactura(consecutivo))
                {
                    LimpiarControles();
                    ClsInicio.Factura.RemoveAll(c => c.NumeroFactura == Convert.ToDouble(consecutivo));
                    DtgFactura.Rows.RemoveAt(DtgFactura.CurrentRow.Index);



                }
            }
        }
        private void PicAgregarFactura_Click(object sender, EventArgs e)
        {
            FrmAgregarFactura f = new FrmAgregarFactura(DtgFactura);
            f.Show();
        }

    }
}
