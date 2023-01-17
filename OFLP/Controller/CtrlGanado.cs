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
            Ganado oEquipo = new Ganado();

            if (!oEquipo.LlenarGrid()) return false;
            else return true;
        }

        public bool AgregarGanado(string claseGanado, string clase, string descripcion)
        {
            Ganado objModGanado = new Ganado();

            if (objModGanado.AgregarGanado(claseGanado, clase, descripcion)) return true;
            else return false;
        }

        public bool ActualizarGanado(string[] datosActualizar)
        {
            Ganado oBanco = new Ganado();
         
            if (!oBanco.ActualizarGanado(datosActualizar)) return false;
            else return true;
        }

        public bool EliminarGanado(string idGanado)
        {
            Ganado oEquipo = new Ganado();

            if (!oEquipo.EliminarGanado(idGanado)) return false;
            else return true;
        }

        public List<Ganado> BuscarGanado(string datobusqueda)
        {
            Ganado oEquipo = new Ganado();
            List<Ganado> lstBusqueda = oEquipo.BuscarGanado(datobusqueda);
            
            if (lstBusqueda == null) return null;
            else return lstBusqueda;
        }
    }
}
