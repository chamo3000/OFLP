using OFLP.Model;


namespace OFLP.Controller
{
    internal class CtrlPorcentaje
    {
        public bool ActualizarPorcentaje(string[] datosActualizar)
        {
            MPorcentaje oPorcentaje = new MPorcentaje();

            if (!oPorcentaje.ActualizarPorcentaje(datosActualizar)) return false;
            else return true;
        }
    }
}
