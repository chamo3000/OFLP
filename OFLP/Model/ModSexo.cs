using OFLP.Controlador;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OFLP.Modelo
{
    class ModSexo
    {
        public int id { get; set; }
        public string sexo { get; set; }
        public string descripcion { get; set; }

        private string SQL;

        public bool LlenarGrid()
        {
            SQL = "select * from SEXO";

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
                        ClsInicio.sexo.Add(new ModSexo()
                        {
                            id = Convert.ToInt32(reader["id"]),
                            sexo = reader["sexo"].ToString(),
                            descripcion = reader["descripcion"].ToString()
                        });
                    }
                    rslt = true;


                }
                catch (Exception err)
                {

                    CtrlUtilidades.ImprimirLog("Error: " + err.Message);
                    CtrlUtilidades.ImprimirLog("Error: " + err.StackTrace);
                }
                oBd.CerrarConexion();
            }
            return rslt;
        }


        public bool AgregarSexo(string sexo, string descripcion)
        {
            bool rslt = false;
            ModUtilidadesBd oBd = new ModUtilidadesBd();
            if (oBd.AbrirConexion())
            {
                try
                {
                    SqlCommand command = new SqlCommand(oBd.Definirquery("AgregarSexo"), oBd.con);

                    command.Parameters.AddWithValue("@sexo", sexo);
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

        public bool ActualizarSexo(string[] datosActualizar)
        {
            bool rslt = false;
            ModUtilidadesBd oBd = new ModUtilidadesBd();
            if (oBd.AbrirConexion())
            {
                try
                {
                    SqlCommand command = new SqlCommand(oBd.Definirquery("ActualizarSexo"), oBd.con);

                    command.Parameters.AddWithValue("@sexo", datosActualizar[1]);
                    command.Parameters.AddWithValue("@descripcion", datosActualizar[2]);
                    command.Parameters.AddWithValue("@id", datosActualizar[0]);

                    Int32 rowsAffected = command.ExecuteNonQuery();
                    oBd.CerrarConexion();
                    if (rowsAffected > 0)
                    {
                        rslt = true;
                    }

                }
                catch (Exception err)
                {

                    CtrlUtilidades.ImprimirLog("Error: " + err.Message);
                    CtrlUtilidades.ImprimirLog("Error: " + err.StackTrace);
                }
            }
            return rslt;
        }


        public bool EliminarSexo(string idBanco)
        {
            bool rslt = false;
            ModUtilidadesBd oBd = new ModUtilidadesBd();

            if (oBd.AbrirConexion())
            {

                try
                {
                    SqlCommand command = new SqlCommand(oBd.Definirquery("EliminarSexo"), oBd.con);

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

        public List<ModSexo> BuscarSexo(string datoBuscar)
        {

            List<ModSexo> lstBusqueda = new List<ModSexo>();

            lstBusqueda = (from cust in ClsInicio.sexo
                           where cust.sexo.StartsWith(datoBuscar)
                           select cust).ToList();

            return lstBusqueda;
        }

    }
}
