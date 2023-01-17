using OFLP.Controlador;
using OFLP.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;

namespace OFLP.Modelo
{
    public class MCliente
    {
     
        public string PrimerApellido { get; set; }
        public string SegundoApellido { get; set; }
        public string NombreCliente { get; set; }
        public int CedulaCliente { get; set; }
        public string Descripcion { get; set; }
        public bool LlenarGrid()
        {
            try
            {
                ClsInicio.clientes.Clear();
                using (MIGANEntities db = new MIGANEntities())
                {
                    var lstCliente = db.CLIENTE;
                    foreach (var cliente in lstCliente)
                    {
                        ClsInicio.clientes.Add(new MCliente()
                        {
                            CedulaCliente = Convert.ToInt32(cliente.CEDULA),
                            NombreCliente = cliente.NOMBRE.ToString(),
                            PrimerApellido = cliente.PRIMERAPELLIDO.ToString(),
                            SegundoApellido = cliente.SEGUNDOAPELLIDO
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
        public List<MCliente> BuscarPropietario(string datoBuscar)
        {


            List<MCliente> lstBusqueda = new List<MCliente>();


            lstBusqueda = (from cust in ClsInicio.clientes
                           where cust.PrimerApellido.StartsWith(datoBuscar)
                           select cust).ToList();
            return lstBusqueda;
        }
        public bool InsertarCliente(string[] datos)
        {
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
    }
}
