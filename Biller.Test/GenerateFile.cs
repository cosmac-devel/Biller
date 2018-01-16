using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;

namespace Biller.Test
{
    [TestClass]
    public class GenerateFile
    {
        [TestMethod]
        public void Generate()
        {
            Biller.classes.Document document = new classes.Document();

            Biller.CSM_FA_factura invoice = document.getInvoice("0612500064");
            List<Biller.CSM_FA_factura_detalle> invoiceDetails = document.getInvoiceDetail("0612500064");

            List<Biller.classes.Detail> details = new List<classes.Detail>();
            foreach (var item in invoiceDetails)
            {
                Biller.CSM_IV_articulo product = new Biller.classes.Product().getInvoiceDetail(item.guid_articulo);
                Biller.classes.Detail detail = new classes.Detail()
                {
                    Linea_Aduana_FechaDoc = "",
                    Linea_Aduana_Nombre = "",
                    Linea_Aduana_NumDoc = "",
                    Linea_Cantidad = (int)item.cantidad,
                    Linea_CuentaPredial_Numero = "",
                    Linea_Descripcion = product.des ,
                    Linea_FraccionArancelaria = "",
                    Linea_Importe = 0,
                    Linea_Notas = "",
                    Linea_PrecioUnitario = (int)item.precio,
                    Linea_Unidad = "Unid",
                    Linea_Monto_Desc = "0.00",
                    Linea_NoIdentificacion = item.guid_articulo
                };
                details.Add(detail);
            }

            string formatString = "yyyyMMddHHmmss";
            string sample = invoice.fecha_hora_factura;
            DateTime dt = DateTime.ParseExact(sample, formatString, null);

            Biller.classes.Header header = new classes.Header()
            {
                ///Pagina 1
                Folio = "00100001010000000001",//1
                Nombre_Emisor = "Cosmac S.A",//2
                RFC_Emisor = "113990734",//3
                Dom_Emisor_calle = "",//4
                Dom_Emisor_noExterior = "",//5
                Dom_Emisor_noInterior = "",//6
                Dom_Emisor_colonia = "2",//7
                Dom_Emisor_localidad = "6",//8
                Dom_Emisor_referencia = "Santo Domingo de Heredia",//9
                Dom_Emisor_municipio = "1",//10
                Dom_Emisor_estado = "2",//11
                Dom_Emisor_pais = "CostaRica",//12
                Dom_Emisor_codigoPostal = "",//13

                ///Pagina 2
                Tel_Emisor = "506:25056600",//14
                Dom_Sucursal_calle = "",//15
                Dom_Sucursal_noExterior = "",//16
                Dom_Sucursal_noInterior = "",//17
                Dom_Sucursal_colonia = "",//18
                Dom_Sucursal_localidad = "",//19
                Dom_Sucursal_referencia = "",//20
                Dom_Sucursal_municipio = "",//21
                Dom_Sucursal_estado = "",//22
                Dom_Sucursal_pais = "",//23
                Dom_Sucursal_codigoPostal = "",//24
                Tel_Sucursal = "",//25
                Version = "4.2",//26
                Serie_Comprobante = "",//27
                Numero_Aprobacion = "3334000286041",//28
                FormaPago = "un solo pago",//29
                Fecha = dt.ToString("yyyy-MM-dd"),//30
                Hora = String.Format("{0}:{1}:{2}", dt.Hour.ToString("00"), dt.Minute.ToString("00"), dt.Second.ToString("00")),//31
                Dom_LugarExpide_calle = "",//32
                Dom_LugarExpide_noExterior = "",//33
                Dom_LugarExpide_noInterior = "",//34
                Dom_LugarExpide_colonia = "",//35
                Dom_LugarExpide_localidad = "",//36
                Dom_LugarExpide_referencia = "",//37

                ///Pagina 3
                Dom_LugarExpide_municipio = "",//38
                Dom_LugarExpide_estado = "",//39
                Dom_LugarExpide_pais = "Folio",//40
                Dom_LugarExpide_codigoPostal = "",//41
                Nombre_Receptor = "",//42
                RFC_Receptor = "",//43
                Dom_Receptor_calle = "",//44
                Dom_Receptor_noExterior = "",//45
                Dom_Receptor_noInterior = "",//46
                Dom_Receptor_colonia = "",//47
                Dom_Receptor_localidad = "",//48
                Dom_Receptor_referencia = "",//49
                Dom_Receptor_municipio = "",//50
                Dom_Receptor_estado = "",//51
                Dom_Receptor_pais = "",//52
                Dom_Receptor_codigoPostal = "",//53
                Monto_SubTotal = invoice.subtotal,//54
                Monto_IVA = invoice.impuesto_ventas,//55
                Monto_Total = invoice.subtotal - invoice.descuento_al_costo + invoice.impuesto_ventas,//56
                Estado = 1,//57
                TipoCFD = "01",//58
                Notas = "",
                Notas02 = "",
                Notas03 = "",
                Numero_Tienda = "001",//70
                Cod_Moneda = "CRC",
                Cantidad_LineasFactura = invoiceDetails.Count.ToString(),//90
                Condiciones_Pago = "01",//97,
                NombreCom_Emisor = "Cosmac S.A",//106
                Monto_OtrosImp = invoice.impuesto_ventas.ToString(),//108
                Tipo_Receptor = "01",//154
                Email_Emisor = "cosmac@cosmac.co.cr",
                Monto_TotalSerGrav = "0.00",
                Monto_TotalSerExen = "0.00",
                Monto_TotalMerGrav = "0.00",
                Monto_TotalMerExen = "0.00",
                FechaResolucion = "20090109162000",
                RazonReferencia = "",
                Porc_IVA = "0.00",
                Monto_ImpConsumo = "0.00",
                Es_TiqueteElectronico = "0",
                TpoDocRef = "",//167
                TipoDocId_Emisor = "02",
                Numero_Terminal = "00001",
                FechaDocRef = "",
                Monto_Total_Descuentos = invoice.descuento_al_costo.ToString(),
                Monto_TotalVentaNeta = invoice.subtotal.ToString(),
                Metodo_Pago = "99",
                Efecto_Comprobante = "",
                Monto_TotalGravado = invoice.gravado.ToString(),
                Monto_TotalExento = invoice.exento.ToString(),
                Detalles = new List<classes.Detail>()
            };
            header.Detalles.AddRange(details);
            Biller.classes.Control control = new classes.Control()
            {
                NumCedulaEmisor = "113990734",
                NumConsecutivo = "00100001010000000001",
                TipoCFD = header.TipoCFD,
                FechaEmisionDoc = header.Fecha+" "+header.Hora,
                Es_TiqueteElectronico = "0",
                Numero_Tienda = header.Numero_Tienda,
                Numero_Terminal = header.Numero_Terminal,
                Monto_TotalSerGrav = header.Monto_TotalSerGrav,
                Monto_TotalSerExen = header.Monto_TotalSerExen,
                Monto_TotalMerGrav = header.Monto_TotalMerGrav,
                Monto_TotalMerExen = header.Monto_TotalMerExen,
                Monto_TotalGravado = header.Monto_TotalGravado,
                Monto_TotalExento = header.Monto_TotalExento,
                Monto_SubTotal = header.Monto_SubTotal.ToString(),
                Monto_Total_Descuentos = header.Monto_Total_Descuentos,
                Monto_TotalVentaNeta = header.Monto_TotalVentaNeta,
                Monto_ImpConsumo = header.Monto_ImpConsumo,
                Monto_OtrosImp = header.Monto_OtrosImp,
                Monto_IVA = header.Monto_IVA.ToString(),
                Monto_Total = header.Monto_Total.ToString(),
                Numeracion_FE = "0000000001",
                Serie_Comprobante = "",
                Cantidad_Lineas = details.Count.ToString()
            };
            GS1.WSFEBuilderSoapClient WSFEBuilderSoapClient = new GS1.WSFEBuilderSoapClient();
            GS1.procesarTextoPlanoRequest procesarTextoPlanoRequest = new GS1.procesarTextoPlanoRequest();
            procesarTextoPlanoRequest.Body = new GS1.procesarTextoPlanoRequestBody();
            procesarTextoPlanoRequest.Body.password = "cosmac";
            procesarTextoPlanoRequest.Body.usuario = "cosmac";
            procesarTextoPlanoRequest.Body.id = "113990734";
            procesarTextoPlanoRequest.Body.textoPlano = header.ToString();
            procesarTextoPlanoRequest.Body.cifrasDeControl = control.ToString();

            string result = WSFEBuilderSoapClient.procesarTextoPlano(procesarTextoPlanoRequest.Body.usuario, procesarTextoPlanoRequest.Body.password, procesarTextoPlanoRequest.Body.id, procesarTextoPlanoRequest.Body.textoPlano, procesarTextoPlanoRequest.Body.cifrasDeControl);
        }
    }
}
