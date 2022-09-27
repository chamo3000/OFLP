using OFLP.Controlador;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OFLP.Modelo
{
    class ModCuenta
    {

        #region Propiedades
        public Int32 id { get; set; }
        public int numeroCuenta { get; set; }
        public string ciudad { get; set; }
        public string sucursal { get; set; }
        public string comentario { get; set; }
        public string idCliente { get; set; }
        public string IdBanco { get; set; }

        private string SQL;
        #endregion

        public bool LlenarGrid()
        {
            SQL = "select * from cuenta";

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
                        ClsInicio.cuenta.Add(new ModCuenta()
                        {
                            id = Convert.ToInt32(reader[0]),
                            numeroCuenta = Convert.ToInt32(reader[1]),
                            ciudad = reader[2].ToString(),
                            sucursal = reader[3].ToString(),
                            comentario = reader[4].ToString(),
                            idCliente = reader[5].ToString(),
                            IdBanco = reader[6].ToString(),

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


        public bool AgregarCuenta(string numero_cuenta, string ciudad, string sucursal, string comentario, int  cmbIdcliente, int cmbIdBanco)
        {
            bool rslt = false;
            ModUtilidadesBd oBd = new ModUtilidadesBd();
            if (oBd.AbrirConexion())
            {
                try
                {
                    SqlCommand command = new SqlCommand(oBd.Definirquery("AgregarCuenta"), oBd.con);

                    command.Parameters.AddWithValue("@numeroCuenta", numero_cuenta);
                    command.Parameters.AddWithValue("@ciudad", ciudad);
                    command.Parameters.AddWithValue("@sucursal", sucursal);
                    command.Parameters.AddWithValue("@comentario", comentario);
                    command.Parameters.AddWithValue("@idcliente", cmbIdcliente);
                    command.Parameters.AddWithValue("@idbanco", cmbIdBanco);





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
    }
}
