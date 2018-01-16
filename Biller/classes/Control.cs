using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Biller.classes
{
    public class Control
    {
        public string NumCedulaEmisor { get; set; }
        public string NumConsecutivo { get; set; }
        public string TipoCFD { get; set; }
        public string FechaEmisionDoc { get; set; }
        public string Es_TiqueteElectronico { get; set; }
        public string Numero_Tienda { get; set; }
        public string Numero_Terminal { get; set; }
        public string Monto_TotalSerGrav { get; set; }
        public string Monto_TotalSerExen { get; set; }
        public string Monto_TotalMerGrav { get; set; }
        public string Monto_TotalMerExen { get; set; }
        public string Monto_TotalGravado { get; set; }
        public string Monto_TotalExento { get; set; }
        public string Monto_SubTotal { get; set; }
        public string Monto_Total_Descuentos { get; set; }
        public string Monto_TotalVentaNeta { get; set; }
        public string Monto_ImpConsumo { get; set; }
        public string Monto_OtrosImp { get; set; }
        public string Monto_IVA { get; set; }
        public string Monto_Total { get; set; }
        public string Numeracion_FE { get; set; }
        public string Serie_Comprobante { get; set; }
        public string Cantidad_Lineas { get; set; }


        public override string ToString()
        {



            return string.Join("|",
                                this.NumCedulaEmisor,
                                this.NumConsecutivo,
                                this.TipoCFD,
                                this.FechaEmisionDoc,
                                this.Es_TiqueteElectronico,
                                this.Numero_Tienda,
                                this.Numero_Terminal,
                                this.Monto_TotalSerGrav,
                                this.Monto_TotalSerExen,
                                this.Monto_TotalMerGrav,
                                this.Monto_TotalMerExen,
                                this.Monto_TotalGravado,
                                this.Monto_TotalExento,
                                this.Monto_SubTotal,
                                this.Monto_Total_Descuentos,
                                this.Monto_TotalVentaNeta,
                                this.Monto_ImpConsumo,
                                this.Monto_OtrosImp,
                                this.Monto_IVA,
                                this.Monto_Total,
                                this.Numeracion_FE,
                                this.Serie_Comprobante,
                                this.Cantidad_Lineas);
        }
    }
}
