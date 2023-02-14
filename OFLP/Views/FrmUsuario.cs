using OFLP.Controlador;
using OFLP.Controller;
using System;
using System.Windows.Forms;

namespace OFLP.Views
{
    public partial class FrmUsuario : Form
    {
        public FrmUsuario()
        {
            InitializeComponent();
            this.cmbEmpresa.SelectedIndex = 0;
        }
        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void BtnIngresar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtUsuario.Text) && !string.IsNullOrEmpty(txtContrasena.Text))
            {
                CtrlUsuario OctrlUsuario = new CtrlUsuario();
                if (OctrlUsuario.ValidarCliente(txtUsuario.Text, txtContrasena.Text))
                {
                    CtrlUtilidades.ImprimirLog($"El usuario ==> {txtUsuario.Text} <==, se ha logeado de manera existos ");
                    this.Hide();
                    Program.objfrmPpal.Show();
                }
                else MessageBox.Show("Usuario o contraseña no validos, por favor verifique e intente nuevamente", "Valida Usuario", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }else MessageBox.Show("Debe completar todos los campos", "Ingresar datos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        private void TxtUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;//elimina el sonido
                BtnIngresar_Click(sender, e);//llama al evento click del boton
            }
        }
        private void TxtContrasena_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;//elimina el sonido
                BtnIngresar_Click(sender, e);//llama al evento click del boton
            }
        }
        private void CmbEmpresa_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;//elimina el sonido
                BtnIngresar_Click(sender, e);//llama al evento click del boton
            }
        }
    }
}
