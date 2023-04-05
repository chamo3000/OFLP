using OFLP.Controlador;
using OFLP.Views;
using System;
using System.Configuration;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace OFLP.Vistas
{
    public partial class FrmPpal : Form
    {
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        public static int TipoCliente;
        private bool auxCerrar = false;
        private void PnlBarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
        }
        public FrmPpal()
        {
           
            InitializeComponent();
        }
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esta seguro que desea salir?", "Salir", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                auxCerrar = true;
                Application.Exit();

            }
        }
        private void btnMaximizar_Click(object sender, EventArgs e)
        {
        }
        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnMaximizar.Visible = true;
            btnRestaurar.Visible = false;
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnDatos_MouseEnter(object sender, EventArgs e)
        {
        }

        private void btnDatos_MouseLeave(object sender, EventArgs e)
        {
        }

        private void btnDatos_Click(object sender, EventArgs e)
        {
            if (pnlContenedor.Controls.Count > 1)
            {
                CtrlUtilidades ObjUtil = new CtrlUtilidades();
                ObjUtil.CerrarListaFormulario(pnlContenedor.Controls.OfType<Form>().ToList<Form>());
            }
            if (pnlMenuDatos.Visible) pnlMenuDatos.Visible = false;
            else pnlMenuDatos.Visible = true;
        }
        private void BtnInformes_Click(object sender, EventArgs e)
        {
        }
        private void BtnComisiones_Click(object sender, EventArgs e)
        {
            CtrlUtilidades objUtilidades = new CtrlUtilidades();
            objUtilidades.AbrirFormulario<FrmFactura>(pnlContenedor);
            objUtilidades = null;
            pnlMenuDatos.Visible = false;
        }
        private void btnPropietario_Click(object sender, EventArgs e)
        {
            TipoCliente = 1;
            CtrlUtilidades objUtilidades = new CtrlUtilidades();
            objUtilidades.AbrirFormulario<FrmCliente>(pnlContenedor);
            pnlMenuDatos.Visible = false;
        }
        private void frmPpal_Load(object sender, EventArgs e)
        {
            lblVersion.Text = ConfigurationManager.AppSettings["Version"];
        }
        private void btnCompradores_Click(object sender, EventArgs e)
        {
            TipoCliente = 2;
            CtrlUtilidades objUtilidades = new CtrlUtilidades();
            objUtilidades.AbrirFormulario<FrmCliente>(pnlContenedor);
            objUtilidades = null;
            pnlMenuDatos.Visible = false;
        }
        private void frmPpal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!auxCerrar)
            {
                e.Cancel = true;
            }
        }
        private void btnClasesGanado_Click(object sender, EventArgs e)
        {
            CtrlUtilidades objUtilidades = new CtrlUtilidades();
            objUtilidades.AbrirFormulario<FrmGanado>(pnlContenedor);
            objUtilidades = null;
            pnlMenuDatos.Visible = false;
        }
        private void btnSexos_Click(object sender, EventArgs e)
        {
            CtrlUtilidades objUtilidades = new CtrlUtilidades();
            objUtilidades.AbrirFormulario<FrmSexo>(pnlContenedor);
            objUtilidades = null;
            pnlMenuDatos.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Configuracion FrmConfig=new Configuracion();
            FrmConfig.ShowDialog();
        }
    }
}
