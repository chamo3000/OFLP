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
            using (MIGANEntities db =new MIGANEntities()) 
            {
                var lstUser = db.USUARIO;
                foreach (var User in lstUser)
                {
                    if (User.USUARIO1.Equals(Usuario) && User.CONTRASENA.Equals(Password)) 
                        return true;
                }
            }
            return false;
        }

    }
}
