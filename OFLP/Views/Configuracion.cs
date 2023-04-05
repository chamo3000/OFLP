using OFLP.Controller;
using OFLP.Model;
using System;
using System.Windows.Forms;

namespace OFLP.Views
{
    public partial class Configuracion : Form
    {
        public Configuracion()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {
            using (MIGANEntities db = new MIGANEntities())
            {
                var lstPorcentajes = db.Porcentajes;
                foreach(var item in lstPorcentajes)
                {
                    numpicFeria.Value = item.Feria;
                    numpicRecibida.Value = (decimal)item.Recibida;
                    numpicComision.Value = (decimal)item.Comision;
                    numpicFondoNal.Value = (decimal)item.FondoNal;
                }
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void BtnTerminarGuardar_Click(object sender, EventArgs e)
        {
            string[] porcentaje= new string[5];
            porcentaje[0] = "1";
            porcentaje[1] = numpicFeria.Value.ToString();
            porcentaje[2] = numpicRecibida.Value.ToString();
            porcentaje[3] = numpicComision.Value.ToString();
            porcentaje[4] = numpicFondoNal.Value.ToString();
            CtrlPorcentaje ctrlPorcentaje = new CtrlPorcentaje();
            if (ctrlPorcentaje.ActualizarPorcentaje(porcentaje))
            {
                MessageBox.Show("Los porcentajes han sido guardados correctamente", "Porcentajes Guardados", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                this.Close();
            }
            else
                MessageBox.Show("Los porcentajes no han sido guardados", "Porcentajes No Guardados", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
        }
    }
}
