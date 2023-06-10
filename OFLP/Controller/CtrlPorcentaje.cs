using OFLP.Model;


namespace OFLP.Controller
{
    internal class CtrlPorcentaje
    {
        public bool LlenarGridPorcentaje()
        {
            MPorcentaje oEquipo = new MPorcentaje();

            if (!oEquipo.SelectPorcent()) return false;
            else return true;
        }
        public bool ActualizarPorcentaje(string[] datosActualizar)
        {
            MPorcentaje oPorcentaje = new MPorcentaje();

            if (!oPorcentaje.ActualizarPorcentaje(datosActualizar)) return false;
            else return true;
        }
    }
}
