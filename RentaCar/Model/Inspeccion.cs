//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RentaCar.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Inspeccion
    {
        public int id { get; set; }
        public Nullable<int> id_vehiculo { get; set; }
        public Nullable<int> id_cliente { get; set; }
        public Nullable<int> ralladuras { get; set; }
        public string cantidad_combustible { get; set; }
        public string goma_repuesto { get; set; }
        public string gato { get; set; }
        public string roturas_cristal { get; set; }
        public string goma_delantera_izquierda { get; set; }
        public string goma_delantera_derecha { get; set; }
        public string goma_trasera_izquierda { get; set; }
        public string goma_trasera_derecha { get; set; }
        public Nullable<System.DateTime> fecha { get; set; }
        public Nullable<int> id_empleado { get; set; }
        public string estado { get; set; }
    
        public virtual Clientes Clientes { get; set; }
        public virtual Empleados Empleados { get; set; }
        public virtual Vehiculos Vehiculos { get; set; }
    }
}
