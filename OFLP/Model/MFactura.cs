using OFLP.Controlador;
using OFLP.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace OFLP.Modelo
{
    class MFactura
    {
        public Int32 Id { get; set; }
        public Int32 IdFactura { get; set; }
        public Double NumeroFactura { get; set; }
        public int Reunion { get; set; }
        public DateTime Fecha { get; set; }
        public string Propietario { get; set; }
        public int PropietarioID { get; set; }
        public string Clase { get; set; }
        public int ClaseID { get; set; }
        public int Corral { get; set; }
        public int Cabezas { get; set; }
        public string Sexo { get; set; }
        public int SexoID { get; set; }
        public string Comprador { get; set; }
        public int CompradorID { get; set; }
        public int Kilos { get; set; }
        public int ValorKilo { get; set; }
        public int ValorTotal { get; set; }
        public int Gasto { get; set; }
        public int GastoID { get; set; }

        public bool AgregarFactura(List<FACTURA> datos)
        {
            try
            {
                using (MIGANEntities db = new MIGANEntities())
                {
                    db.FACTURA.Add(datos.FirstOrDefault());
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

        public bool ActualizarFactura(List<FACTURA> datos, int index)
        {
            
            DateTime fecha= datos[index].fecha;
            //int idcomprador = Convert.ToInt32(datos[index].consecutivo);
            int reunion = Convert.ToInt32(datos[index].reunion);
            int cabezas = Convert.ToInt32(datos[index].cabezas);
            int corral = Convert.ToInt32(datos[index].corral);
            int valorKilo = Convert.ToInt32(datos[index].valorkilo);
            int valorT = Convert.ToInt32(datos[index].valortotal);
            int claseId = Convert.ToInt32(datos[index].claseID);
            int sexoId = Convert.ToInt32(datos[index].sexoID);
            int gastoId = Convert.ToInt32(datos[index].gastoID);
            int kilos = Convert.ToInt32(datos[index].kilos);
            int idact = datos[index].id;
            try
            {
                using (MIGANEntities db = new MIGANEntities())
                {
                    FACTURA oFactura = db.FACTURA.Where(d => d.id == idact).FirstOrDefault();
                    oFactura.reunion = reunion;
                    oFactura.cabezas = cabezas;
                    oFactura.corral = corral;
                    oFactura.kilos= kilos;
                    oFactura.valorkilo=valorKilo;
                    oFactura.valortotal = valorT;
                    oFactura.claseID= claseId;
                    oFactura.sexoID= sexoId;
                    oFactura.gastoID= gastoId;
                    //oFactura.compradorID = idcomprador;
                    oFactura.fecha=fecha;

                    db.Entry(oFactura).State = System.Data.Entity.EntityState.Modified;
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

        public bool LlenarGrid()
        {
            try
            {
                ClsInicio.Factura.Clear();
                using (MIGANEntities db = new MIGANEntities())
                {
                    var lstFactura = db.FACTURA;
                    foreach (var oFactura in lstFactura)
                    {
                        ClsInicio.Factura.Add(new MFactura()
                        {
                            Id= Convert.ToInt32(oFactura.id),
                            NumeroFactura = Convert.ToInt32(oFactura.consecutivo),
                            Reunion = oFactura.reunion,
                            Fecha = oFactura.fecha,
                            PropietarioID = oFactura.clienteID,
                            ClaseID = oFactura.claseID,
                            Corral = (int)oFactura.corral,
                            Cabezas = (int)oFactura.cabezas,
                            SexoID = oFactura.sexoID,
                            CompradorID = oFactura.compradorID,
                            Kilos = oFactura.kilos,
                            ValorKilo = oFactura.valorkilo,
                            ValorTotal = oFactura.valortotal,
                            GastoID = oFactura.gastoID
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

        public bool LlenarGridFacturaActualizar(string consecutivo)
        {
            try
            {
                int consec = Convert.ToInt32(consecutivo);
                ClsInicio.FacturaActualizar.Clear();
                using (MIGANEntities db = new MIGANEntities())
                {
                    var lstFacturaActualizar = db.FACTURA.SqlQuery($"Select * from FACTURA where consecutivo={consecutivo}").ToList();
                    foreach (var oFactura in lstFacturaActualizar)
                    {
                        ClsInicio.FacturaActualizar.Add(new MFactura()
                        {
                            Id = Convert.ToInt32(oFactura.id),
                            NumeroFactura = Convert.ToInt32(oFactura.consecutivo),
                            Reunion = oFactura.reunion,
                            Fecha = oFactura.fecha,
                            PropietarioID = oFactura.clienteID,
                            Propietario = $"{oFactura.CLIENTE.NOMBRE} {oFactura.CLIENTE.PRIMERAPELLIDO}",
                            ClaseID = oFactura.claseID,
                            Clase=oFactura.CLASE.descripcion,
                            Corral = (int)oFactura.corral,
                            Cabezas = (int)oFactura.cabezas,
                            SexoID = oFactura.sexoID,
                            Sexo=oFactura.SEXO.descripcion,
                            CompradorID = oFactura.compradorID,
                            Comprador = $"{oFactura.CLIENTE1.NOMBRE} {oFactura.CLIENTE1.PRIMERAPELLIDO}",
                            Kilos = oFactura.kilos,
                            ValorKilo = oFactura.valorkilo,
                            ValorTotal = oFactura.valortotal,
                            GastoID = oFactura.gastoID,
                            Gasto=oFactura.GASTO.Total
                            
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
        public bool Eliminarfactura(string idFactura)
        {
            int id = Convert.ToInt32(idFactura);
            try
            {
                using (MIGANEntities db = new MIGANEntities())
                {
                    var delobj = db.FACTURA.Where(p => p.id == id).ToList();
                    foreach (var factura in delobj)
                    {
                        MGastos oGasto= new MGastos();
                        db.FACTURA.Remove(factura);
                        db.SaveChanges();
                    }
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
