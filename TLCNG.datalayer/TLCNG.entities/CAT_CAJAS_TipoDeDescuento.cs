//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TLCNG.entities
{
    using System;
    using System.Collections.Generic;
    
    public partial class CAT_CAJAS_TipoDeDescuento
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public CAT_CAJAS_TipoDeDescuento()
        {
            this.CAJAS_Descuento = new HashSet<CAJAS_Descuento>();
        }
    
        public int IdTipo { get; set; }
        public string NombreDescuento { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CAJAS_Descuento> CAJAS_Descuento { get; set; }
    }
}
