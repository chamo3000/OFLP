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
    public partial class FrmGanado : Form
    {
        public FrmGanado()
        {
            InitializeComponent();

        }

        private void FrmGanado_Load(object sender, EventArgs e)
        {
            var @delegate = new delegadoLLenarGrid(LlenarGrid);
            new Task(() => this.label1.BeginInvoke(@delegate)).Start();
        }


        delegate void delegadoLLenarGrid();

        private void DtgGanado_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lbl_ID.Text = DtgGanado.CurrentRow.Cells[0].Value.ToString();
            lblClaseGanado.Text = DtgGanado.CurrentRow.Cells[1].Value.ToString();
            lblClase.Text = DtgGanado.CurrentRow.Cells[2].Value.ToString();
            lblDescripcion.Text = DtgGanado.CurrentRow.Cells[3].Value.ToString();
        }

        private void LlenarGrid()
        {
            CtrlGanado objGanado = new CtrlGanado();
            ClsInicio.ganado.Clear();
            objGanado.LlenarGridGanado();
            DtgGanado.ScrollBars = ScrollBars.Both;
            DtgGanado.Enabled = true;
            pnlConfiguracionGanado.Visible = true;
            DtgGanado.AutoGenerateColumns = false;
            DtgGanado.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DtgGanado.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 12);
            foreach (ModGanado item in ClsInicio.ganado)
            {
                DtgGanado.Rows.Add(item.idGanado, item.claseGanado, item.clase, item.descripcion);
            }
            if (DtgGanado.DataSource == null)
            {

                //lblError.Text = "Error al cargar los datos de la base de datos";
            }

        }


        private void btnAgregarGanado_Click(object sender, EventArgs e)
        {

            FrmAgregarGanado oFrmAgregarGanado = new FrmAgregarGanado();
            oFrmAgregarGanado.Show();
        }

        private void BtnActualizarGanado_Click(object sender, EventArgs e)
        {
            int columnas = DtgGanado.CurrentRow.Cells.Count;
            string[] datos = new string[columnas];
            for (int i = 0; i < columnas; i++)
            {
                datos[i] = DtgGanado.Rows[DtgGanado.CurrentRow.Index].Cells[i].Value.ToString();
            }

            FrmActualizarGanado oFrmActualizarGanado = new FrmActualizarGanado(datos);
            oFrmActualizarGanado.Show();
        }

        private void BtnEliminarGanado_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esta seguro que desea eliminar la Ganado?", "Eliminar Ganado", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {

                string idganado = DtgGanado.Rows[DtgGanado.CurrentRow.Index].Cells[0].Value.ToString();

                CtrlGanado ObjCtrlGanado = new CtrlGanado();

                if (ObjCtrlGanado.EliminarGanado(idganado))
                {
                    lblNombreBanco.Text = "";
                    lblDescripcionBanco.Text = "";

                    ClsInicio.ganado.RemoveAll(c => c.idGanado == Convert.ToInt32(idganado));
                    DtgGanado.Rows.RemoveAt(DtgGanado.CurrentRow.Index);



                }


            }
        }

        private void BtnLimpiarGanado_Click(object sender, EventArgs e)
        {
            TxtBuscarGanado.Text = string.Empty;
            DtgGanado.ScrollBars = ScrollBars.Both;
            DtgGanado.Enabled = true;
            pnlConfiguracionGanado.Visible = true;
            DtgGanado.AutoGenerateColumns = false;
            DtgGanado.Rows.Clear();
            foreach (ModGanado item in ClsInicio.ganado)
            {
                DtgGanado.Rows.Add(item.idGanado, item.claseGanado, item.clase, item.descripcion);
            }
        }

        private void BtnBuscarGanado_Click(object sender, EventArgs e)
        {
            string datoBuscar = TxtBuscarGanado.Text.ToUpper();
            List<ModGanado> lstBusqueda = new List<ModGanado>();
            lbl_ID.Text = "";
            lblClaseGanado.Text = "";
            lblClase.Text = "";
            lblDescripcion.Text = "";

            CtrlGanado objGanado = new CtrlGanado();
            lstBusqueda = objGanado.BuscarGanado(datoBuscar);

            if (lstBusqueda.Count>0)
            {
                DtgGanado.ScrollBars = ScrollBars.Both;
                DtgGanado.Enabled = true;
                pnlConfiguracionGanado.Visible = true;
                DtgGanado.AutoGenerateColumns = false;
                DtgGanado.Rows.Clear();
                foreach (ModGanado item in lstBusqueda)
                {
                    DtgGanado.Rows.Add(item.idGanado, item.claseGanado, item.clase, item.clase);
                }
            }
            else
            {
                MessageBox.Show("El criterio de busqueda no arroja resultado", "Búsqueda", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void TxtBuscarGanado_TextChanged(object sender, EventArgs e)
        {
            Validar_Texto(TxtBuscarGanado, e);
        }
    }
}
