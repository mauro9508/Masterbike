//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Masterbike.DALC
{
    using System;
    using System.Collections.Generic;
    
    public partial class INGRESO
    {
        public INGRESO()
        {
            this.DETALLEINGRESO = new HashSet<DETALLEINGRESO>();
        }
    
        public short ID_INGRESO { get; set; }
        public string TIPOCOMPROBANTE { get; set; }
        public Nullable<int> NUMCOMPROBANTE { get; set; }
        public Nullable<System.DateTime> FECHHORA { get; set; }
        public short ID_PROVEEDOR { get; set; }
    
        public virtual ICollection<DETALLEINGRESO> DETALLEINGRESO { get; set; }
        public virtual PROVEEDOR PROVEEDOR { get; set; }
    }
}
