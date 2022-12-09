using OFLP.Controlador;
using OFLP.Modelo;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OFLP.Model
{
    internal class ModUsuario
    {
        public string Usuario { get; set; }
        public string Password { get; set; }
        public bool ValidarUsuario(string user,string pass)
        {
            Usuario = user;
            Password = pass;
            #region codigo sin EF;
            //ModUtilidadesBd oBd = new ModUtilidadesBd();
            //string SQL = oBd.Definirquery("ValidarUsuario");

            //if (Select(SQL))
            //{
            //    return true;
            //}
            //else return false;
            #endregion
            using (MIGANEntities db =new MIGANEntities()) 
            {
                var lstUser = db.USUARIO;
                foreach (var oUser in lstUser)
                {
                    if (oUser.USUARIO1.Equals(Usuario) && oUser.CONTRASENA.Equals(Password)) 
                        return true;
                }
            }
            return false;
        }

    }
}
