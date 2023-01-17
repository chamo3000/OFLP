using OFLP.Modelo;
using System.Collections.Generic;

namespace OFLP.Controlador
{
    class ctrlHacienda
    {
        string idCliente;

        public bool LlenarGridHacienda()
        {
            Hacienda oEquipo = new Hacienda();


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

        public List<Hacienda> BuscarHacienda(string datobusqueda)
        {
            Hacienda oEquipo = new Hacienda();
            List<Hacienda> lstBusqueda = new List<Hacienda>();
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
            Hacienda objModHacienda = new Hacienda();
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
            Hacienda oHacienda = new Hacienda();
            id = oHacienda.SeleccionaIdDueno(apellido, nombre);
            return id;
        }

        public bool ActualizarHacienda(string[] DatosIngresar)
        {
            Hacienda oHacienda = new Hacienda();
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
            Hacienda oEquipo = new Hacienda();


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
