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
    
    public partial class Usuarios_HistorialJefaturas
    {
        public int id { get; set; }
        public int idUsuario { get; set; }
        public System.DateTime fecha { get; set; }
        public System.TimeSpan hora { get; set; }
        public Nullable<int> departamentoModificado { get; set; }
    }
}
