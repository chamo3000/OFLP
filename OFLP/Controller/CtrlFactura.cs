using OFLP.Model;
using OFLP.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OFLP.Controlador
{
    class CtrlFactura
    {
        public bool AgregarFactura(List<FACTURA> datos)
        {
            MFactura oEquipo = new MFactura();

            if (!oEquipo.AgregarFactura(datos))
            return false;
            else
            return true;
        }

        public bool ActualizarFactura(List<FACTURA> datos,int index)
        {
            MFactura oEquipo = new MFactura();

            if (!oEquipo.ActualizarFactura(datos,index))
                return false;
            else
                return true;
        }
        public bool EliminarFactura(string consecutivo)
        {
            MFactura oEquipo = new MFactura();

            if (!oEquipo.Eliminarfactura(consecutivo))
            return false;
            else
            return true;
        }
        public bool LlenarGridFactura()
        {
            MFactura oEquipo = new MFactura();

            if (!oEquipo.LlenarGrid()) return false;
            else return true;
        }

        public bool LlenarGridFacturaActualizar(string consecutivo)
        {
            MFactura oEquipo = new MFactura();

            if (!oEquipo.LlenarGridFacturaActualizar(consecutivo)) return false;
            else return true;
        }
    }
}
