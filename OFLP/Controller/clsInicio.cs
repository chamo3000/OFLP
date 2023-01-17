using OFLP.Modelo;
using OFLP.Vistas;
using System.Collections.Generic;

namespace OFLP.Controlador
{
    class ClsInicio
    {
        public static FrmPpal objfrmPpal = new FrmPpal();
        public static List<MCliente> clientes = new List<MCliente>();
        public static List<MCliente> Compradores = new List<MCliente>();
        public static List<Hacienda> haciendas = new List<Hacienda>();
        public static List<Ganado> ganado = new List<Ganado>();
        public static List<Banco> banco = new List<Banco>();
        public static List<ModSexo> sexo = new List<ModSexo>();
        public static List<Cuenta> cuenta = new List<Cuenta>();
        public static List<MFactura> Factura = new List<MFactura>();

        public void Iniciar()
        {
           
            System.Windows.Forms.Application.Run(objfrmPpal);
            
           
        }

       

    }
}
