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
    
    public partial class SEGUIMIENTOENVIOS
    {
        public short ID_SEGUI_ENVIOS { get; set; }
        public string TIPOENTREGA { get; set; }
        public string TIPOPAGO { get; set; }
        public string DIRECCENTREGA { get; set; }
        public string ESTADOENTREGA { get; set; }
        public string EMPTRANSPORTE { get; set; }
        public System.DateTime FECDESPACHO { get; set; }
        public System.DateTime FECENTREGA { get; set; }
        public short ID_VENTA { get; set; }
    
        public virtual VENTA VENTA { get; set; }
    }
}
