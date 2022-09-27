using OFLP.Controlador;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OFLP.Modelo
{
    class ModBanco
    {

        #region Propiedades
        public int IdBanco { get; set; }
        public string NombreBanco { get; set; }
        public string DescripcionBanco { get; set; }


        public string nombre { get; set; }
        public string descripcion { get; set; }

        private string SQL;

        #endregion


        public bool LlenarGrid()
        {
            SQL = "select * from BANCO";

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
                    SqlCommand command = new SqlCommand(query, oBd.con);
                    SqlDataReader reader = command.ExecuteReader();
                    

                    while (reader.Read())
                        {
                            ClsInicio.banco.Add(new ModBanco()
                            {
                                IdBanco = Convert.ToInt32(reader["id"]),
                                NombreBanco = reader["nombre"].ToString(),
                                DescripcionBanco = reader["descripcion"].ToString()
                            });
                        }
                        rslt = true;
                    

                }
                catch (Exception err)
                {

                    //registrar Log
                }
                oBd.CerrarConexion();
            }
            return rslt;
        }


        public bool AgregarBanco(string nombre, string descripcion)
        {
            bool rslt = false;
            ModUtilidadesBd oBd = new ModUtilidadesBd();
            if (oBd.AbrirConexion())
            {
                try
                {
                    SqlCommand command = new SqlCommand(oBd.Definirquery("AgregarBanco"), oBd.con);

                    command.Parameters.AddWithValue("@nombre", nombre);
                    command.Parameters.AddWithValue("@descripcion", descripcion);
                  

                    Int32 rowsAffected = command.ExecuteNonQuery();
                    oBd.CerrarConexion();

                    if (rowsAffected > 0) rslt = true;

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            return rslt;
        }


        public bool ActualizarBanco(string[] datosActualizar)
        {
            bool rslt = false;
            ModUtilidadesBd oBd = new ModUtilidadesBd();
            if (oBd.AbrirConexion())
            {
                try
                {
                    SqlCommand command = new SqlCommand(oBd.Definirquery("ActualizarBanco"), oBd.con);
                 
                    command.Parameters.AddWithValue("@nombre", datosActualizar[1]);
                    command.Parameters.AddWithValue("@descripcion", datosActualizar[2]);
                    command.Parameters.AddWithValue("@id", datosActualizar[0]);

                    Int32 rowsAffected = command.ExecuteNonQuery();
                    oBd.CerrarConexion();
                    if (rowsAffected > 0)
                    {
                        rslt = true;
                    }

                }
                catch (Exception ex)
                {

                    throw;
                }
            }
            return rslt;
        }


        public bool EliminarBanco(string idBanco)
        {
            bool rslt = false;
            ModUtilidadesBd oBd = new ModUtilidadesBd();

            if (oBd.AbrirConexion())
            {

                try
                {
                    SqlCommand command = new SqlCommand(oBd.Definirquery("EliminarBanco"), oBd.con);

                    command.Parameters.AddWithValue("@id", idBanco);

                    Int32 rowsAffected = command.ExecuteNonQuery();
                    oBd.CerrarConexion();
                    if (rowsAffected > 0)
                    {

                        rslt = true;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            oBd = null;
            return rslt;
        }


        public List<ModBanco> BuscarBanco(string datoBuscar)
        {

            List<ModBanco> lstBusqueda = new List<ModBanco>();

            lstBusqueda = (from cust in ClsInicio.banco
                           where cust.NombreBanco.StartsWith(datoBuscar)
                           select cust).ToList();

            return lstBusqueda;
        }


    }
}
