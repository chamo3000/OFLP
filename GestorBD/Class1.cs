using System;
using System.Data;
using System.Data.SqlClient;



namespace GestorBD
{
    public class Utilidades
    {
        private SqlConnection con;
        private bool AbrirConexion()
        {
            bool rstl = false;

            try
            {
                con = new SqlConnection(@"Data Source=localhost\SQLEXPRESS;Initial Catalog=OFLBP;Integrated Security=True");
                con.Open();
                rstl = true;
            }
            catch (Exception err)
            {
                //registrar log
            }

            return rstl;
        }

        public DataSet Select(string query)
        {
            DataSet ds = null;

            if (AbrirConexion())
            {
                try
                {
                    ds = new DataSet();
                    SqlDataAdapter dp = new SqlDataAdapter(query, con);
                    dp.Fill(ds);


                }
                catch (Exception err)
                {
                    ds = null;
                    //registrar Log
                }
                CerrarConexion();

            }

            return ds;
        }
        private void CerrarConexion()
        {
            con.Close();
        }

    }
}
