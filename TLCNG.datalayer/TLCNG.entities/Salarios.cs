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
    
    public partial class Salarios
    {
        public int IdSalarios { get; set; }
        public int Anio { get; set; }
        public int BimestreAdeudado { get; set; }
        public int MesesTranscurridos { get; set; }
        public decimal PorcentajeRecargosMensuales { get; set; }
        public string ClaveSalarios { get; set; }
        public Nullable<int> AnioAnterior { get; set; }
    }
}
