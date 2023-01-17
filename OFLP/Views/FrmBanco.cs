using OFLP.Controlador;
using OFLP.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OFLP.Vistas
{
    public partial class FrmBanco : Form
    {
     
        public FrmBanco()
        {
            
            InitializeComponent();
        }

        private void FrmBanco_Load(object sender, EventArgs e)
        {
            var @delegate = new delegadoLLenarGrid(LlenarGrid);
            new Task(() => this.label1.BeginInvoke(@delegate)).Start();

        }

        delegate void delegadoLLenarGrid();

        private void DtgBanco_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lblNombreBanco.Text = DtgBanco.CurrentRow.Cells[1].Value.ToString();
            lblDescripcionBanco.Text = DtgBanco.CurrentRow.Cells[2].Value.ToString();
        }

        private void LlenarGrid()
        {
            
            CtrlBanco objBanco = new CtrlBanco();
            ClsInicio.banco.Clear();
            objBanco.LlenarGridBanco();
            DtgBanco.ScrollBars = ScrollBars.Both;
            DtgBanco.Enabled = true;
            pnlConfiguracionBanco.Visible = true;
            DtgBanco.AutoGenerateColumns = false;
            DtgBanco.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DtgBanco.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 12);

            foreach (Banco item in ClsInicio.banco)
            {
                DtgBanco.Rows.Add(item.IdBanco, item.NombreBanco, item.DescripcionBanco);
            }
            if (DtgBanco.DataSource == null)
            {

            }

        }

        private void btnAgregarBanco_Click(object sender, EventArgs e)
        {
            FrmAgregarBanco oFrmAgregarBanco = new FrmAgregarBanco();
            oFrmAgregarBanco.Show();
        }

        private void BtnActualizaBanco_Click(object sender, EventArgs e)
        {
       
            int columnas = DtgBanco.CurrentRow.Cells.Count;
            string[] datos = new string[columnas];
            for (int i = 0; i < columnas; i++)
            {
                datos[i] = DtgBanco.Rows[DtgBanco.CurrentRow.Index].Cells[i].Value.ToString();
            }

            FrmActualizarBanco oFrmAgregarBanco = new FrmActualizarBanco(datos);
            oFrmAgregarBanco.Show();

        }

        private void btnEliminarBanco_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esta seguro que desea eliminar la Banco?", "Eliminar Banco", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {

                string idbanco = DtgBanco.Rows[DtgBanco.CurrentRow.Index].Cells[0].Value.ToString();

                CtrlBanco ObjCtrlBanco = new CtrlBanco();

                if (ObjCtrlBanco.EliminarBanco(idbanco))
                {
                    lblNombreBanco.Text = "";
                    lblDescripcionBanco.Text = "";
                   
                    ClsInicio.banco.RemoveAll(c => c.IdBanco == Convert.ToInt32(idbanco));
                    DtgBanco.Rows.RemoveAt(DtgBanco.CurrentRow.Index);



                }


            }
        }

        private void btnBuscarBanco_Click(object sender, EventArgs e)
        {
            string datoBuscar = txtBusquedaBanco.Text.ToUpper();
            List<Banco> lstBusqueda = new List<Banco>();
            lblNombreBanco.Text = "";
            lblDescripcionBanco.Text = "";

            CtrlBanco objBanco = new CtrlBanco();
            lstBusqueda = objBanco.BuscarBanco(datoBuscar);

            if (lstBusqueda.Count>0)
            {
                DtgBanco.ScrollBars = ScrollBars.Both;
                DtgBanco.Enabled = true;
                pnlConfiguracionBanco.Visible = true;
                DtgBanco.AutoGenerateColumns = false;
                DtgBanco.Rows.Clear();
                foreach (Banco item in lstBusqueda)
                {
                    DtgBanco.Rows.Add(item.IdBanco, item.NombreBanco, item.DescripcionBanco);
                }
            }
            else
            {
                MessageBox.Show("El criterio de busqueda no arroja resultado", "Búsqueda", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

        }

        private void btnLimpiarBusquedaBanco_Click(object sender, EventArgs e)
        {
            txtBusquedaBanco.Text = string.Empty;
            DtgBanco.ScrollBars = ScrollBars.Both;
            DtgBanco.Enabled = true;
            pnlConfiguracionBanco.Visible = true;
            DtgBanco.AutoGenerateColumns = false;
            DtgBanco.Rows.Clear();
            foreach (Banco item in ClsInicio.banco)
            {
                DtgBanco.Rows.Add(item.IdBanco, item.NombreBanco, item.DescripcionBanco);
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
        private void txtBusquedaBanco_TextChanged(object sender, EventArgs e)
        {
            Validar_Texto(txtBusquedaBanco,e);
        }
    }
}
