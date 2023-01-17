using OFLP.Controlador;
using System;
using System.Linq;

namespace OFLP.Model
{
    internal class MUsuario
    {
        public bool ValidarUsuario(string user,string pass)
        {
            try
            {
                using (MIGANEntities db = new MIGANEntities()) return db.USUARIO.Any(p => p.USUARIO1.Equals(user) && p.CONTRASENA.Equals(pass));
            }
            catch (Exception err)
            {
                CtrlUtilidades.ImprimirLog("ERROR ---------------> " + err.Message);
                CtrlUtilidades.ImprimirLog("ERROR ---------------> " + err.StackTrace);
                return false;
            }
        }
    }
}
