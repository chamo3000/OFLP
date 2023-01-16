using OFLP.Controlador;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;

namespace OFLP.Modelo
{
    class Hacienda
    {
        #region Propiedades
        public Int32 idHacienda { get; set; }
        public string nombreHacienda { get; set; }
        public string municipio { get; set; }
        public string primerApellido { get; set; }
        public string segundoApellido { get; set; }
        public string nombreCliente { get; set; }
        public string cedulaCliente { get; set; }

        private string SQL;
        #endregion

        public bool LlenarGrid()
        {
            SQL = "select * from VISTAHACIENDA";

            if (Select(SQL))
            {
                return true;
            }
            else return false;


        }

        private bool Select(string query)
        {

            bool rslt = false;
            UtilidadesBd oBd = new UtilidadesBd();
            if (oBd.AbrirConexion())
            {
                try
                {
                    SqlCommand command = new SqlCommand(query, oBd.Con);
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        ClsInicio.haciendas.Add(new Hacienda()
                        {
                            idHacienda = Convert.ToInt32(reader[0]),
                            nombreHacienda = reader[1].ToString(),
                            municipio = reader[2].ToString(),
                            nombreCliente = reader[3].ToString(),
                            primerApellido = reader[4].ToString(),
                            segundoApellido = reader[5].ToString(),
                            cedulaCliente = reader[6].ToString(),

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

        public List<Hacienda> BuscarHacienda(string datoBuscar)
        {

            List<Hacienda> lstBusqueda = new List<Hacienda>();

            lstBusqueda = (from cust in ClsInicio.haciendas
                           where cust.nombreHacienda.StartsWith(datoBuscar)
                           select cust).ToList();

            return lstBusqueda;
        }

        public bool AgregarHacienda(string nombre, string municipio, string idCliente)
        {
            bool rslt = false;
            UtilidadesBd oBd = new UtilidadesBd();
            if (oBd.AbrirConexion())
            {
                try
                {
                    SqlCommand command = new SqlCommand(oBd.Definirquery("AgregarHacienda"), oBd.Con);

                    command.Parameters.AddWithValue("@nombre", nombre);
                    command.Parameters.AddWithValue("@municipio", municipio);
                    command.Parameters.AddWithValue("@idCliente", idCliente);

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

        public bool ActualizarHacienda(string[] datosActualizar, string idCliente)
        {
            bool rslt = false;
            UtilidadesBd oBd = new UtilidadesBd();
            if (oBd.AbrirConexion())
            {
                try
                {
                    SqlCommand command = new SqlCommand(oBd.Definirquery("ActualizarHacienda"), oBd.Con);
                    command.Parameters.AddWithValue("@id", datosActualizar[0]);
                    command.Parameters.AddWithValue("@nombrehacienda", datosActualizar[1]);
                    command.Parameters.AddWithValue("@municipiohacienda", datosActualizar[2]);
                    command.Parameters.AddWithValue("@idCliente", idCliente);
                    
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

        public string SeleccionaIdDueno(string apellido, string nombre)
        {
            string rslt = "";

            UtilidadesBd oBd = new UtilidadesBd();
            if (oBd.AbrirConexion())
            {
                try
                {
                    SqlCommand command = new SqlCommand(oBd.Definirquery("SelecionaDuenoHacienda"), oBd.Con);
                    command.Parameters.AddWithValue("@primerApellido", apellido);
                    command.Parameters.AddWithValue("@nombre", nombre);
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            rslt = reader[0].ToString();
                        }
                    }
                }
                catch (Exception err)
                {
                    CtrlUtilidades.ImprimirLog("Error: " + err.Message);
                    CtrlUtilidades.ImprimirLog("Error: " + err.StackTrace);
                    rslt = "";
                }
            }
            else
            {
                rslt = "";
            }
            return rslt;
        }

        public bool EliminarHacienda(string idHacienda)
        {
            bool rslt = false;
            UtilidadesBd oBd = new UtilidadesBd();
           
                if (oBd.AbrirConexion())
                {

                    try
                    {
                        SqlCommand command = new SqlCommand(oBd.Definirquery("EliminarBanco"), oBd.Con);

                        command.Parameters.AddWithValue("@id", idHacienda);

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

    }
}
