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
    
    public partial class Vehiculos
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Vehiculos()
        {
            this.Inspeccion = new HashSet<Inspeccion>();
            this.Renta_devolucion = new HashSet<Renta_devolucion>();
        }
    
        public int id { get; set; }
        public string descripcion { get; set; }
        public string no_chasis { get; set; }
        public string no_motor { get; set; }
        public string no_placa { get; set; }
        public Nullable<int> id_tipo_vehiculo { get; set; }
        public Nullable<int> id_marca { get; set; }
        public Nullable<int> id_modelo { get; set; }
        public Nullable<int> id_tipo_combustible { get; set; }
        public string estado { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Inspeccion> Inspeccion { get; set; }
        public virtual Marcas Marcas { get; set; }
        public virtual Modelos Modelos { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Renta_devolucion> Renta_devolucion { get; set; }
        public virtual Tipo_vehiculos Tipo_vehiculos { get; set; }
        public virtual Tipos_combustible Tipos_combustible { get; set; }
    }
}
