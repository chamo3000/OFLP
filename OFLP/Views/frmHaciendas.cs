using OFLP.Controlador;
using OFLP.Modelo;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace OFLP.Vistas
{
    public partial class FrmHaciendas : Form
    {
        public FrmHaciendas()
        {
            InitializeComponent();
        }

        private void FrmHaciendas_Load(object sender, EventArgs e)
        {
            var @delegate = new delegadoLLenarGrid(LlenarGrid);
            new Task(() => this.label1.BeginInvoke(@delegate)).Start();
        }

        private void LlenarGrid()
        {
            ctrlHacienda objHacienda = new ctrlHacienda();
            objHacienda.LlenarGridHacienda();
            dtgHacienda.ScrollBars = ScrollBars.Both;
            dtgHacienda.Enabled = true;
            pnlConfiguraHacienda.Visible = true;
            dtgHacienda.AutoGenerateColumns = false;
            dtgHacienda.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 12);
            dtgHacienda.Rows.Clear();
            foreach (ModHacienda item in ClsInicio.haciendas)
            {
                dtgHacienda.Rows.Add(item.idHacienda, item.nombreHacienda, item.municipio, item.nombreCliente, item.primerApellido, item.segundoApellido, item.cedulaCliente);
            }
            
        }

        delegate void delegadoLLenarGrid();

        private void DtgHacienda_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lblNombreHacienda.Text = dtgHacienda.CurrentRow.Cells[1].Value.ToString();
            lblMunicipio.Text = dtgHacienda.CurrentRow.Cells[2].Value.ToString();
            lblNombreCliente.Text = dtgHacienda.CurrentRow.Cells[3].Value.ToString();
            lblPrimerAp.Text = dtgHacienda.CurrentRow.Cells[4].Value.ToString();
            lblSegundoAp.Text = dtgHacienda.CurrentRow.Cells[5].Value.ToString();
            lblCedula.Text = dtgHacienda.CurrentRow.Cells[6].Value.ToString();

        }

        private void BtnBuscarHacienda_Click(object sender, EventArgs e)
        {
            string datoBuscar = txtBusquedaHacienda.Text.ToUpper();
            List<ModHacienda> lstBusqueda = new List<ModHacienda>();
            lblNombreHacienda.Text = "";
            lblMunicipio.Text = "";
            lblNombreCliente.Text = "";
            lblPrimerAp.Text = "";
            lblSegundoAp.Text = "";
            lblCedula.Text = "";

            ctrlHacienda objHacienda = new ctrlHacienda();
            lstBusqueda = objHacienda.BuscarHacienda(datoBuscar);

            if (lstBusqueda.Count>0)
            {
                dtgHacienda.ScrollBars = ScrollBars.Both;
                dtgHacienda.Enabled = true;
                pnlConfiguraHacienda.Visible = true;
                dtgHacienda.AutoGenerateColumns = false;
                dtgHacienda.Rows.Clear();
                foreach (ModHacienda item in lstBusqueda)
                {
                    dtgHacienda.Rows.Add(item.idHacienda, item.nombreHacienda, item.municipio, item.nombreCliente, item.primerApellido, item.segundoApellido, item.cedulaCliente);
                }
            }
            else
            {
                MessageBox.Show("El criterio de busqueda no arroja resultado", "Búsqueda", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        private void BtnLimpiarBusquedaPropietario_Click(object sender, EventArgs e)
        {
            txtBusquedaHacienda.Text = string.Empty;
            dtgHacienda.ScrollBars = ScrollBars.Both;
            dtgHacienda.Enabled = true;
            pnlConfiguraHacienda.Visible = true;
            dtgHacienda.AutoGenerateColumns = false;
            dtgHacienda.Rows.Clear();
            foreach (ModHacienda item in ClsInicio.haciendas)
            {
                dtgHacienda.Rows.Add(item.idHacienda, item.nombreHacienda, item.municipio, item.nombreCliente, item.primerApellido, item.segundoApellido, item.cedulaCliente);
            }
        }

        private void BtnAgregarHacienda_Click(object sender, EventArgs e)
        {
            frmAgregarHacienda objAgregarHacienda = new frmAgregarHacienda();
            objAgregarHacienda.Show();

            
        }

        private void BtnActualizaHacienda_Click(object sender, EventArgs e)
        {

            int columnas = dtgHacienda.CurrentRow.Cells.Count;
            string[] datos = new string[columnas];
            for (int i = 0; i < columnas; i++)
            {
                datos[i] = dtgHacienda.Rows[dtgHacienda.CurrentRow.Index].Cells[i].Value.ToString();
            }
            FrmActualizarHacienda objActualizarHacienda = new FrmActualizarHacienda(datos);
            objActualizarHacienda.Show();
        }

        private void BtnEliminarHacienda_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esta seguro que desea eliminar la Hacienda?", "Eliminar Hacienda", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {

                string idHacienda = dtgHacienda.Rows[dtgHacienda.CurrentRow.Index].Cells[0].Value.ToString();

                ctrlHacienda ObjCtrlHacienda = new ctrlHacienda();

                if (ObjCtrlHacienda.EliminarHacienda(idHacienda))
                {
                    lblNombreHacienda.Text = "";
                    lblMunicipio.Text = "";
                    lblNombreCliente.Text = "";
                    lblPrimerAp.Text = "";
                    lblSegundoAp.Text = "";
                    lblCedula.Text = "";
                    ClsInicio.haciendas.RemoveAll(c => c.idHacienda == Convert.ToInt32(idHacienda)); 
                    dtgHacienda.Rows.RemoveAt(dtgHacienda.CurrentRow.Index);



                }


            }
        }


        private void Validar_Texto(TextBox Elemento, EventArgs e)
        {

            if (Controlador.Restricciones.Tiene_Letras(Elemento.Text.Trim()))
            {
                Elemento.Text = string.Empty;
                MessageBox.Show(this, "Este campo no permite números", "Advertencia ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
            }
        }

        private void txtBusquedaHacienda_TextChanged(object sender, EventArgs e)
        {
            Validar_Texto(txtBusquedaHacienda, e);
        }
    }
}
