using OFLP.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OFLP.Controlador
{
    class CtrlCuenta
    {
        public int IdCLiente { get; set; }
        public int IdBancos { get; set; }

        private void SelectIdCliente(string nombre)
        {
            foreach (ModCliente item in ClsInicio.clientes)
            {
                if(nombre.Contains(item.NombreCliente) && nombre.Contains(item.PrimerApellido))
                {
                    IdCLiente = item.CedulaCliente;
                }
            }
        }

        private void SelectIdBanco(string nombre)
        {
            foreach (ModBanco item in ClsInicio.banco)
            {
                if (nombre.Equals(item.NombreBanco))
                {
                    IdBancos = item.IdBanco;
                }
            }
        }


        public bool AgregarCuenta(string numero_cuenta, string ciudad, string sucursal, string comentario, string cmbIdcliente, string cmbIdBanco)
        {

            SelectIdCliente(cmbIdcliente);
            SelectIdBanco(cmbIdBanco);
            ModCuenta objModCuenta = new ModCuenta();


            //SeleccionaIdCliente()
            if (objModCuenta.AgregarCuenta(numero_cuenta, ciudad, sucursal, comentario, IdCLiente, IdBancos))
            {

                return true;
            }
            else
            {

                return false;
            }

        }

        public bool LlenarGridCuenta()
        {
            ModCuenta oEquipo = new ModCuenta();


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

    }
}
