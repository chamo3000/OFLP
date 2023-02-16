//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OFLP.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class FACTURA
    {
        public int id { get; set; }
        public int consecutivo { get; set; }
        public int reunion { get; set; }
        public System.DateTime fecha { get; set; }
        public int cabezas { get; set; }
        public Nullable<int> corral { get; set; }
        public int kilos { get; set; }
        public int valorkilo { get; set; }
        public int valortotal { get; set; }
        public int anio { get; set; }
        public int clienteID { get; set; }
        public int claseID { get; set; }
        public int sexoID { get; set; }
        public int gastoID { get; set; }
        public int compradorID { get; set; }
    
        public virtual CLASE CLASE { get; set; }
        public virtual CLIENTE CLIENTE { get; set; }
        public virtual CLIENTE CLIENTE1 { get; set; }
        public virtual GASTO GASTO { get; set; }
        public virtual SEXO SEXO { get; set; }
    }
}
