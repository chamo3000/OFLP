using OFLP.Controlador;

using OFLP.Modelo;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace OFLP.Vistas
{
    public partial class FrmCliente : Form
    {

        public FrmCliente()
        {
            InitializeComponent();


        }

        public void FrmCliente_Load(object sender, EventArgs e)
        {

            var @delegate = new delegadoLLenarGrid(LlenarGrid);
            new Task(() => this.label1.BeginInvoke(@delegate)).Start();

        }


        private void DtgPropietario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgPropietario.Columns[e.ColumnIndex].Name.Equals("Modificar"))
            {
                ActualizarCliente(dtgPropietario.CurrentRow.Cells.Count);
            }
            else if (dtgPropietario.Columns[e.ColumnIndex].Name.Equals("Eliminar"))
            {
                if (MessageBox.Show("Esta seguro que desea eliminar el cliente?", "Eliminar Cliente", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    EliminarCliente(dtgPropietario.CurrentRow.Index, dtgPropietario.Rows[dtgPropietario.CurrentRow.Index].Cells[0].Value.ToString());
                }

            }
            else
            {
                lblApellidoUno.Text = dtgPropietario.CurrentRow.Cells[1].Value.ToString();
                lblApellidoDos.Text = dtgPropietario.CurrentRow.Cells[2].Value.ToString();
                lblNombre.Text = dtgPropietario.CurrentRow.Cells[3].Value.ToString();
                lblCedula.Text = dtgPropietario.CurrentRow.Cells[4].Value.ToString();

            }
        }

        #region metodos
        delegate void delegadoLLenarGrid();

        private void LlenarGrid()
        {

            CtrlCliente objPropietario = new CtrlCliente();
            objPropietario.LlenarGridCliente();
            dtgPropietario.ScrollBars = ScrollBars.Both;
            dtgPropietario.Enabled = true;
            pnlConfiguraPropietario.Visible = true;
            dtgPropietario.AutoGenerateColumns = false;
            dtgPropietario.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 12);
            if (ClsInicio.clientes.Count > 0)
            {
                foreach (ModCliente item in ClsInicio.clientes)
                {
                    dtgPropietario.Rows.Add(item.cedulaCliente, item.primerApellido, item.segundoApellido, item.nombreCliente);
                }

            }
            if (dtgPropietario.DataSource == null) lblError.Text = "Error al cargar los datos de la base de datos";
        }
        #endregion
        private void EliminarCliente(int fila, string idCliente)
        {

            
            CtrlCliente ObjCtrlCliente = new CtrlCliente();
            if (ObjCtrlCliente.EliminarCliente(idCliente))
            {

                MessageBox.Show("Cliente Eliminado exitosamente", "Eliminar Cliente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dtgPropietario.Rows.Remove(dtgPropietario.Rows[fila]);
                lblApellidoUno.Text = "";
                lblApellidoDos.Text = "";
                lblNombre.Text = "";
                lblCedula.Text = "";
                lblTipoCliente.Text = "";

            }
            else
            {
                MessageBox.Show("Error al eliminar el cliente, valide e intente de nuevo", "Eliminar Cliente", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            ObjCtrlCliente = null;
            GC.Collect();



        }

        private void ActualizarCliente(int columnas)
        {

            string[] datos = new string[4];
            for (int i = 0; i < columnas-2; i++)
            {
                datos[i] = dtgPropietario.Rows[dtgPropietario.CurrentRow.Index].Cells[i].Value.ToString();
            }

            FrmActualizarCliente objfrmAgregarCliente = new FrmActualizarCliente(datos);
            objfrmAgregarCliente.Show();
        }

        private void Validar_Texto(TextBox Elemento, EventArgs e)
        {

            if (Controlador.Restricciones.Tiene_Letras(Elemento.Text.Trim()))
            {
                Elemento.Text = string.Empty;
                MessageBox.Show(this, "Este campo no permite números", "Advertencia ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
            }
        }

        private void txtBusquedaPropietario_TextChanged(object sender, EventArgs e)
        {
            Validar_Texto(txtBusquedaPropietario, e);
        }

        private void PicBuscarCliente_Click(object sender, EventArgs e)
        {
            string datoBuscar = txtBusquedaPropietario.Text.ToUpper();
            List<ModCliente> lstBusqueda = new List<ModCliente>();
            lblApellidoUno.Text = "";
            lblApellidoDos.Text = "";
            lblNombre.Text = "";
            lblCedula.Text = "";
            lblTipoCliente.Text = "";

            CtrlCliente objPropietario = new CtrlCliente();
            lstBusqueda = objPropietario.BuscarPropietario(datoBuscar);


            if (lstBusqueda.Count > 0)
            {

                objPropietario = null;
                dtgPropietario.ScrollBars = ScrollBars.Both;
                dtgPropietario.Enabled = true;
                pnlConfiguraPropietario.Visible = true;
                dtgPropietario.AutoGenerateColumns = false;
                dtgPropietario.Rows.Clear();
                foreach (ModCliente item in lstBusqueda)
                {
                    dtgPropietario.Rows.Add(item.cedulaCliente, item.primerApellido, item.segundoApellido, item.nombreCliente, item.cedulaCliente, item.descripcion);

                }
            }
            else
            {
                MessageBox.Show("El criterio de busqueda no arroja resultado", "Búsqueda", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }


        }

        private void PicLimpiarBusquedaCliente_Click(object sender, EventArgs e)
        {
            txtBusquedaPropietario.Text = string.Empty;
            dtgPropietario.ScrollBars = ScrollBars.Both;
            dtgPropietario.Enabled = true;
            pnlConfiguraPropietario.Visible = true;
            dtgPropietario.AutoGenerateColumns = false;
            dtgPropietario.Rows.Clear();
            foreach (ModCliente item in ClsInicio.clientes)
            {
                dtgPropietario.Rows.Add(item.cedulaCliente, item.primerApellido, item.segundoApellido, item.nombreCliente, item.cedulaCliente, item.descripcion);
            }
        }

        private void PicAgregarCliente_Click(object sender, EventArgs e)
        {
            frmAgregarCliente objfrmAgregarCliente = new frmAgregarCliente(FrmPpal.TipoCliente);
            objfrmAgregarCliente.Show();
        }
    }
}
