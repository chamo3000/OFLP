﻿using OFLP.Controlador;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace OFLP.Modelo
{
    public class ModCliente
    {
        #region Propiedades
        public Int32 idCliente { get; set; }
        public string primerApellido { get; set; }
        public string segundoApellido { get; set; }
        public string nombreCliente { get; set; }
        public string cedulaCliente { get; set; }
        public string descripcion { get; set; }
        private string SQL;


        #endregion

        public bool LlenarGrid()
        {
            ModUtilidadesBd oBd = new ModUtilidadesBd();
            SQL = oBd.Definirquery("SelecionaCliente");
            
            if (Select(SQL))
            {
                return true;
            }
            else return false;
        }


        public List<ModCliente> BuscarPropietario(string datoBuscar)
        {


            List<ModCliente> lstBusqueda = new List<ModCliente>();


            lstBusqueda = (from cust in ClsInicio.clientes
                           where cust.primerApellido.StartsWith(datoBuscar)
                           select cust).ToList();
            return lstBusqueda;
        }

        #region Base de datos
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
                    ClsInicio.clientes.Clear();
                    while (reader.Read())
                    {
                        ClsInicio.clientes.Add(new ModCliente()
                        {
                            idCliente = Convert.ToInt32(reader[0]),
                            primerApellido = reader[1].ToString(),
                            segundoApellido = reader[2].ToString(),
                            nombreCliente = reader[3].ToString(),
                            cedulaCliente = reader[4].ToString()
                            
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
                oBd = null;

            }

            return rslt;
        }
        
        public bool InsertarCliente(string[] datos)
        {
            bool rslt = false;
            ModUtilidadesBd oBd = new ModUtilidadesBd();
            if (oBd.AbrirConexion())
            {

                try
                {
                    SqlCommand command = new SqlCommand(oBd.Definirquery("AgregarCliente"), oBd.con);

                    command.Parameters.AddWithValue("@primerApellido", datos[0].ToUpper());
                    command.Parameters.AddWithValue("@segundoApellido", datos[1].ToUpper());
                    command.Parameters.AddWithValue("@nombre", datos[2].ToUpper());
                    command.Parameters.AddWithValue("@cedula", datos[3]);
                    Int32 rowsAffected = command.ExecuteNonQuery();
                    oBd.CerrarConexion();
                    if (rowsAffected > 0)
                    {
                        if (selectIdCliente(datos))
                        {
                            if (InsertarClaseCliente(idCliente, Convert.ToInt32(datos[4])))
                            {
                                rslt = true;
                            }
                        }

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

        public bool ActualizarCliente(string[] datos)
        {
            bool rslt = false;
            ModUtilidadesBd oBd = new ModUtilidadesBd();
            if (oBd.AbrirConexion())
            {

                try
                {
                    SqlCommand command = new SqlCommand(oBd.Definirquery("ActualizarCliente"), oBd.con);
                    command.Parameters.AddWithValue("@id", datos[0]);
                    command.Parameters.AddWithValue("@primerApellido", datos[1]);
                    command.Parameters.AddWithValue("@segundoApellido", datos[2]);
                    command.Parameters.AddWithValue("@nombre", datos[3]);
                    command.Parameters.AddWithValue("@cedula", datos[4]);

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
            return rslt;
        }

        public bool selectIdCliente(string[] datos)
        {
            bool rslt = false;
            ModUtilidadesBd oBd = new ModUtilidadesBd();
            if (oBd.AbrirConexion())
            {
                SqlCommand command = new SqlCommand(oBd.Definirquery("SelecIdCliente"), oBd.con);
                command.Parameters.AddWithValue("@primerApellido", datos[0]);
                command.Parameters.AddWithValue("@segundoApellido", datos[1]);
                command.Parameters.AddWithValue("@nombre", datos[2]);
                command.Parameters.AddWithValue("@cedula", datos[3]);
                try
                {
                    //connection.Open();
                    SqlDataReader rd = command.ExecuteReader();
                    if (rd.Read())
                    {
                        idCliente = Convert.ToInt32(rd[0]);

                    }

                    rslt = true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                oBd.CerrarConexion();
                oBd = null;

            }

            return rslt;
        }

        public bool InsertarClaseCliente(int idCliente, int idTipoCliente)
        {
            bool rslt = false;
            ModUtilidadesBd oBd = new ModUtilidadesBd();
            if (oBd.AbrirConexion())
            {
                SqlCommand command = new SqlCommand(oBd.Definirquery("AgregarClaseCliente"), oBd.con);
                command.Parameters.AddWithValue("@idCliente", idCliente);
                command.Parameters.AddWithValue("@idTipoCliente", idTipoCliente);
                try
                {
                    //connection.Open();
                    Int32 rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0) rslt = true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                oBd.CerrarConexion();
                oBd = null;

            }

            return rslt;
        }

        public bool EliminarClaseCliente(string idCliente)
        {
            bool rslt = false;
            ModUtilidadesBd oBd = new ModUtilidadesBd();
            if (oBd.AbrirConexion())
            {
                SqlCommand command = new SqlCommand(oBd.Definirquery("EliminarClaseCliente"), oBd.con);
                command.Parameters.AddWithValue("@idCliente", idCliente);

                try
                {
                    //connection.Open();
                    Int32 rowsAffected = command.ExecuteNonQuery();
                    if (rowsAffected > 0) rslt = true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                oBd.CerrarConexion();
                oBd = null;

            }

            return rslt;
        }

        public bool EliminarCliente(string idCliente)
        {
            bool rslt = false;
            ModUtilidadesBd oBd = new ModUtilidadesBd();
                if (oBd.AbrirConexion())
                {

                    try
                    {
                        SqlCommand command = new SqlCommand(oBd.Definirquery("EliminarCliente"), oBd.con);

                        command.Parameters.AddWithValue("@id", idCliente);

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

            return rslt;
        }
        #endregion

    }
}
