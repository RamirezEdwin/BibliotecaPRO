//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AdminLabrary.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Alquileres
    {
        public int Id_alquiler { get; set; }
        public int Id_Lector { get; set; }
        public int Id_libro { get; set; }
        public int cantidad { get; set; }
        public int Entregado { get; set; }
        public System.DateTime fecha_salida { get; set; }
        public System.DateTime fecha_prevista_de_entrega { get; set; }
        public Nullable<System.DateTime> fecha_de_entrega { get; set; }
        public Nullable<int> Recibido { get; set; }
    
        public virtual Roles Roles { get; set; }
        public virtual Lectores Lectores { get; set; }
        public virtual Libros Libros { get; set; }
        public virtual Roles Roles1 { get; set; }
    }
}
