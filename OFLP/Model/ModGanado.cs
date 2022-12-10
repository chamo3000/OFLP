using OFLP.Controlador;
using OFLP.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OFLP.Modelo
{
    class ModGanado
    {
        public Int32 IdGanado { get; set; }
        public string ClaseGanado { get; set; }
        public string Clase { get; set; }
        public string Descripcion { get; set; }

        public bool LlenarGrid()
        {
            try
            {
                ClsInicio.ganado.Clear();
                using (MIGANEntities db = new MIGANEntities())
                {
                    var lstClase = db.CLASE;
                    foreach (var oClase in lstClase)
                    {
                        ClsInicio.ganado.Add(new ModGanado()
                        {

                            IdGanado = Convert.ToInt32(oClase.id),
                            ClaseGanado = oClase.claseGanado,
                            Clase = oClase.clase1,
                            Descripcion = oClase.descripcion

                        });
                    }
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

        public bool AgregarGanado(string claseGanado, string clase, string descripcion)
        {
            try
            {
                CLASE oClase = new CLASE
                {
                    claseGanado = claseGanado,
                    clase1 = clase,
                    descripcion = descripcion,
                };
                using (MIGANEntities db = new MIGANEntities())
                {
                    db.CLASE.Add(oClase);
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

        public bool ActualizarGanado(string[] datosActualizar)
        {
            int id = Convert.ToInt32(datosActualizar[0]);
            try
            {
                using (MIGANEntities db = new MIGANEntities())
                {
                    CLASE oClase = db.CLASE.Where(d => d.id == id).First();

                    oClase.id = Convert.ToInt32(datosActualizar[0]);
                    oClase.claseGanado = datosActualizar[1];
                    oClase.clase1 = datosActualizar[2];
                    oClase.descripcion = datosActualizar[3];
                    db.Entry(oClase).State = System.Data.Entity.EntityState.Modified;
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

        public bool EliminarGanado(string idGanado)
        {
            int id = Convert.ToInt32(idGanado);
            try
            {
                using (MIGANEntities db = new MIGANEntities())
                {
                    CLASE oClase = db.CLASE.Where(d => d.id == id).First();
                    db.CLASE.Remove(oClase);
                    db.SaveChanges();
                    return true;
                }
            }
            catch (Exception err)
            {
                CtrlUtilidades.ImprimirLog("ERROR ---------------> " + err.Message);
                CtrlUtilidades.ImprimirLog("ERROR ---------------> " + err.StackTrace);
                return false;
            }
        }

        public List<ModGanado> BuscarGanado(string datoBuscar)
        {

            List<ModGanado> lstBusqueda = new List<ModGanado>();

            lstBusqueda = (from cust in ClsInicio.ganado
                           where cust.ClaseGanado.StartsWith(datoBuscar)
                           select cust).ToList();

            return lstBusqueda;
        }
    }
}
