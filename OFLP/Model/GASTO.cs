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
    
    public partial class GASTO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public GASTO()
        {
            this.FACTURA = new HashSet<FACTURA>();
        }
    
        public int id { get; set; }
        public Nullable<int> reunion { get; set; }
        public Nullable<int> cliente { get; set; }
        public Nullable<int> bascula { get; set; }
        public Nullable<int> transporte { get; set; }
        public Nullable<int> bano { get; set; }
        public Nullable<int> recibida { get; set; }
        public Nullable<int> comisionF { get; set; }
        public Nullable<int> comisionG { get; set; }
        public Nullable<int> vacuna { get; set; }
        public Nullable<int> anticipo { get; set; }
        public Nullable<int> otros { get; set; }
        public string observacion { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FACTURA> FACTURA { get; set; }
    }
}
