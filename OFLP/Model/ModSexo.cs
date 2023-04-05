using OFLP.Controlador;
using OFLP.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace OFLP.Modelo
{
    class ModSexo
    {
        public int Id { get; set; }
        public string Sexo { get; set; }
        public string Descripcion { get; set; }

        public bool LlenarGrid()
        {
            CtrlUtilidades.ImprimirLog("Ingresa llenar datos de la tabla sexo");
            try
            {
                ClsInicio.sexo.Clear();
                using (MIGANEntities db = new MIGANEntities())
                {
                    var lstSexo = db.SEXO;
                    foreach (var oSexo in lstSexo)
                    {
                        ClsInicio.sexo.Add(new ModSexo()
                        {
                            Id = Convert.ToInt32(oSexo.id),
                            Sexo = oSexo.sexo1,
                            Descripcion = oSexo.descripcion
                        });
                    }
                }
                CtrlUtilidades.ImprimirLog("Fin llenar datos de la tabla sexo");
                return true;
            }
            catch (Exception err)
            {
                CtrlUtilidades.ImprimirLog("Error: " + err.Message);
                CtrlUtilidades.ImprimirLog("Error: " + err.StackTrace);
                return false;
            }
        }

        public bool AgregarSexo(string sexo, string descripcion)
        {
            try
            {
                SEXO oSexo = new SEXO
                {
                    sexo1 = sexo,
                    descripcion = descripcion,
                };
                using (MIGANEntities db = new MIGANEntities())
                {
                    db.SEXO.Add(oSexo);
                    db.SaveChanges();
                }
                return true;

            }
            catch (Exception err)
            {
                CtrlUtilidades.ImprimirLog("ERROR ---------------> " + err.Message);
                CtrlUtilidades.ImprimirLog("ERROR ---------------> " + err.StackTrace);
                return false;
            }
        }

        public bool ActualizarSexo(string[] datosActualizar)
        {
            try
            {
                int id = Convert.ToInt32(datosActualizar[0]);
                using (MIGANEntities db = new MIGANEntities())
                {
                    SEXO oSexo = db.SEXO.Where(d => d.id == id).First();

                    oSexo.id = Convert.ToInt32(datosActualizar[0]);
                    oSexo.sexo1 = datosActualizar[1];
                    oSexo.descripcion = datosActualizar[2];
                    db.Entry(oSexo).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();
                }
                return true;
            }
            catch (Exception err)
            {
                CtrlUtilidades.ImprimirLog("Error: " + err.Message);
                CtrlUtilidades.ImprimirLog("Error: " + err.StackTrace);
                return false;
            }
        }

        public bool EliminarSexo(string idSexo)
        {
            int id = Convert.ToInt32(idSexo);
            try
            {
                using (MIGANEntities db = new MIGANEntities())
                {
                    SEXO oSexo = db.SEXO.Where(d => d.id == id).First();
                    db.SEXO.Remove(oSexo);
                    db.SaveChanges();
                    return true;
                }
            }
            catch (Exception err)
            {
                CtrlUtilidades.ImprimirLog("Error: " + err.Message);
                CtrlUtilidades.ImprimirLog("Error: " + err.StackTrace);
                return false;
            }
        }

        public List<ModSexo> BuscarSexo(string datoBuscar)
        {

            List<ModSexo> lstBusqueda = new List<ModSexo>();

            lstBusqueda = (from cust in ClsInicio.sexo
                           where cust.Sexo.StartsWith(datoBuscar)
                           select cust).ToList();

            return lstBusqueda;
        }

    }
}
