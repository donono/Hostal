//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EntitiesLayer
{
    using System;
    using System.Collections.Generic;
    
    public partial class HABITACION
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public HABITACION()
        {
            this.D_RESERVA = new HashSet<D_RESERVA>();
        }
    
        public decimal ID_HABIT { get; set; }
        public decimal NUM_HABIT { get; set; }
        public string ESTADO { get; set; }
        public decimal PRECIO { get; set; }
        public Nullable<decimal> EQUIPO_ID_EQUIPO { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<D_RESERVA> D_RESERVA { get; set; }
        public virtual EQUIPO EQUIPO { get; set; }
    }
}
