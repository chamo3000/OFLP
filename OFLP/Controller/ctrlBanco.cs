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
            Banco oEquipo = new Banco();


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
            Banco objModBanco = new Banco();


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
            Banco oBanco = new Banco();

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
            Banco oEquipo = new Banco();


            if (!oEquipo.EliminarBanco(idBanco))
            {
                return false;
            }
            else
            {
                  return true;
            }

        }
        public List<Banco> BuscarBanco(string datobusqueda)
        {
            Banco oEquipo = new Banco();
            List<Banco> lstBusqueda = new List<Banco>();
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
