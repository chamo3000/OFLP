using OFLP.Modelo;
using System.Collections.Generic;

namespace OFLP.Controlador
{
    class ctrlHacienda
    {
        string idCliente;

        public bool LlenarGridHacienda()
        {
            ModHacienda oEquipo = new ModHacienda();


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

        public List<ModHacienda> BuscarHacienda(string datobusqueda)
        {
            ModHacienda oEquipo = new ModHacienda();
            List<ModHacienda> lstBusqueda = new List<ModHacienda>();
            lstBusqueda = oEquipo.BuscarHacienda(datobusqueda);
            if (lstBusqueda == null)
            {
                oEquipo = null;
                return null;
            }
            else
            {
                //DataSet ds = oEquipo.dtModPropietario;
                oEquipo = null;
                return lstBusqueda;
            }

        }

        public bool AgregarHacienda(string nombreHacienda, string municipioHacienda, string duenoHacienda)
        {
            ModHacienda objModHacienda = new ModHacienda();
            string[] vecCliente = new string[2];
            vecCliente = duenoHacienda.Split(' ');
            //SeleccionaIdCliente()
            if (objModHacienda.AgregarHacienda(nombreHacienda, municipioHacienda, SeleccionaIdDuenio(vecCliente[0], vecCliente[1]).ToString()))
            {
                objModHacienda = null;
                return true;
            }
            else
            {
                objModHacienda = null;
                return false;
            }

        }

        private string SeleccionaIdDuenio(string nombre, string apellido)
        {
            string id = "";
            ModHacienda oHacienda = new ModHacienda();
            id = oHacienda.SeleccionaIdDueno(apellido, nombre);
            return id;
        }

        public bool ActualizarHacienda(string[] DatosIngresar)
        {
            ModHacienda oHacienda = new ModHacienda();
            idCliente = oHacienda.SeleccionaIdDueno(DatosIngresar[3].Split(' ')[0], DatosIngresar[3].Split(' ')[1]);
            if (!oHacienda.ActualizarHacienda(DatosIngresar, idCliente.ToString()))
            {
                return false;
            }
            else
            {
                return true;
            }

            
        }

        public bool EliminarHacienda(string idHacienda)
        {
            ModHacienda oEquipo = new ModHacienda();


            if (!oEquipo.EliminarHacienda(idHacienda))
            {
                return false;
            }
            else
            {
                return true;
            }


        }


    }
}
