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
    
    public partial class PRODUCTO
    {
        public PRODUCTO()
        {
            this.DETALLEINGRESO = new HashSet<DETALLEINGRESO>();
            this.DETALLEVENTA = new HashSet<DETALLEVENTA>();
            this.DOCUMENTACION = new HashSet<DOCUMENTACION>();
            this.VENTA = new HashSet<VENTA>();
        }
    
        public short ID_PRODUCTO { get; set; }
        public string NOMBREPRODUCTO { get; set; }
        public string TIPOPRODUCTO { get; set; }
        public string DESCRIPCION { get; set; }
        public string FABRICPROPIA { get; set; }
        public int VALPRODUCTO { get; set; }
        public string MARCA { get; set; }
        public string MODELO { get; set; }
        public int STOCK { get; set; }
        public byte[] IMAGEN { get; set; }
    
        public virtual ICollection<DETALLEINGRESO> DETALLEINGRESO { get; set; }
        public virtual ICollection<DETALLEVENTA> DETALLEVENTA { get; set; }
        public virtual ICollection<DOCUMENTACION> DOCUMENTACION { get; set; }
        public virtual ICollection<VENTA> VENTA { get; set; }
    }
}