using OFLP.Controlador;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OFLP.Modelo
{
    class ModGanado
    {
        public Int32 idGanado { get; set; }
        public string claseGanado{ get; set; }
        public string clase { get; set; }
        public string descripcion { get; set; }

        private string SQL;

        public bool LlenarGrid()
        {
            SQL = "select * from CLASE";

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
                        ClsInicio.ganado.Add(new ModGanado()
                        {
                            idGanado = Convert.ToInt32(reader["id"]),
                            claseGanado = reader["claseGanado"].ToString(),
                            clase = reader["clase"].ToString(),
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

        public bool AgregarGanado(string claseGanado, string clase, string descripcion)
        {
            bool rslt = false;
            ModUtilidadesBd oBd = new ModUtilidadesBd();
            if (oBd.AbrirConexion())
            {
                try
                {
                    SqlCommand command = new SqlCommand(oBd.Definirquery("AgregarGanado"), oBd.con);

                    command.Parameters.AddWithValue("@claseGanado", claseGanado);
                    command.Parameters.AddWithValue("@clase", clase);
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

        public bool ActualizarGanado(string[] datosActualizar)
        {
            bool rslt = false;
            ModUtilidadesBd oBd = new ModUtilidadesBd();
            if (oBd.AbrirConexion())
            {
                try
                {
                    SqlCommand command = new SqlCommand(oBd.Definirquery("ActualizarGanado"), oBd.con);

                    command.Parameters.AddWithValue("@claseGanado", datosActualizar[1]);
                    command.Parameters.AddWithValue("@clase", datosActualizar[2]);
                    command.Parameters.AddWithValue("@descripcion", datosActualizar[3]);
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

        public bool EliminarGanado(string idGanado)
        {
            bool rslt = false;
            ModUtilidadesBd oBd = new ModUtilidadesBd();

            if (oBd.AbrirConexion())
            {

                try
                {
                    SqlCommand command = new SqlCommand(oBd.Definirquery("EliminarGanado"), oBd.con);

                    command.Parameters.AddWithValue("@id", idGanado);

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


        public List<ModGanado> BuscarGanado(string datoBuscar)
        {

            List<ModGanado> lstBusqueda = new List<ModGanado>();

            lstBusqueda = (from cust in ClsInicio.ganado
                           where cust.claseGanado.StartsWith(datoBuscar)
                           select cust).ToList();

            return lstBusqueda;
        }
    }
}
