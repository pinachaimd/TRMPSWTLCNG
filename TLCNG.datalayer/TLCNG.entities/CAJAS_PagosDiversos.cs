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
    
    public partial class CAJAS_PagosDiversos
    {
        public int Id { get; set; }
        public int IdFolio { get; set; }
        public string NombreSolicitante { get; set; }
        public string ApellidoPaternoSolicitante { get; set; }
        public string ApellidoMaternoSolicitante { get; set; }
        public string Direccion { get; set; }
        public string Concepto { get; set; }
        public decimal TotalPagado { get; set; }
        public string NombreComercial { get; set; }
        public string Descripicion { get; set; }
        public string Rfc { get; set; }
        public string Calle { get; set; }
        public string Colonia { get; set; }
        public string Estado { get; set; }
        public string NombreRFC { get; set; }
        public Nullable<int> CP { get; set; }
        public Nullable<int> IdUsuario { get; set; }
    }
}
