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
    
    public partial class TRA_SeguimientoFlujo
    {
        public int id { get; set; }
        public string nroTramite { get; set; }
        public int tarea { get; set; }
        public string tipoFlujo { get; set; }
        public int Estatus { get; set; }
        public string observaciones { get; set; }
        public Nullable<int> duracion { get; set; }
        public int orden { get; set; }
        public Nullable<int> TipoProceso { get; set; }
        public int idUsuario { get; set; }
    
        public virtual CAT_TRASLADOS_EstatusFlujo CAT_TRASLADOS_EstatusFlujo { get; set; }
        public virtual CAT_TRASLADOS_TareasFlujo CAT_TRASLADOS_TareasFlujo { get; set; }
    }
}
