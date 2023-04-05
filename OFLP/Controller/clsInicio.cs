using OFLP.Model;
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
        public static List<Ganado> ganado = new List<Ganado>();
        public static List<ModSexo> sexo = new List<ModSexo>();
        public static List<MFactura> Factura = new List<MFactura>();
        public static List<MFactura> FacturaActualizar = new List<MFactura>();
        public static List<MPorcentaje> Porcentajes = new List<MPorcentaje>();

        public void Iniciar()
        {
            System.Windows.Forms.Application.Run(objfrmPpal);
        }

       

    }
}
