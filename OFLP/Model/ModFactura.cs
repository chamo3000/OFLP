using OFLP.Controlador;
using OFLP.Model;
using System;
using System.Data.SqlClient;
using System.Globalization;

namespace OFLP.Modelo
{
    class ModFactura
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

        public bool AgregarFactura(string[] datos )
        {
            bool rslt = false;
            ModUtilidadesBd oBd = new ModUtilidadesBd();
            if (oBd.AbrirConexion())
            {
                try
                {
                    SqlCommand command = new SqlCommand(oBd.Definirquery("AgregarFactura"), oBd.Con);

                    command.Parameters.AddWithValue("@consecutivo", datos[0]);
                    command.Parameters.AddWithValue("@reunion", datos[1]);
                    command.Parameters.AddWithValue("@fecha", datos[2]);
                    command.Parameters.AddWithValue("@id_propietario", datos[3]);
                    command.Parameters.AddWithValue("@id_claseGanado", datos[4]);
                    command.Parameters.AddWithValue("@corral", datos[5]);
                    command.Parameters.AddWithValue("@cabezas", datos[6]);
                    command.Parameters.AddWithValue("@id_sexo", datos[7]);
                    command.Parameters.AddWithValue("@kilos", datos[8]);
                    command.Parameters.AddWithValue("@valorKg", datos[9]);
                    command.Parameters.AddWithValue("@valorTotal", datos[10]);
                    command.Parameters.AddWithValue("@anio", datos[11]);
                    command.Parameters.AddWithValue("@id_comprador", datos[12]);

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
                        ClsInicio.Factura.Add(new ModFactura()
                        {
                            NumeroFactura = Convert.ToInt32(oFactura.consecutivo),
                            Reunion = oFactura.reunion,
                            Fecha = oFactura.fecha,
                            PropietarioID = oFactura.clienteID,
                            ClaseID=oFactura.claseID,
                            Corral= (int)oFactura.corral,
                            Cabezas= (int)oFactura.cabezas,
                            SexoID=oFactura.sexoID,
                            CompradorID=oFactura.compradorID,
                            Kilos=oFactura.kilos,
                            ValorKilo=oFactura.valorkilo,
                            ValorTotal=oFactura.valortotal,
                            GastoID=oFactura.gastoID
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
            ModUtilidadesBd oBd = new ModUtilidadesBd();

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
