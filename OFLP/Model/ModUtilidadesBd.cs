using OFLP.Controlador;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OFLP.Modelo
{
    class ModUtilidadesBd
    {

        public SqlConnection Con { get; private set; }



        public string Definirquery(string operacion)
        {
            string query = null;
            switch (operacion)
            {
                case "ValidarUsuario":
                    query = "  select nombre, apellido from usuario  where usuario =@usuario and contrasena=@contrasena";
                    break;
                case "SelecionaDuenoHacienda":
                    query = "select id from cliente where primerApellido=@primerApellido and nombre=@nombre";
                    break;
                case "SelecionaCliente":
                    query = "Select cedula,nombre,primerApellido,segundoApellido from cliente";
                    break;
                case "AgregarCliente":
                    query = "INSERT INTO CLIENTE (primerApellido,segundoApellido,nombre,cedula) values (@primerApellido,@segundoApellido,@nombre,@cedula);";
                    break;
                case "AgregarClaseCliente":
                    query = "insert into CLASECLIENTE (idCliente,idTipoCliente) values (@idCliente,@idTipoCliente)";
                    break;
                case "SelecIdCliente":
                    query = "select id from cliente where primerApellido= @primerApellido and segundoApellido= @segundoApellido and nombre= @nombre and cedula= @cedula ";
                    break;
                case "EliminarCliente":
                    query = "delete from cliente where cedula= @cedula ";
                    break;
                case "EliminarClaseCliente":
                    query = "delete from CLASECLIENTE where idCliente= @idCliente ";
                    break;
                case "ActualizarCliente":
                    query = "UPDATE CLIENTE SET " +
                        "primerApellido = @primerApellido, segundoApellido = @segundoApellido," +
                        " nombre = @nombre" +
                        " WHERE cedula = @cedula; ";
                    break;
                case "ActualizarClienteConCedula":
                    query = "UPDATE CLIENTE SET " +
                        "primerApellido = @primerApellido, segundoApellido = @segundoApellido,cedula = @cedulaAuxiliar," +
                        " nombre = @nombre" +
                        " WHERE cedula = @cedula; ";
                    break;
                case "AgregarHacienda":
                    query = "INSERT INTO HACIENDA (nombre,municipio,idCliente) VALUES (@nombre,@municipio,@idCliente)";
                    break;
                case "ActualizarHacienda":
                    query = "UPDATE HACIENDA SET " +
                        "nombre = @nombrehacienda, municipio = @municipiohacienda," +
                        " idCliente = @idCliente" +
                        " WHERE id = @id; ";
                    break;
                case "EliminarHacienda":
                    query = "DELETE FROM HACIENDA WHERE id = @id;";
                    break;

                case "AgregarBanco":
                    query = "INSERT INTO BANCO (nombre,descripcion) VALUES (@nombre,@descripcion)";
                    break;

                case "ActualizarBanco":
                    query = "UPDATE BANCO SET " +
                        "nombre = @nombre, descripcion = @descripcion" +
                        " WHERE id = @id; ";
                    break;
                case "EliminarBanco":
                    query = "DELETE FROM BANCO WHERE id = @id;";
                    break;

                case "AgregarGanado":
                    query = "INSERT INTO CLASE (claseGanado,clase,descripcion) VALUES (@claseGanado,@clase,@descripcion)";
                    break;

                case "ActualizarGanado":
                    query = "UPDATE CLASE   SET " +
                        "claseGanado = @claseGanado, clase=@clase, descripcion = @descripcion" +
                        " WHERE id = @id; ";
                    break;

                case "EliminarGanado":
                    query = "DELETE FROM CLASE WHERE id = @id;";
                    break;
                case "AgregarSexo":
                    query = "INSERT INTO SEXO (sexo,descripcion) VALUES (@sexo,@descripcion)";
                    break;
                case "ActualizarSexo":
                    query = "UPDATE SEXO  SET " +
                        "sexo = @sexo,descripcion = @descripcion" +
                        " WHERE id = @id; ";
                    break;
                case "EliminarSexo":
                    query = "DELETE FROM SEXO WHERE id = @id;";
                    break;
                case "AgregarCuenta":
                    query = "INSERT INTO CUENTA (numeroCuenta,ciudad,sucursal,comentario,idCliente,idBanco) VALUES (@numeroCuenta,@ciudad,@sucursal,@comentario,@idCliente,@idBanco)";
                    break;
                case "AgregarFactura":
                    query = "INSERT INTO FACTURA (consecutivo,reunion,fecha,id_propietario,id_claseGanado,corral,cabezas,id_sexo,kilos,valorKg,valorTotal,anio,id_comprador) " +
                        "VALUES (@consecutivo,@reunion,@fecha,@id_propietario,@id_claseGanado,@corral,@cabezas,@id_sexo,@kilos,@valorKg,@valorTotal,@anio,@id_comprador)";
                    break;
                case "EliminarFactura":
                    query = "delete from factura where consecutivo= @consecutivo ";
                    break;
            }
            return query;

        
        }

        public bool AbrirConexion()
        {
            bool rstl = false;

            try
            {
                Con = new SqlConnection(ConfigurationManager.AppSettings["conexion"]);
                Con.Open();
                rstl = true;
            }
            catch (Exception err)
            {
                CtrlUtilidades.ImprimirLog("Error: " + err.Message);
                CtrlUtilidades.ImprimirLog("Error: " + err.StackTrace);
            }

            return rstl;
        }

        public void CerrarConexion()
        {
            Con.Close();
        }

    }
}
