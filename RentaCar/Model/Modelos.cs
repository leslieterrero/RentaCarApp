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
    
    public partial class Modelos
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Modelos()
        {
            this.Vehiculos = new HashSet<Vehiculos>();
        }
    
        public int id { get; set; }
        public Nullable<int> id_marca { get; set; }
        public string descripcion { get; set; }
        public string estado { get; set; }
    
        public virtual Marcas Marcas { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Vehiculos> Vehiculos { get; set; }
    }
}