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
    
    public partial class DETALLEINGRESO
    {
        public short ID_DETALLEIN { get; set; }
        public int CANTIDAD { get; set; }
        public Nullable<int> PRECIOCOMPRA { get; set; }
        public Nullable<int> PRECIOVENTA { get; set; }
        public short ID_INGRESO { get; set; }
        public short ID_PRODUCTO { get; set; }
    
        public virtual INGRESO INGRESO { get; set; }
        public virtual PRODUCTO PRODUCTO { get; set; }
    }
}
