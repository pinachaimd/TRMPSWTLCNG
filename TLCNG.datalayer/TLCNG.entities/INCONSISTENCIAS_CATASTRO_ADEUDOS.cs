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
    
    public partial class INCONSISTENCIAS_CATASTRO_ADEUDOS
    {
        public int Id { get; set; }
        public decimal Adeudo { get; set; }
        public string Clave { get; set; }
        public string NumeroDeCuenta { get; set; }
        public Nullable<decimal> Recargo { get; set; }
        public Nullable<decimal> Multa { get; set; }
        public int año { get; set; }
        public Nullable<decimal> DescuentoGeneral { get; set; }
        public Nullable<decimal> Bimestre1 { get; set; }
        public Nullable<decimal> Bimestre2 { get; set; }
        public Nullable<decimal> Bimestre3 { get; set; }
        public Nullable<decimal> Bimestre4 { get; set; }
        public Nullable<decimal> Bimestre5 { get; set; }
        public Nullable<decimal> Bimestre6 { get; set; }
        public Nullable<decimal> CondonacionGeneral { get; set; }
        public Nullable<decimal> CondonacionMulta { get; set; }
        public Nullable<decimal> CondonacionRecargo { get; set; }
        public Nullable<int> BimestresPagados { get; set; }
    }
}
