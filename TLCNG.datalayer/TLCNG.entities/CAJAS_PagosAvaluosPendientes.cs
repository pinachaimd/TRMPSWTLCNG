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
    
    public partial class CAJAS_PagosAvaluosPendientes
    {
        public int Id { get; set; }
        public string claveCatastral { get; set; }
        public string clave { get; set; }
        public string cuenta { get; set; }
        public decimal costoAvaluo { get; set; }
        public bool pagado { get; set; }
        public string nombrePropietario { get; set; }
        public string apellidoPaternoPropietario { get; set; }
        public string apellidoMaternoPropietario { get; set; }
        public string nombreComercial { get; set; }
        public string direccion { get; set; }
        public string Comunidad { get; set; }
        public Nullable<decimal> mtsTerreno { get; set; }
        public Nullable<decimal> mtsConstUrbana { get; set; }
        public Nullable<decimal> mtsConstComercial { get; set; }
        public Nullable<decimal> mtsConstIndustrial { get; set; }
        public Nullable<decimal> valorCatastral { get; set; }
        public Nullable<int> IdFolio { get; set; }
        public string numeroTramite { get; set; }
        public decimal condonacionAvaluo { get; set; }
    }
}
