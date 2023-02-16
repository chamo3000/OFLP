using OFLP.Controlador;
using OFLP.Modelo;
using System;
using System.Collections.Generic;
using System.Drawing;
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
            if (DtgGanado.Columns[e.ColumnIndex].Name.Equals("Modificar"))
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
            else if (DtgGanado.Columns[e.ColumnIndex].Name.Equals("Eliminar"))
            {
                if (MessageBox.Show("Esta seguro que desea eliminar la Ganado?", "Eliminar Ganado", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    string idganado = DtgGanado.Rows[DtgGanado.CurrentRow.Index].Cells[0].Value.ToString();

                    CtrlGanado ObjCtrlGanado = new CtrlGanado();

                    if (ObjCtrlGanado.EliminarGanado(idganado))
                    {
                        lblNombreBanco.Text = "";
                        lblDescripcionBanco.Text = "";

                        ClsInicio.ganado.RemoveAll(c => c.IdGanado == Convert.ToInt32(idganado));
                        DtgGanado.Rows.RemoveAt(DtgGanado.CurrentRow.Index);
                        MessageBox.Show("Registro Eliminado exitosamente", "Eliminar Clase Ganado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            else
            {
                lbl_ID.Text = DtgGanado.CurrentRow.Cells[0].Value.ToString();
                lblClaseGanado.Text = DtgGanado.CurrentRow.Cells[1].Value.ToString();
                lblClase.Text = DtgGanado.CurrentRow.Cells[2].Value.ToString();
                lblDescripcion.Text = DtgGanado.CurrentRow.Cells[3].Value.ToString();
            }
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
            foreach (Ganado item in ClsInicio.ganado)
            {
                DtgGanado.Rows.Add(item.IdGanado, item.ClaseGanado, item.Clase, item.Descripcion);
            }
        }
        private void Validar_Texto(TextBox Elemento)
        {
            if (Controlador.Restricciones.Tiene_Letras(Elemento.Text.Trim()))
            {
                Elemento.Text = string.Empty;
                MessageBox.Show(this, "Este campo no permite números", "Advertencia ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
            }
        }
        private void TxtBuscarGanado_TextChanged(object sender, EventArgs e)
        {
            Validar_Texto(TxtBuscarGanado);
        }
        private void PicAgregarGanado_Click(object sender, EventArgs e)
        {
            FrmAgregarGanado oFrmAgregarGanado = new FrmAgregarGanado();
            oFrmAgregarGanado.Show();
        }
        private void PicBuscarClase_Click(object sender, EventArgs e)
        {
            string datoBuscar = TxtBuscarGanado.Text.ToUpper();
            CtrlGanado objGanado = new CtrlGanado();
            List<Ganado> lstBusqueda = objGanado.BuscarGanado(datoBuscar);
            lbl_ID.Text = "";
            lblClaseGanado.Text = "";
            lblClase.Text = "";
            lblDescripcion.Text = "";

            if (lstBusqueda.Count > 0)
            {
                DtgGanado.ScrollBars = ScrollBars.Both;
                DtgGanado.Enabled = true;
                pnlConfiguracionGanado.Visible = true;
                DtgGanado.AutoGenerateColumns = false;
                DtgGanado.Rows.Clear();
                foreach (Ganado item in lstBusqueda)
                {
                    DtgGanado.Rows.Add(item.IdGanado, item.ClaseGanado, item.Clase, item.Clase);
                }
            }
            else
            {
                MessageBox.Show("El criterio de busqueda no arroja resultado", "Búsqueda", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void PicLimpiarBusquedaClase_Click(object sender, EventArgs e)
        {
            TxtBuscarGanado.Text = string.Empty;
            DtgGanado.ScrollBars = ScrollBars.Both;
            DtgGanado.Enabled = true;
            pnlConfiguracionGanado.Visible = true;
            DtgGanado.AutoGenerateColumns = false;
            DtgGanado.Rows.Clear();
            foreach (Ganado item in ClsInicio.ganado)
            {
                DtgGanado.Rows.Add(item.IdGanado, item.ClaseGanado, item.Clase, item.Descripcion);
            }
        }
    }
}
