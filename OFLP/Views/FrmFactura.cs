using OFLP.Controlador;
using OFLP.Model;
using OFLP.Modelo;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OFLP.Vistas
{
    public partial class FrmFactura : Form
    {
        private int idPropietario;
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
                idPropietario = Convert.ToInt32(item.PropietarioID);
                using (MIGANEntities db = new MIGANEntities())
                {
                    gasto = db.GASTO.FirstOrDefault(p => p.idfactura == IdFact).Total;
                    propietario = $"{db.CLIENTE.FirstOrDefault(p => p.CEDULA == idPropietario).NOMBRE} {db.CLIENTE.FirstOrDefault(p => p.CEDULA == idPropietario).PRIMERAPELLIDO}";
                    item.ValorTotal =  db.FACTURA.Where(p=>p.consecutivo==item.NumeroFactura).Sum(x => x.valortotal);
                }
                var factExist = BuscarLINQ(IdFact.ToString(), "idFactura", DtgFactura);
                if(!factExist)DtgFactura.Rows.Add(item.NumeroFactura, item.Reunion, propietario, gasto.ToString(), Convert.ToInt32(item.ValorTotal).ToString("N") );
            }
            DtgFactura.ClearSelection();
        }

        private bool BuscarLINQ(string TextoABuscar, string Columna, DataGridView grid)
        {
            
                bool encontrado = false;
                if (TextoABuscar == string.Empty) return false;
                if (grid.RowCount == 0) return false;
                grid.ClearSelection();
                if (Columna == string.Empty)
                {
                    IEnumerable<DataGridViewRow> obj = (from DataGridViewRow row in grid.Rows.Cast<DataGridViewRow>()
                                                        from DataGridViewCell cells in row.Cells
                                                        where cells.OwningRow.Equals(row) && cells.Value.ToString() == TextoABuscar
                                                        select row);
                    if (obj.Any())
                    {
                        grid.Rows[obj.FirstOrDefault().Index].Selected = true;
                        return true;
                    }
                }
                else
                {
                    IEnumerable<DataGridViewRow> obj = (from DataGridViewRow row in grid.Rows.Cast<DataGridViewRow>()
                                                        where row.Cells[Columna].Value.ToString() == TextoABuscar
                                                        select row);
                    if (obj.Any())
                    {
                        grid.Rows[obj.FirstOrDefault().Index].Selected = true;
                        return true;
                    }
                }
                return encontrado;
            }
        private void LimpiarControles()
        {
            LblNumFactura.Text = string.Empty;
            LblReunion.Text = string.Empty;
            lblPropietario.Text = string.Empty;
            LblGasto.Text = string.Empty;
            LblValorTotal.Text = string.Empty;
        }
        private void PicAgregarFactura_Click(object sender, EventArgs e)
        {
            if (ClsInicio.clientes.Count > 0)
            {
                FrmAgregarFactura f = new FrmAgregarFactura(DtgFactura);
                f.Show();
            }
            else MessageBox.Show("La lista de clientes se encuentra vacia, debe registrar clientes para realizar la carga de facturas", "Error Cliente", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void DtgFactura_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var opcion = DtgFactura.Columns[e.ColumnIndex].Name;
            var idFactura = DtgFactura.Rows[DtgFactura.CurrentRow.Index].Cells[0].Value.ToString();
            

            switch (opcion)
            {
                case "Modificar":
                    ActualizarFactura form = new ActualizarFactura(DtgFactura, idFactura,idPropietario,e.RowIndex);
                    form.ShowDialog();

                    break;
                case "Eliminar":
                    if (MessageBox.Show("Esta seguro que desea eliminar la factura?", "Eliminar Factura", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                    {
                        CtrlFactura delFact = new CtrlFactura();
                        if (delFact.EliminarFactura(idFactura))
                        {
                            DtgFactura.Rows.Remove(DtgFactura.CurrentRow);
                            MessageBox.Show("Factura eliminada correctamente","Eliminar Factura",MessageBoxButtons.OK,MessageBoxIcon.Information);
                        }
                        else MessageBox.Show("La factura no ha sido eliminada", "Eliminar Factura", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    break;
                default:
                    LblNumFactura.Text = DtgFactura.CurrentRow.Cells["idFactura"].Value.ToString();
                    LblReunion.Text = DtgFactura.CurrentRow.Cells["reunion"].Value.ToString();
                    lblPropietario.Text = DtgFactura.CurrentRow.Cells["propietario"].Value.ToString();
                    LblGasto.Text = DtgFactura.CurrentRow.Cells["Gastos"].Value.ToString();
                    LblValorTotal.Text= DtgFactura.CurrentRow.Cells["valortotal"].Value.ToString();
                    break;
            }
        }
    }
}
