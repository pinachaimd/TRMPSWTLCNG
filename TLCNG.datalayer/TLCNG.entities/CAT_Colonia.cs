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
    
    public partial class CAT_Colonia
    {
        public int Id { get; set; }
        public Nullable<int> IdTipoColonia { get; set; }
        public Nullable<int> ClaveColonia { get; set; }
        public string Nombre { get; set; }
        public string CodigoPostal { get; set; }
        public string NombreLocalidad { get; set; }
        public string IdLocalidad { get; set; }
        public string NombreMunicipio { get; set; }
        public Nullable<int> IdMunicipio { get; set; }
        public string NombreEntidad { get; set; }
        public Nullable<int> IdEntidad { get; set; }
    }
}
