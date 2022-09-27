using OFLP.Modelo;
using OFLP.Vistas;
using System.Collections.Generic;

namespace OFLP.Controlador
{
    class ClsInicio
    {
        public static FrmPpal objfrmPpal = new FrmPpal();
        public static List<ModCliente> clientes = new List<ModCliente>();
        public static List<ModCliente> Compradores = new List<ModCliente>();
        public static List<ModHacienda> haciendas = new List<ModHacienda>();
        public static List<ModGanado> ganado = new List<ModGanado>();
        public static List<ModBanco> banco = new List<ModBanco>();
        public static List<ModSexo> sexo = new List<ModSexo>();
        public static List<ModCuenta> cuenta = new List<ModCuenta>();
        public static List<ModFactura> Factura = new List<ModFactura>();

        public void Iniciar()
        {
           
            System.Windows.Forms.Application.Run(objfrmPpal);
            
           
        }

       

    }
}
