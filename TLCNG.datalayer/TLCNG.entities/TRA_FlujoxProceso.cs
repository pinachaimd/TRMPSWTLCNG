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
    
    public partial class TRA_FlujoxProceso
    {
        public int id { get; set; }
        public int tarea { get; set; }
        public int TipoProceso { get; set; }
        public int ordenDeRealizacion { get; set; }
        public int tiempoAproximado { get; set; }
        public bool requiereAnteriorFinalizado { get; set; }
    
        public virtual CAT_TRASLADOS_TipoProceso CAT_TRASLADOS_TipoProceso { get; set; }
    }
}
