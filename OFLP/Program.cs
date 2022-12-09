using OFLP.Views;
using OFLP.Vistas;
using System;
using System.Windows.Forms;

namespace OFLP
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        public static FrmPpal objfrmPpal;
        [STAThread]
        static void Main()
        {

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            objfrmPpal = new FrmPpal();
            Application.Run(new FrmUsuario());
        }
    }
}
