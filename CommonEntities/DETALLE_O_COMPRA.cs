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
    
    public partial class DETALLE_O_COMPRA
    {
        public decimal ID_DETALLE { get; set; }
        public decimal O_COMPRA_ID_ORDEN { get; set; }
        public Nullable<decimal> PRODUCTO_ID_PRODUCTO { get; set; }
        public decimal CANTIDAD { get; set; }
        public Nullable<decimal> SUB_TOTAL { get; set; }
    
        public virtual O_COMPRA O_COMPRA { get; set; }
        public virtual PRODUCTO PRODUCTO { get; set; }
    }
}
