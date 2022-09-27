using OFLP.Modelo;
using System.Collections.Generic;

namespace OFLP.Controlador
{
    class CtrlCliente
    {
        public bool LlenarGridCliente()
        {
            ModCliente oEquipo = new ModCliente();

            if (!oEquipo.LlenarGrid())
            {
              return false;
            }
            else
            {
                return true;
            }

        }
        public List<ModCliente> BuscarPropietario(string datobusqueda)
        {
            ModCliente oEquipo = new ModCliente();
            List<ModCliente> lstBusqueda = oEquipo.BuscarPropietario(datobusqueda);
            if (lstBusqueda == null)
            {
                return null;
            }
            else
            {
                return lstBusqueda;
            }

        }

        public bool InsertarCliente(string[] DatosIngresar)
        {
            ModCliente oEquipo = new ModCliente();




            if (!oEquipo.InsertarCliente(DatosIngresar))
            {
                oEquipo = null;
                return false;
            }
            else
            {
                oEquipo = null;
                return true;
            }

        }

        public bool ActualizarCliente(string[] DatosIngresar)
        {
            ModCliente oEquipo = new ModCliente();


            if (!oEquipo.ActualizarCliente(DatosIngresar))
            {
                oEquipo = null;
                return false;
            }
            else
            {
                oEquipo = null;
                return true;
            }

        }

        public bool EliminarCliente(string idCliente)
        {
            ModCliente oEquipo = new ModCliente();


            if (!oEquipo.EliminarCliente(idCliente))
            {
                oEquipo = null;
                return false;
            }
            else
            {
                oEquipo = null;
                return true;
            }

        }


    }
}
