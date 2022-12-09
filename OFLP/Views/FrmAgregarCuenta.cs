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
    public partial class FrmAgregarCuenta : Form
    {
        public FrmAgregarCuenta()
        {
            InitializeComponent();
        }

        private void FrmAgregarCuenta_Load(object sender, EventArgs e)
        {
            cmbIdBanco.SelectedIndex = 0;
            cmbIdcliente.SelectedIndex = 0;

            CtrlCliente objCliente = new CtrlCliente();
            objCliente.LlenarGridCliente();

            foreach (ModCliente item in ClsInicio.clientes)
            {
                cmbIdcliente.Items.Add(item.NombreCliente +" "+ item.PrimerApellido);

            }


            CtrlBanco objBanco = new CtrlBanco();
            objBanco.LlenarGridBanco();

            foreach (ModBanco item in ClsInicio.banco)
            {
                cmbIdBanco.Items.Add(item.NombreBanco);

            }
        }


     


        private void BtnCancelarBanco_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnAceptaAgregarCuenta_Click(object sender, EventArgs e)
        {
            string numero_cuenta = TxtNumeroCuenta.Text;
            string ciudad = TxtCiudad.Text;
            string sucursal = TxtSucursal.Text;
            string comentario = TxtComentario.Text;


            if (string.IsNullOrEmpty(numero_cuenta) || string.IsNullOrEmpty(ciudad) || string.IsNullOrEmpty(sucursal) || (cmbIdBanco.Text.Equals("SELECCIONE UN BANCO")) || (cmbIdcliente.Text.Equals("SELECCIONE UN CLIENTE")))
            {
                MessageBox.Show(this, "Es necesario ingresar los campos completos para realizar el proceso.", "Agregar Cuenta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                CtrlCuenta objCuenta = new CtrlCuenta();
                if (objCuenta.AgregarCuenta(numero_cuenta, ciudad,sucursal,comentario,cmbIdcliente.Text,cmbIdBanco.Text))
                {
                    MessageBox.Show(this, "El registro ha sido agregado exitosamente", "Agregar Cuenta", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    CtrlUtilidades util = new CtrlUtilidades();
                    util.CerrarFormulario<FrmCuenta>(Program.objfrmPpal.pnlContenedor);
                    util.AbrirFormulario<FrmCuenta>(Program.objfrmPpal.pnlContenedor);
                    this.Close();
                }
                else
                {
                    MessageBox.Show(this, "El registro no ha sido agregado, intente nuevamen", "Agregar Banco", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                TxtNumeroCuenta.Text= string.Empty;
                TxtCiudad.Text= string.Empty; ;
                TxtSucursal.Text=string.Empty;
                TxtComentario.Text= string.Empty;
                cmbIdBanco.Text = "SELECCIONE UN BANCO";
                cmbIdcliente.Text = "SELECCIONE UN CLIENTE";


                objCuenta = null;
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

        private void Validar_Numero(TextBox Elemento, EventArgs e)
        {

            if (Controlador.Restricciones.Tiene_Numeros(Elemento.Text.Trim()))
            {
                Elemento.Text = string.Empty;
                MessageBox.Show(this, "Este campo no permite letras", "Advertencia ", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
            }
        }


        private void TxtNumeroCuenta_TextChanged(object sender, EventArgs e)
        {
            Validar_Numero(TxtNumeroCuenta,e);
        }

        private void TxtCiudad_TextChanged(object sender, EventArgs e)
        {
            Validar_Texto(TxtCiudad,e);
        }

 

   
    }
}
