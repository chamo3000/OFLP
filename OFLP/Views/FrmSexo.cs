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
    public partial class FrmSexo : Form
    {
        public FrmSexo()
        {
            InitializeComponent();
        }


        private void FrmSexo_Load(object sender, EventArgs e)
        {
            var @delegate = new delegadoLLenarGrid(LlenarGrid);
            new Task(() => this.label1.BeginInvoke(@delegate)).Start();
        }

        delegate void delegadoLLenarGrid();

    

        private void LlenarGrid()
        {

            CtrlSexo objSexo = new CtrlSexo();
            ClsInicio.sexo.Clear();
            objSexo.LlenarGridSexo();
            DtgSexo.ScrollBars = ScrollBars.Both;
            DtgSexo.Enabled = true;
            pnlConfiguracionSexo.Visible = true;
            DtgSexo.AutoGenerateColumns = false;
            DtgSexo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DtgSexo.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 12);
            foreach (ModSexo item in ClsInicio.sexo)
            {
                DtgSexo.Rows.Add(item.id,item.sexo,item.descripcion);
            }
            if (DtgSexo.DataSource == null)
            {

            }

        }

        private void DtgSexo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lbl_Sexo.Text = DtgSexo.CurrentRow.Cells[1].Value.ToString();
            lblDescripcionSexo.Text = DtgSexo.CurrentRow.Cells[2].Value.ToString();
        }

    

        private void BtnAgregarSexo_Click(object sender, EventArgs e)
        {
            FrmAgregarSexo oFrmAgregarSexo = new FrmAgregarSexo();
            oFrmAgregarSexo.Show();
        }


        private void BtnActualizarSexo_Click(object sender, EventArgs e)
        {
            int columnas = DtgSexo.CurrentRow.Cells.Count;
            string[] datos = new string[columnas];
            for (int i = 0; i < columnas; i++)
            {
                datos[i] = DtgSexo.Rows[DtgSexo.CurrentRow.Index].Cells[i].Value.ToString();
            }

            FrmActualizaSexo oFrmActualiza = new FrmActualizaSexo(datos);
            oFrmActualiza.Show();
        }

        private void BtnEliminarSexo_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esta seguro que desea eliminar el registro de sexo?", "Eliminar Tipo Sexo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {

                string idsexo = DtgSexo.Rows[DtgSexo.CurrentRow.Index].Cells[0].Value.ToString();

                CtrlSexo ObjCtrlSexo = new CtrlSexo();

                if (ObjCtrlSexo.EliminarSexo(idsexo))
                {
                    lbl_Sexo.Text = "";
                    lblDescripcionSexo.Text = "";

                    ClsInicio.sexo.RemoveAll(c => c.id == Convert.ToInt32(idsexo));
                    DtgSexo.Rows.RemoveAt(DtgSexo.CurrentRow.Index);

                }

            }
        }

        private void BtnLimpiarSexo_Click(object sender, EventArgs e)
        {
            TxtBuscarSexo.Text = string.Empty;
            DtgSexo.ScrollBars = ScrollBars.Both;
            DtgSexo.Enabled = true;
            pnlConfiguracionSexo.Visible = true;
            DtgSexo.AutoGenerateColumns = false;
            DtgSexo.Rows.Clear();
            foreach (ModSexo item in ClsInicio.sexo)
            {
                DtgSexo.Rows.Add(item.id, item.sexo, item.descripcion);
            }
        }

        private void BtnBuscarSexo_Click(object sender, EventArgs e)
        {
            string datoBuscar = TxtBuscarSexo.Text.ToUpper();
            List<ModSexo> lstBusqueda = new List<ModSexo>();
            lbl_Sexo.Text = "";
            lblDescripcionSexo.Text = "";

            CtrlSexo objSexo = new CtrlSexo();
            lstBusqueda = objSexo.BuscarSexo(datoBuscar);

            if (lstBusqueda.Count>0)
            {
                DtgSexo.ScrollBars = ScrollBars.Both;
                DtgSexo.Enabled = true;
                pnlConfiguracionSexo.Visible = true;
                DtgSexo.AutoGenerateColumns = false;
                DtgSexo.Rows.Clear();
                foreach (ModSexo item in lstBusqueda)
                {
                    DtgSexo.Rows.Add(item.id, item.sexo, item.descripcion);
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

        private void TxtBuscarSexo_TextChanged(object sender, EventArgs e)
        {
            Validar_Texto(TxtBuscarSexo, e);
        }
    }
}
