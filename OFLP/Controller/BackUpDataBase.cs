using System;
using System.Data.SqlClient;
using OFLP.Controlador;

namespace OFLP.Controller
{
    internal class BackUpDataBase
    {

        SqlConnection con;
        SqlCommand cmd;
        string FechaBackUp;

        public void Createconnection()
        {
            con = new SqlConnection("Data Source=localhost;Database=MIGAN;data source=.; uid=; pwd=;Trusted_Connection=True");
        }

        public void Query(string que)
        {
            try
            {
                // ERROR: Not supported in C#: OnErrorStatement
                Createconnection();
                con.Open();
                cmd = new SqlCommand(que, con);
                cmd.ExecuteNonQuery();
                con.Close();
                CtrlUtilidades.ImprimirLog("Exito al crear el BackUp con fecha: " + FechaBackUp);
            }
            catch (Exception)
            {
                CtrlUtilidades.ImprimirLog("Error al crear el BackUp con fecha: " + FechaBackUp);
            }
        }
        public void BackUp()
        {
            string pathBackUp = @"C:\OFLBP\Bd_Backup\";
            FechaBackUp = DateTime.Now.ToString("dd-MM-yy_HH-mm-ss");
            string strQuery = "Backup database MIGAN  to disk='" + pathBackUp + FechaBackUp + ".bak'";
            Query(strQuery);
        }

    }
}
