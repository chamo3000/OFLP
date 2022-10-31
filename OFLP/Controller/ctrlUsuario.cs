using OFLP.Model;

namespace OFLP.Controller
{
    internal class CtrlUsuario
    {
        public bool ValidarCliente(string user, string pass)
        {
            ModUsuario Ousuario = new ModUsuario();

           if(Ousuario.ValidarUsuario(user,pass)) return true;
           return false;
        }
    }
}
