using OFLP.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OFLP.Controller
{
    internal class CtrlGasto
    {

        public bool InsertarGasto(int idFactura,string[] DatosIngresar)
        {
            ModGasto oEquipo = new ModGasto(idFactura);
            if (!oEquipo.InsertarGasto(DatosIngresar)) return false;
            else return true;
        }
    }
}
