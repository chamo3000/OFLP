using OFLP.Controlador;
using OFLP.Modelo;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OFLP.Model
{
    internal class ModUsuario
    {
        public string Usuario { get; set; }
        public string Password { get; set; }

        public bool ValidarUsuario(string user,string pass)
        {
            Usuario = user;
            Password = pass;
            ModUtilidadesBd oBd = new ModUtilidadesBd();
            string SQL = oBd.Definirquery("ValidarUsuario");

            if (Select(SQL))
            {
                return true;
            }
            else return false;
        }

        private bool Select(string query)
        {

            bool rslt = false;
            ModUtilidadesBd oBd = new ModUtilidadesBd();
            if (oBd.AbrirConexion())
            {
                try
                {

                    SqlCommand command = new SqlCommand(query, oBd.Con);
                    
                    command.Parameters.AddWithValue("@usuario", Usuario);
                    command.Parameters.AddWithValue("@contrasena", Password);

                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        ClsInicio.clientes.Add(new ModCliente()
                        {
                            nombreCliente = reader[0].ToString(),
                            primerApellido = reader[1].ToString(),
                        });

                    }
                    rslt = true;

                }
                catch (Exception err)
                {
                    CtrlUtilidades.ImprimirLog("ERROR ---------------> " + err.Message);
                    //registrar Log
                }
                oBd.CerrarConexion();


            }

            return rslt;
        }

    }
}
