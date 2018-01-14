using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Biller.classes
{
    public class Detail
    {
        /// <summary>
        /// [Linea_Descripcion] | 
        /// </summary>
        public string Linea_Descripcion { get; set; }
        /// <summary>
        /// [Linea_Cantidad] |
        /// </summary>
        public int Linea_Cantidad { get; set; }
        /// <summary>
        /// [Linea_Unidad] | 
        /// </summary>
        public string Linea_Unidad { get; set; }
        /// <summary>
        /// [Linea_PrecioUnitario] |
        /// </summary>
        public int Linea_PrecioUnitario { get; set; }
        /// <summary>
        /// [Linea_Importe] |
        /// </summary>
        public int Linea_Importe { get; set; }
        /// <summary>
        /// [Linea_Aduana_NumDoc] | 
        /// </summary>
        public string Linea_Aduana_NumDoc { get; set; }
        /// <summary>
        /// [Linea_Aduana_FechaDoc] | 
        /// </summary>
        public string Linea_Aduana_FechaDoc { get; set; }
        /// <summary>
        /// [Linea_Aduana_Nombre] |
        /// </summary>
        public string Linea_Aduana_Nombre { get; set; }
        /// <summary>
        /// [Linea_CuentaPredial_Numero] |
        /// </summary>
        public string Linea_CuentaPredial_Numero { get; set; }
        /// <summary>
        /// [Linea_FraccionArancelaria] | 
        /// </summary>
        public string Linea_FraccionArancelaria { get; set; }
        /// <summary>
        /// [Linea_Notas] |
        /// </summary>
        public string Linea_Notas { get; set; }

        public string Linea_Cod_UPC { get; set; }
        public string Linea_Piezas_Empaque { get; set; }
        public string Linea_Cod_DUN { get; set; }
        public string Linea_Cod_Barras { get; set; }
        public string Linea_Cod_Articulo { get; set; }
        public string Linea_Cod_Desc { get; set; }
        public string Linea_Porc_Desc { get; set; }
        public string Linea_Monto_Desc { get; set; }
        public string Linea_PrecioUnitario_SinDesc { get; set; }
        public string Linea_Cant_Empaques_Fac { get; set; }
        public string Linea_Cant_Empaques_Emb { get; set; }
        public string Linea_Porc_IVA { get; set; }
        public string Linea_Monto_IVA { get; set; }
        public string Linea_Porc_IEPS { get; set; }
        public string Linea_Monto_IEPS { get; set; }
        public string Linea_PrecioUnitario_ConImp { get; set; }
        public string Linea_Importe_ConImp { get; set; }
        public string Linea_Frontera { get; set; }
        public string Línea_PaisOrigen { get; set; }
        public string Linea_EAN_Aduana { get; set; }
        public string Linea_Misc01 { get; set; }
        public string Linea_Misc02 { get; set; }
        public string Linea_Misc03 { get; set; }
        public string Linea_Misc04 { get; set; }
        public string Linea_Misc05 { get; set; }
        public string Linea_Misc06 { get; set; }
        public string Linea_Misc07 { get; set; }
        public string Linea_Misc08 { get; set; }
        public string Linea_Misc09 { get; set; }
        public string Linea_Misc10 { get; set; }
        public string Linea_Misc11 { get; set; }
        public string Linea_Misc12 { get; set; }
        public string Linea_Misc13 { get; set; }
        public string Linea_Misc14 { get; set; }
        public string Linea_Misc15 { get; set; }
        public string Linea_Misc16 { get; set; }
        public string Linea_Misc17 { get; set; }
        public string Linea_Misc18 { get; set; }
        public string Linea_Misc19 { get; set; }
        public string Linea_Misc20 { get; set; }
        public string Linea_Misc21 { get; set; }
        public string Linea_Misc22 { get; set; }
        public string Linea_Misc23 { get; set; }
        public string Linea_Misc24 { get; set; }
        public string Linea_Misc25 { get; set; }
        public string Linea_Misc26 { get; set; }
        public string Linea_Misc27 { get; set; }
        public string Linea_Misc28 { get; set; }
        public string Linea_Misc29 { get; set; }
        public string Linea_Misc30 { get; set; }
        public string Linea_Misc31 { get; set; }
        public string Linea_Misc32 { get; set; }
        public string Linea_Misc33 { get; set; }
        public string Linea_Misc34 { get; set; }
        public string Linea_Misc35 { get; set; }
        public string Linea_Misc36 { get; set; }
        public string Linea_Misc37 { get; set; }
        public string Linea_Misc38 { get; set; }
        public string Linea_Misc39 { get; set; }
        public string Linea_Misc40 { get; set; }
        public string Linea_Misc41 { get; set; }
        public string Linea_Misc42 { get; set; }
        public string Linea_Misc43 { get; set; }
        public string Linea_Misc44 { get; set; }
        public string Linea_Misc45 { get; set; }
        public string Linea_Misc46 { get; set; }
        public string Linea_Misc47 { get; set; }
        public string Linea_Misc48 { get; set; }
        public string Linea_Misc49 { get; set; }
        public string Linea_MotivoDescuento { get; set; }
        public string Linea_MedicionSecundaria { get; set; }
        public string Linea_TipoIdent_Adicional { get; set; }
        public string Linea_DescripIdioma { get; set; }
        public string Linea_Cant_Adicional { get; set; }
        public string Linea_Cant_Adicional_Tipo { get; set; }
        public string Linea_Tipo_Referencia { get; set; }
        public string Linea_Calif_NumIdentidad { get; set; }
        public string Linea_TipoEmpaquetado { get; set; }
        public string Linea_Metodo_Pago { get; set; }
        public string Linea_Numero_Lote { get; set; }
        public string Linea_Fecha_ProdLote { get; set; }
        public string Linea_Ind_CargoDescuento { get; set; }
        public string Linea_Inf_CargoDescuento { get; set; }
        public string Linea_Secuencia_Calculo { get; set; }
        public string Linea_Tipo_ServiciosEsp { get; set; }
        public string Linea_Ident_Impuesto { get; set; }
        public string Linea_Cod_EAN { get; set; }
        public string Linea_NoIdentificacion { get; set; }
    }
}
