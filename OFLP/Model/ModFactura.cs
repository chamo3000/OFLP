using OFLP.Controlador;
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
        public string Fecha { get; set; }
        public string Propietario { get; set; }
        public string Clase { get; set; }
        public int Corral { get; set; }
        public int Cabezas { get; set; }
        public string Sexo { get; set; }
        public string Comprador { get; set; }
        public int Kilos { get; set; }
        public int ValorKilo { get; set; }
        public int ValorTotal { get; set; }
      
        private string SQL;


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
            SQL = "select * from VISTAFACTURA";

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
                    SqlDataReader reader = command.ExecuteReader();
                    ClsInicio.Factura.Clear();
                    while (reader.Read())
                    {
                        ClsInicio.Factura.Add(new ModFactura()
                        {
                            IdFactura = Convert.ToInt32(reader[0]),
                            NumeroFactura =Convert.ToDouble(reader[1]),
                            Reunion = Convert.ToInt32(reader[2]),
                            Fecha = reader[3].ToString(),
                            Propietario = reader[4].ToString() + " " + reader[5].ToString(),
                            Clase = reader[6].ToString(),
                            Corral = Convert.ToInt32(reader[7]),
                            Cabezas = Convert.ToInt32(reader[8]),
                            Sexo = reader[9].ToString(),
                            Comprador = reader[14].ToString() + " " + reader[15].ToString(),
                            Kilos = Convert.ToInt32(reader[10]),
                            ValorKilo =  Convert.ToInt32(reader[11]),
                            ValorTotal= Convert.ToInt32(reader[12]),

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

            oBd = null;
            return rslt;
        }





    }
}
