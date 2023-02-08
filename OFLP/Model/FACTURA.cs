//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
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
        public DateTime fecha { get; set; }
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
