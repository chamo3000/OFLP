using OFLP.Modelo;
using System.Collections.Generic;
using System.Linq;

namespace OFLP.Controlador
{
    class CtrlCliente
    {
        public bool LlenarGridCliente()
        {
            MCliente oEquipo = new MCliente();
            if (!oEquipo.LlenarGrid()) return false;
            else return true;
        }
        public List<MCliente> BuscarPropietario(string datobusqueda)
        {
            MCliente oEquipo = new MCliente();
            List<MCliente> lstBusqueda = oEquipo.BuscarPropietario(datobusqueda);
           if (lstBusqueda == null) return null;
            else return lstBusqueda;

        }


        public bool InsertarCliente(string[] DatosIngresar)
        {
            MCliente oEquipo = new MCliente();
            if (!oEquipo.InsertarCliente(DatosIngresar)) return false;
            else return true;
        }

        public bool ActualizarCliente(string[] DatosIngresar)
        {
            MCliente oEquipo = new MCliente();
            if (!oEquipo.ActualizarCliente(DatosIngresar)) return false;
            else return true;
        }

        public bool EliminarCliente(string idCliente)
        {
            MCliente oEquipo = new MCliente();
            if (!oEquipo.EliminarCliente(idCliente)) return false;
            else return true;
        }
    }
}
