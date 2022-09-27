using OFLP.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OFLP.Controlador
{
    class CtrlGanado
    {
   


        public bool LlenarGridGanado()
        {
            ModGanado oEquipo = new ModGanado();


            if (!oEquipo.LlenarGrid())
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


        public bool AgregarGanado(string claseGanado, string clase, string descripcion)
        {
            ModGanado objModGanado = new ModGanado();


            //SeleccionaIdCliente()
            if (objModGanado.AgregarGanado(claseGanado, clase, descripcion))
            {

                return true;
            }
            else
            {

                return false;
            }

        }


        public bool ActualizarGanado(string[] datosActualizar)
        {
            ModGanado oBanco = new ModGanado();
         
            if (!oBanco.ActualizarGanado(datosActualizar))
            {
                return false;
            }
            else
            {
                return true;
            }


        }


        public bool EliminarGanado(string idGanado)
        {
            ModGanado oEquipo = new ModGanado();


            if (!oEquipo.EliminarGanado(idGanado))
            {
                return false;
            }
            else
            {
                return true;
            }


        }


        public List<ModGanado> BuscarGanado(string datobusqueda)
        {
            ModGanado oEquipo = new ModGanado();
            List<ModGanado> lstBusqueda = new List<ModGanado>();
            lstBusqueda = oEquipo.BuscarGanado(datobusqueda);
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
