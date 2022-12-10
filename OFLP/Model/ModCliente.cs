using OFLP.Controlador;
using OFLP.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace OFLP.Modelo
{
    public class ModCliente
    {
        #region Propiedades
        public string PrimerApellido { get; set; }
        public string SegundoApellido { get; set; }
        public string NombreCliente { get; set; }
        public int CedulaCliente { get; set; }
        public string Descripcion { get; set; }
        #endregion

        public bool LlenarGrid()
        {
            #region Codigo sin EF
            //ModUtilidadesBd oBd = new ModUtilidadesBd();
            //SQL = oBd.Definirquery("SelecionaCliente");

            //if (Select(SQL))
            //{
            //    return true;
            //}
            //else return false;
            #endregion
            try
            {
                ClsInicio.clientes.Clear();
                using (MIGANEntities db = new MIGANEntities())
                {
                    var lstCliente = db.CLIENTE;
                    foreach (var oCliente in lstCliente)
                    {
                        ClsInicio.clientes.Add(new ModCliente()
                        {

                            CedulaCliente = Convert.ToInt32(oCliente.CEDULA),
                            NombreCliente = oCliente.NOMBRE.ToString(),
                            PrimerApellido = oCliente.PRIMERAPELLIDO.ToString(),
                            SegundoApellido = oCliente.SEGUNDOAPELLIDO

                        });
                    }
                }
                return true;

            }
            catch (Exception err)
            {
                CtrlUtilidades.ImprimirLog("ERROR ---------------> " + err.Message);
                CtrlUtilidades.ImprimirLog("ERROR ---------------> " + err.StackTrace);
                return false;
            }

        }


        public List<ModCliente> BuscarPropietario(string datoBuscar)
        {


            List<ModCliente> lstBusqueda = new List<ModCliente>();


            lstBusqueda = (from cust in ClsInicio.clientes
                           where cust.PrimerApellido.StartsWith(datoBuscar)
                           select cust).ToList();
            return lstBusqueda;
        }

        #region Base de datos

        public bool InsertarCliente(string[] datos)
        {
            #region Codigo sin EF
            //ModUtilidadesBd oBd = new ModUtilidadesBd();
            //if (oBd.AbrirConexion())
            //{

            //    try
            //    {
            //        SqlCommand command = new SqlCommand(oBd.Definirquery("AgregarCliente"), oBd.Con);

            //        command.Parameters.AddWithValue("@primerApellido", datos[0].ToUpper());
            //        command.Parameters.AddWithValue("@segundoApellido", datos[1].ToUpper());
            //        command.Parameters.AddWithValue("@nombre", datos[2].ToUpper());
            //        command.Parameters.AddWithValue("@cedula", datos[3]);
            //        Int32 rowsAffected = command.ExecuteNonQuery();
            //        oBd.CerrarConexion();
            //        rslt = true;
            //    }
            //    catch (Exception ex)
            //    {
            //        Console.WriteLine(ex.Message);
            //    }
            //}
            #endregion
            try
            {
                CLIENTE oCliente = new CLIENTE
                {
                    PRIMERAPELLIDO = datos[0],
                    SEGUNDOAPELLIDO = datos[1],
                    NOMBRE = datos[2],
                    CEDULA = Convert.ToInt32(datos[3]),
                };
                using (MIGANEntities db = new MIGANEntities())
                {
                    db.CLIENTE.Add(oCliente);
                    db.SaveChanges();
                }
                return true;

            }
            catch (Exception err)
            {
                CtrlUtilidades.ImprimirLog("ERROR ---------------> " + err.Message);
                CtrlUtilidades.ImprimirLog("ERROR ---------------> " + err.StackTrace);
                return false;
            }
        }

        public bool ActualizarCliente(string[] datos)
        {
            int id = Convert.ToInt32(datos[0]);
            try
            {
                using (MIGANEntities db = new MIGANEntities())
                {
                    CLIENTE oCliente = db.CLIENTE.Where(d => d.CEDULA == id).First();

                    oCliente.CEDULA = Convert.ToInt32(datos[0]);
                    oCliente.PRIMERAPELLIDO = datos[1];
                    oCliente.SEGUNDOAPELLIDO = datos[2];
                    oCliente.NOMBRE = datos[3];
                    db.Entry(oCliente).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                }
                return true;
            }
            catch (Exception err)
            {
                CtrlUtilidades.ImprimirLog("ERROR ---------------> " + err.Message);
                CtrlUtilidades.ImprimirLog("ERROR ---------------> " + err.StackTrace);
                return false;
            }
        }

        public bool SelectIdCliente(string[] datos)
        {
            bool rslt = false;
            ModUtilidadesBd oBd = new ModUtilidadesBd();
            if (oBd.AbrirConexion())
            {
                SqlCommand command = new SqlCommand(oBd.Definirquery("SelecIdCliente"), oBd.Con);
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
                        CedulaCliente = Convert.ToInt32(rd[0]);

                    }

                    rslt = true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                oBd.CerrarConexion();
            }

            return rslt;
        }
        public bool EliminarCliente(string idCliente)
        {
            int id = Convert.ToInt32(idCliente);
            try
            {
                using (MIGANEntities db = new MIGANEntities())
                {
                    CLIENTE oCliente = db.CLIENTE.Where(d => d.CEDULA == id).First();
                    db.CLIENTE.Remove(oCliente);
                    db.SaveChanges();
                    return true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return false;
        }
        #endregion

    }
}
