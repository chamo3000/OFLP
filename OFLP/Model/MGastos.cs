﻿using OFLP.Controlador;
using OFLP.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OFLP.Model
{
    internal class MGastos
    {
        public bool InsertarGasto(string[] datos,int total)
        {
            try
            {
                GASTO oGasto = new GASTO
                {
                    reunion = Convert.ToInt32(datos[0]),
                    cliente = Convert.ToInt32(datos[1]),
                    bascula = Convert.ToInt32(datos[2]),
                    transporte = Convert.ToInt32(datos[3]),
                    bano = Convert.ToInt32(datos[4]),
                    recibida = Convert.ToInt32(datos[5]),
                    comisionF = Convert.ToInt32(datos[6]),
                    comisionG = Convert.ToInt32(datos[7]),
                    vacuna = Convert.ToInt32(datos[8]),
                    anticipo = Convert.ToInt32(datos[9]),
                    otros = Convert.ToInt32(datos[10]),
                    observacion = datos[11],
                    idfactura = Convert.ToInt32(datos[12]),
                    Total = total,
                };
                using (MIGANEntities db = new MIGANEntities())
                {
                    db.GASTO.Add(oGasto);
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

        public bool EliminarGasto(int idGasto)
        {
            int id = Convert.ToInt32(idGasto);
            try
            {
                using (MIGANEntities db = new MIGANEntities())
                {
                    GASTO oGasto = db.GASTO.Where(d => d.id == id).First();
                    db.GASTO.Remove(oGasto);
                    db.SaveChanges();
                    return true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return false;
        }
    }
}
