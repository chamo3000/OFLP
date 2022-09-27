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
    public partial class FrmCuenta : Form
    {
        public FrmCuenta()
        {
            InitializeComponent();
        }


        private void FrmCuenta_Load(object sender, EventArgs e)
        {
            var @delegate = new delegadoLLenarGrid(LlenarGrid);
            new Task(() => this.label1.BeginInvoke(@delegate)).Start();
        }


        private void LlenarGrid()
        {
            CtrlCuenta objCuenta = new CtrlCuenta();
            objCuenta.LlenarGridCuenta();
            dtgCuenta.ScrollBars = ScrollBars.Both;
            dtgCuenta.Enabled = true;
            pnlConfiguraCuenta.Visible = true;
            dtgCuenta.AutoGenerateColumns = false;
            dtgCuenta.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 12);
            dtgCuenta.Rows.Clear();

            foreach (ModCuenta item in ClsInicio.cuenta)
            {
                dtgCuenta.Rows.Add(item.id,item.numeroCuenta,item.ciudad,item.sucursal,item.idCliente,item.IdBanco);
            }

        }

        delegate void delegadoLLenarGrid();

        private void Validar_Texto(TextBox Elemento, EventArgs e)
        {

            if (Controlador.Restricciones.Tiene_Letras(Elemento.Text.Trim()))
            {
                Elemento.Text = string.Empty;
                MessageBox.Show(this, "Este campo no permite números", "Advertencia ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
            }
        }

        private void txtBusquedaCuenta_TextChanged(object sender, EventArgs e)
        {
            Validar_Texto(txtBusquedaCuenta,e);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
        
        }

        private void btnAgregarCuenta_Click(object sender, EventArgs e)
        {
            FrmAgregarCuenta oFrmAgregarCuenta = new FrmAgregarCuenta();
            oFrmAgregarCuenta.Show();
        }
    }
}
