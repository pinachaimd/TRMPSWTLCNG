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
    
    public partial class CAT_TRASLADOS_Historial_Notaria
    {
        public int id { get; set; }
        public string TipoModificacion { get; set; }
        public string Notaria { get; set; }
        public string TitularNombre { get; set; }
        public string TitularApellidoMaterno { get; set; }
        public string TitularApellidoPaterno { get; set; }
        public string Calle { get; set; }
        public string NumExt { get; set; }
        public string Colonia { get; set; }
        public string Telefono { get; set; }
        public System.DateTime FechaModificacion { get; set; }
        public int idAnterior { get; set; }
    }
}
