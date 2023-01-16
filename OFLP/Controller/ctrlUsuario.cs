using OFLP.Model;

namespace OFLP.Controller
{
    internal class CtrlUsuario
    {
        public bool ValidarCliente(string user, string pass)
        {
            MUsuario Ousuario = new MUsuario();

           if(Ousuario.ValidarUsuario(user,pass)) return true;
           return false;
        }
    }
}
