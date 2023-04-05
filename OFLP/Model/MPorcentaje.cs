using OFLP.Controlador;
using System;
using System.Linq;

namespace OFLP.Model
{
    internal class MPorcentaje
    {
        public int Id { get; set; }
        public Decimal Feria { get; set; }
        public Decimal Recibida { get; set; }
        public Decimal Comision { get; set; }
        public Decimal FondoNal { get; set; }

        public bool SelectPorcent()
        {
            try
            {
                ClsInicio.Porcentajes.Clear();
                using (MIGANEntities db = new MIGANEntities())
                {
                    var lstPorcentaje = db.Porcentajes;
                    foreach (var oPorcentaje in lstPorcentaje)
                    {
                        ClsInicio.Porcentajes.Add(new MPorcentaje()
                        {
                            Id = Convert.ToInt32(oPorcentaje.ID),
                            Feria = Convert.ToDecimal(oPorcentaje.Feria),
                            Recibida = Convert.ToDecimal(oPorcentaje.Recibida),
                            Comision = Convert.ToDecimal(oPorcentaje.Comision),
                            FondoNal = Convert.ToDecimal(oPorcentaje.FondoNal)
                        });
                    }

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

        public bool ActualizarPorcentaje(string[] datosActualizar)
        {
            try
            {
                int id = Convert.ToInt32(datosActualizar[0]);
                using (MIGANEntities db = new MIGANEntities())
                {
                    Porcentajes oPorcentaje = db.Porcentajes.Where(d => d.ID == id).First();

                    oPorcentaje.Feria = Convert.ToDecimal(datosActualizar[1]);
                    oPorcentaje.Recibida = Convert.ToDecimal(datosActualizar[2]);
                    oPorcentaje.Comision = Convert.ToDecimal(datosActualizar[3]);
                    oPorcentaje.FondoNal = Convert.ToDecimal(datosActualizar[4]);
                    db.Entry(oPorcentaje).State = System.Data.Entity.EntityState.Modified;
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


    }
}
