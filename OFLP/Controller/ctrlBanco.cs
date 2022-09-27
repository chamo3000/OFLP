using OFLP.Modelo;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OFLP.Controlador
{
    class CtrlBanco
    {

        public bool LlenarGridBanco()
        {
            ModBanco oEquipo = new ModBanco();


            if (!oEquipo.LlenarGrid())
            {

                return false;
            }
            else
            {

                return true;
            }

        }


        public bool AgregarBanco(string nombreBanco, string descripcionBanco)
        {
            ModBanco objModBanco = new ModBanco();


            //SeleccionaIdCliente()
            if (objModBanco.AgregarBanco(nombreBanco, descripcionBanco))
            {

                return true;
            }
            else
            {

                return false;
            }

        }

        public bool ActualizarBanco(string[] datosActualizar)
        {
            ModBanco oBanco = new ModBanco();

            if (!oBanco.ActualizarBanco(datosActualizar))
            {
                return false;
            }
            else
            {
                return true;
            }


        }


        public bool EliminarBanco(string idBanco)
        {
            ModBanco oEquipo = new ModBanco();


            if (!oEquipo.EliminarBanco(idBanco))
            {
                return false;
            }
            else
            {
                  return true;
            }

        }
        public List<ModBanco> BuscarBanco(string datobusqueda)
        {
            ModBanco oEquipo = new ModBanco();
            List<ModBanco> lstBusqueda = new List<ModBanco>();
            lstBusqueda = oEquipo.BuscarBanco(datobusqueda);
            if (lstBusqueda == null)
            {
               
                return null;
            }
            else
            {
                
            
                return lstBusqueda;
            }

        }






    }



}
