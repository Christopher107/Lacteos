//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AccesoDatos
{
    using System;
    using System.Collections.Generic;
    
    public partial class HorasExtras
    {
        public int Id { get; set; }
        public Nullable<int> Rut { get; set; }
        public Nullable<int> HorasExtras1 { get; set; }
        public Nullable<System.DateTime> Fecha { get; set; }
    
        public virtual Trabajador Trabajador { get; set; }
    }
}
