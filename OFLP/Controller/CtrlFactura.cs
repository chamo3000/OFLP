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



        public bool AgregarFactura(string [] datos)
        {
            ModFactura oEquipo = new ModFactura();


            if (!oEquipo.AgregarFactura(datos))
            {
                return false;
            }
            else
            {
                return true;
            }

        }

        public bool EliminarFactura(string consecutivo)
        {
            ModFactura oEquipo = new ModFactura();


            if (!oEquipo.Eliminarfactura(consecutivo))
            {
                return false;
            }
            else
            {
                return true;
            }


        }


        public bool LlenarGridFactura()
        {
            ModFactura oEquipo = new ModFactura();

            if (!oEquipo.LlenarGrid())
            {
                return false;
            }
            else
            {
                //DataSet ds= oEquipo.dtModPropietario;
                return true;
            }

        }



    }
}
