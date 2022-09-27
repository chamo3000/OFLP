using RegistroLogs;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace OFLP.Controlador
{
    class CtrlUtilidades
    {

        public void AbrirFormEnPanel(object formhija, Panel pnlPrincipalFormularios)
        {
            if (pnlPrincipalFormularios.Controls.Count > 0)
                pnlPrincipalFormularios.Controls.RemoveAt(0);
            Form fh = formhija as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            pnlPrincipalFormularios.Controls.Add(fh);
            pnlPrincipalFormularios.Tag = fh;
            fh.Show();

        }

        public void CerrarFormEnPanel(Panel pnlPrincipalFormularios)
        {
            if (pnlPrincipalFormularios.Controls.Count > 0)
                pnlPrincipalFormularios.Controls.RemoveAt(0);


        }

        internal void AbrirFormulario<MiForm>(Panel pnlPrincipalFormularios) where MiForm : Form, new()
        {
            Form formulario;
            formulario = pnlPrincipalFormularios.Controls.OfType<MiForm>().FirstOrDefault(); //Busca el formulario en la colección

            //Si formulario no existe
            if (formulario == null)
            {
                formulario = new MiForm();
                formulario.TopLevel = false;

                pnlPrincipalFormularios.Controls.Add(formulario);
                formulario.Dock = DockStyle.Fill;
                pnlPrincipalFormularios.Tag = formulario;
                formulario.Show();
            }
            else //Si el formulario/instancia existe
            {
                formulario.Show();
                formulario.BringToFront();
            }
        }

        internal void CerrarFormulario<MiForm>(Panel pnlPrincipalFormularios) where MiForm : Form, new()
        {
            Form formulario;
            formulario = pnlPrincipalFormularios.Controls.OfType<MiForm>().FirstOrDefault(); //Busca el formulario en la colección
            if (formulario != null)
            {
                formulario.Close();
            }
        }

        public void CerrarListaFormulario(List<Form> lista)
        {
            foreach (var frm in lista)
            {
                frm.Close();
            
            }
        }

        public static void ImprimirLog(string texto)
        {
            Imprimir objLogs = new Imprimir();
            objLogs.imprimirLog(texto);
            objLogs = null;
        }




    }
}
