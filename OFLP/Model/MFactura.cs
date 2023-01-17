using OFLP.Controlador;
using OFLP.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;

namespace OFLP.Modelo
{
    class MFactura
    {

        public Int32 IdFactura { get; set; }
        public Double NumeroFactura { get; set; }
        public int Reunion { get; set; }
        public DateTime Fecha { get; set; }
        public string Propietario { get; set; }
        public int PropietarioID { get; set; }
        public string Clase { get; set; }
        public int ClaseID { get; set; }
        public int Corral { get; set; }
        public int Cabezas { get; set; }
        public string Sexo { get; set; }
        public int SexoID { get; set; }
        public string Comprador { get; set; }
        public int CompradorID { get; set; }
        public int Kilos { get; set; }
        public int ValorKilo { get; set; }
        public int ValorTotal { get; set; }
        public int Gasto { get; set; }
        public int GastoID { get; set; }

        public bool AgregarFactura(List<FACTURA> datos)
        {
            
            try
            {
                using (MIGANEntities db = new MIGANEntities())
                {
                    db.FACTURA.Add(datos.FirstOrDefault());
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

        public bool LlenarGrid()
        {
            try
            {
                ClsInicio.Factura.Clear();
                using (MIGANEntities db = new MIGANEntities())
                {
                    var lstFactura = db.FACTURA;
                    foreach (var oFactura in lstFactura)
                    {
                        ClsInicio.Factura.Add(new MFactura()
                        {
                            NumeroFactura = Convert.ToInt32(oFactura.consecutivo),
                            Reunion = oFactura.reunion,
                            Fecha = oFactura.fecha,
                            PropietarioID = oFactura.clienteID,
                            ClaseID = oFactura.claseID,
                            Corral = (int)oFactura.corral,
                            Cabezas = (int)oFactura.cabezas,
                            SexoID = oFactura.sexoID,
                            CompradorID = oFactura.compradorID,
                            Kilos = oFactura.kilos,
                            ValorKilo = oFactura.valorkilo,
                            ValorTotal = oFactura.valortotal,
                            GastoID = oFactura.gastoID
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
        public bool Eliminarfactura(string consecutivo)
        {
            bool rslt = false;
            UtilidadesBd oBd = new UtilidadesBd();

            if (oBd.AbrirConexion())
            {
                try
                {
                    SqlCommand command = new SqlCommand(oBd.Definirquery("EliminarFactura"), oBd.Con);

                    command.Parameters.AddWithValue("@consecutivo", consecutivo);

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





    }
}
