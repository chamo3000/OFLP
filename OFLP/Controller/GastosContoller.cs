using OFLP.Model;
using OFLP.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OFLP.Controller
{
    internal class GastosContoller
    {
        private string[] DatosIngresar { get; set; }

        public GastosContoller(string[] datosIngresar)
        {
                this.DatosIngresar = datosIngresar;
        }
        public bool InsertarGasto()
        {
            MGastos oEquipo = new MGastos();
            
            if (!oEquipo.InsertarGasto(DatosIngresar,CalcularTotal())) return false;
            else return true;
        }

        private int CalcularTotal() 
        {
            int total = 0;
            try
            {
                for (int i = 2; i < 11; i++)
                {
                    total = string.IsNullOrEmpty(DatosIngresar[i]) ? total += 0 : total += Convert.ToInt32(DatosIngresar[i]);
                }
                return total;
            }
            catch (Exception)
            {

                return 0;
            }
        }
    }
}
