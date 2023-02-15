using OFLP.Modelo;
using System.Collections.Generic;

namespace OFLP.Controlador
{
    class CtrlSexo
    {

        public bool LlenarGridSexo()
        {
            ModSexo oEquipo = new ModSexo();

            if (!oEquipo.LlenarGrid()) return false;
            else return true;
        }

        public bool AgregarSexo(string sexo, string descripcion)
        {
            ModSexo objModSexo = new ModSexo();

            if (objModSexo.AgregarSexo(sexo, descripcion)) return true;
            else return false;
        }

        public bool ActualizarSexo(string[] datosActualizar)
        {
            ModSexo oSexo = new ModSexo();

            if (!oSexo.ActualizarSexo(datosActualizar)) return false;
            else return true;
        }

        public bool EliminarSexo(string id)
        {
            ModSexo oEquipo = new ModSexo();
            if (!oEquipo.EliminarSexo(id)) return false;
            else return true;
        }

        public List<ModSexo> BuscarSexo(string datobusqueda)
        {
            ModSexo oEquipo = new ModSexo();
            List<ModSexo> lstBusqueda = oEquipo.BuscarSexo(datobusqueda);
            
            if (lstBusqueda == null) return null;
            else return lstBusqueda;
        }
    }
}
