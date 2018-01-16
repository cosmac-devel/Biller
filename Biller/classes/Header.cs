using System.Collections.Generic;
using System;
using System.Linq;
using System.Text;

namespace Biller.classes
{
    public class Header
    {
        /// <summary>
        /// [Folio] | 
        /// {NumeroConsecutivo} Consecutivo
        /// de la factura electrónica. Sólo
        /// números. 20 dígitos máximo.
        /// Obtenido
        /// </summary>
        public string Folio { get; set; }

        /// <summary>
        /// [Nombre_Emisor] | 
        /// {NombreEmisor} Nombre del Emisor
        /// Nombre del Cosmac que realiza la factura
        /// </summary>
        public string Nombre_Emisor { get; set; }

        /// <summary>
        /// [RFC_Emisor] |
        /// {NumCedulaEmisor} Identificación
        /// del Emisor (máximo 12 caracteres
        /// numéricos sin guiones ni espacios)
        /// Cedula jurídica de cosmac
        /// </summary>
        public string RFC_Emisor { get; set; }

        /// <summary>
        /// [Dom_Emisor_calle] |
        /// Calle o Avenida (emisor)
        /// Domicio del emisor  texto libre,no requerido
        /// </summary>
        public string Dom_Emisor_calle { get; set; }

        /// <summary>
        /// [Dom_Emisor_noExterior] |
        /// Exterior No. (emisor)
        /// No requerido
        /// </summary>
        public string Dom_Emisor_noExterior { get; set; }

        /// <summary>
        /// [Dom_Emisor_noInterior] | 
        /// Interior No. (emisor)
        /// </summary>
        public string Dom_Emisor_noInterior { get; set; }
        /// <summary>
        /// [Dom_Emisor_colonia] | 
        /// Código del Distrito 2
        /// No requerido
        /// Este campo debe ser mapeado con los correspondientes de hacienda
        ///(emisor)
        /// </summary>
        public string Dom_Emisor_colonia { get; set; }

        /// <summary>
        /// [Dom_Emisor_localidad] | 
        /// Localidad (emisor) -> Aquí debe ir el
        /// código del Barrio 2.
        /// Este campo debe ser mapeado con los correspondientes de hacienda
        /// </summary>
        public string Dom_Emisor_localidad { get; set; }

        /// <summary>
        /// [Dom_Emisor_referencia] |
        /// {DireccionEmisor} Dirección
        /// completa/otras señas (emisor).
        /// Máximo 160 caracteres.
        /// Dirección exacta del cosmac
        /// </summary>
        public string Dom_Emisor_referencia { get; set; }


        /// <summary>
        /// [Dom_Emisor_municipio] |
        /// Código del Cantón 2
        /// (emisor)
        /// </summary>
        public string Dom_Emisor_municipio { get; set; }

        /// <summary>
        /// [Dom_Emisor_estado] | 
        /// Código de la Provincia 2
        /// (emisor)
        /// </summary>
        public string Dom_Emisor_estado { get; set; }

        /// <summary>
        /// [Dom_Emisor_pais] |
        /// País (emisor)
        /// </summary>
        public string Dom_Emisor_pais { get; set; }

        /// <summary>
        /// [Dom_Emisor_codigoPostal] |
        /// Código postal (emisor)
        /// No requerido
        /// </summary>
        public string Dom_Emisor_codigoPostal { get; set; }

        /// <summary>
        /// [Tel_Emisor] | 
        /// {Emisor;Telefono;NumTelefono}
        /// Solo número de telefono sin guiones, número de interno
        /// </summary>
        public string Tel_Emisor { get; set; }

        /// <summary>
        /// [Dom_Sucursal_calle] | 
        /// Calle o Avenida (sucursal)
        /// no es requerido
        /// </summary>
        public string Dom_Sucursal_calle { get; set; }

        /// <summary>
        /// [Dom_Sucursal_noExterior] | 
        /// Exterior No. (sucursal)
        ///  /// no es requerido
        /// </summary>
        public string Dom_Sucursal_noExterior { get; set; }


        /// <summary>
        /// [Dom_Sucursal_noInterior] |
        /// Interior No. (sucursal)
        /// no es requerido
        /// </summary>
        public string Dom_Sucursal_noInterior { get; set; }

        /// <summary>
        /// [Dom_Sucursal_colonia] | 
        /// Distrito (sucursal)
        /// no es requerido
        /// </summary>
        public string Dom_Sucursal_colonia { get; set; }

        /// <summary>
        ///   [Dom_Sucursal_localidad] | 
        ///   Localidad (sucursal)
        ///   no es requerido
        /// </summary>
        public string Dom_Sucursal_localidad { get; set; }

        /// <summary>
        /// [Dom_Sucursal_referencia] |
        /// Dirección completa (sucursal)
        /// no es requerido
        /// </summary>
        public string Dom_Sucursal_referencia { get; set; }


        /// <summary>
        /// [Dom_Sucursal_municipio] |
        /// Cantón (sucursal)
        /// </summary>
        public string Dom_Sucursal_municipio { get; set; }

        /// <summary>
        /// [Dom_Sucursal_estado] |
        /// Provincia (sucursal)
        /// no es requerido
        /// </summary>
        public string Dom_Sucursal_estado { get; set; }


        /// <summary>
        /// [Dom_Sucursal_pais] |
        /// País (sucursal)
        /// no es requerido
        /// </summary>
        public string Dom_Sucursal_pais { get; set; }


        /// <summary>
        /// [Dom_Sucursal_codigoPostal] |
        /// Código postal (sucursal)
        /// no es requerido
        /// </summary>
        public string Dom_Sucursal_codigoPostal { get; set; }



        /// <summary>
        /// [Tel_Sucursal] |
        /// Teléfono de la sucursal.
        /// no es requerido
        /// </summary>
        public string Tel_Sucursal { get; set; }

        /// <summary>
        /// [Version] | 
        /// {Version} Versión del comprobante
        /// según estándar del Ministerio de
        /// Haciendia (“4.1” la actual).
        /// </summary>
        public string Version { get; set; }

        /// <summary>
        /// No aplica para Costa Rica.[Dejar en
        /// blanco]
        /// no es requerido
        /// </summary>
        public string Serie_Comprobante { get; set; }

        /// <summary>
        /// [Numero_Aprobacion] | 
        /// Número de 13 dígitos asignado por la
        /// DGT al contribuyente como emisor
        /// conforme a la “Constancia de Registro
        /// de Facturación Electrónica”. Ej.:
        /// 3334000286041.
        /// Colocar número de aprovación de prueba para poder facturar.
        /// </summary>
        public string Numero_Aprobacion { get; set; }

        /// <summary>
        /// [FormaPago] | 
        /// Forma de pago (en un pago único o en
        /// cuotas. Ver nota al pie).
        /// no es requerido
        /// </summary>
        public string FormaPago { get; set; }

        /// <summary>
        /// [Fecha] |
        /// {FechaEmisionDoc} Fecha de
        /// emisión (yyyy-MM-dd)
        /// </summary>
        public string Fecha { get; set; }
        /// <summary>
        /// [Hora] | 
        /// Hora de emisión (HH:mm:ss)
        /// </summary>
        public string Hora { get; set; }
        /// <summary>
        /// [Dom_LugarExpide_calle] | 
        /// Calle (lugar de expedición)
        /// No requerido
        /// </summary>
        public string Dom_LugarExpide_calle { get; set; }
        /// <summary>
        /// [Dom_LugarExpide_noExterior] |
        /// Exterior No. (lugar de expedición)
        /// No requerido
        /// </summary>
        public string Dom_LugarExpide_noExterior { get; set; }
        /// <summary>
        /// [Dom_LugarExpide_noInterior] |
        /// Interior No. (lugar de expedición)
        /// No requerido
        /// </summary>
        public string Dom_LugarExpide_noInterior { get; set; }
        /// <summary>
        /// [Dom_LugarExpide_colonia] | 
        /// Distrito (lugar de expedición)
        /// No requerido
        /// </summary>
        public string Dom_LugarExpide_colonia { get; set; }
        /// <summary>
        /// [Dom_LugarExpide_localidad] | 
        /// Localidad (lugar de expedición)
        /// No requerido
        /// </summary>
        public string Dom_LugarExpide_localidad { get; set; }
        /// <summary>
        /// [Dom_LugarExpide_referencia] |
        /// Dirección completa (lugar de
        /// expedición)
        /// No requerido
        /// </summary>
        public string Dom_LugarExpide_referencia { get; set; }
        /// <summary>
        /// [Dom_LugarExpide_municipio] |
        /// Cantón (lugar de expedición)
        /// No requerido
        /// </summary>
        public string Dom_LugarExpide_municipio { get; set; }
        /// <summary>
        /// [Dom_LugarExpide_estado] | 
        /// Provincia (lugar de expedición)
        /// No requerido
        /// </summary>
        public string Dom_LugarExpide_estado { get; set; }

        /// <summary>
        /// [Dom_LugarExpide_pais] |
        /// País (lugar de expedición)
        /// No requerido
        /// </summary>
        public string Dom_LugarExpide_pais { get; set; }
        /// <summary>
        /// [Dom_LugarExpide_codigoPostal] |
        /// Código Postal (lugar de expedición)
        /// No requerido
        /// </summary>
        public string Dom_LugarExpide_codigoPostal { get; set; }
        /// <summary>
        /// [Nombre_Receptor] |
        /// {NombreReceptor} Nombre del
        /// Si es tiquete electronico no es requerido
        /// receptor
        /// </summary>
        public string Nombre_Receptor { get; set; }

        /// <summary>
        /// [RFC_Receptor] | 
        /// {NumCedulaReceptor} Identificación
        /// del receptor. Anteponer una “E” para
        /// identificaciones extranjeras.
        /// Solo números,k alfatanumero en extrangeros
        /// </summary>
        public string RFC_Receptor { get; set; }

        /// <summary>
        /// [Dom_Receptor_calle] |
        /// No requerido
        /// </summary>
        public string Dom_Receptor_calle { get; set; }
        /// <summary>
        /// [Dom_Receptor_noExterior] | 
        /// No requerido
        /// </summary>
        public string Dom_Receptor_noExterior { get; set; }
        /// <summary>
        /// [Dom_Receptor_noInterior] | 
        /// No requerido
        /// </summary>
        public string Dom_Receptor_noInterior { get; set; }
        /// <summary>
        /// [Dom_Receptor_colonia] |
        /// No requerido
        /// </summary>
        public string Dom_Receptor_colonia { get; set; }
        /// <summary>
        /// [Dom_Receptor_localidad] | 
        /// No requerido
        /// </summary>
        public string Dom_Receptor_localidad { get; set; }
        /// <summary>
        /// [Dom_Receptor_referencia] | 
        /// No requerido
        /// </summary>
        public string Dom_Receptor_referencia { get; set; }
        /// <summary>
        /// [Dom_Receptor_municipio]|
        /// No requerido
        /// </summary>
        public string Dom_Receptor_municipio { get; set; }
        /// <summary>
        /// [Dom_Receptor_estado] | 
        /// No requerido
        /// </summary>
        public string Dom_Receptor_estado { get; set; }
        /// <summary>
        /// [Dom_Receptor_pais] | 
        /// No requerido
        /// </summary>
        public string Dom_Receptor_pais { get; set; }
        /// <summary>
        /// [Dom_Receptor_codigoPostal] | 
        /// No requerido
        /// </summary>
        public string Dom_Receptor_codigoPostal { get; set; }


        /// <summary>
        /// [Monto_SubTotal] |
        /// monto sin impuesto y sin descuento
        /// </summary>
        public decimal Monto_SubTotal { get; set; }
        /// <summary>
        /// [Monto_IVA] | 
        /// </summary>
        public decimal Monto_IVA { get; set; }
        /// <summary>
        /// [Monto_Total] | 
        /// </summary>
        public decimal Monto_Total { get; set; }

        /// <summary>
        /// [Estado] | 
        /// Estado del documento.
        /// 0: Anulado mediante nota de crédito.
        /// 1: Vigente
        /// siempre enviar 1
        /// </summary>
        public int Estado { get; set; }

        /// <summary>
        /// {TipoDoc} Tipo de documento electrónico.
        /// 01: Factura/Tiquete Electrónico
        /// 02: Nota de débito
        /// 03: Nota de crédito
        /// </summary>
        public string TipoCFD { get; set; }

        /// <summary>
        /// [Notas]
        /// Comentarios u observaciones acerca
        /// del documento electrónico (texto
        /// abierto que no debe contener retornos
        /// de carro ni barras verticales o pipes
        /// ‘|’).
        /// </summary>
        public string Notas { get; set; }

        /// <summary>
        /// [Notas]
        /// Comentarios u observaciones acerca
        /// del documento electrónico (texto
        /// abierto que no debe contener retornos
        /// de carro ni barras verticales o pipes
        /// ‘|’).
        /// no requerido
        /// </summary>
        public string Notas02 { get; set; }

        /// <summary>
        /// [Notas]
        /// Comentarios u observaciones acerca
        /// del documento electrónico (texto
        /// abierto que no debe contener retornos
        /// de carro ni barras verticales o pipes
        /// ‘|’).
        /// no requerido
        /// </summary>
        public string Notas03 { get; set; }

        public string TradingPartner_Prov { get; set; }


        public string Calif_TradingPartner_Prov { get; set; }

        public string EAN_Proveedor { get; set; }


        public string Numero_Factura { get; set; }

        public string Numero_OrdenCompra { get; set; }

        public string Fecha_OrdenCompra { get; set; }

        public string Numero_Proveedor { get; set; }

        public string EAN_Tienda { get; set; }

        public string Numero_Tienda { get; set; }

        public string Nombre_Tienda { get; set; }

        public string Dom_Tienda_calle { get; set; }

        public string Dom_Tienda_noExterior { get; set; }
        public string Dom_Tienda_noInterior { get; set; }
        public string Dom_Tienda_colonia { get; set; }
        public string Dom_Tienda_localidad { get; set; }
        public string Dom_Tienda_referencia { get; set; }
        public string Dom_Tienda_municipio { get; set; }
        public string Dom_Tienda_estado { get; set; }
        public string Dom_Tienda_pais { get; set; }
        public string Dom_Tienda_codigoPostal { get; set; }
        public string RFC_Tienda { get; set; }
        public string Cod_Moneda { get; set; }
        public string Dias_Pago { get; set; }
        public string Porc_Desc_ProntoPago { get; set; }
        public string Monto_Desc_ProntoPago { get; set; }
        public string Cod_Descuento { get; set; }
        public string Porc_Descuento { get; set; }
        public string Monto_Descuento { get; set; }
        public string Cantidad_LineasFactura { get; set; }
        public string Fecha_Vencimiento { get; set; }
        public string Cod_Zona { get; set; }
        public string Numero_Receptor { get; set; }
        public string Cod_Vendedor { get; set; }
        public string Nombre_Vendedor { get; set; }
        public string Via_Embarque { get; set; }
        public string Condiciones_Pago { get; set; }
        public string Numero_Pedido { get; set; }
        public string Fecha_Pedido { get; set; }
        public string Letras_Monto_Total { get; set; }
        public string Cantidad_unidades { get; set; }
        public string Cantidad_empaques { get; set; }
        public string EAN_Receptor { get; set; }
        public string EAN_LugarExpide { get; set; }
        public string Tel_Receptor { get; set; }
        public string NombreCom_Emisor { get; set; }
        public string Numero_Emisor { get; set; }
        public string Monto_OtrosImp { get; set; }
        public string Monto_SubTotal_ApIVA { get; set; }
        public string Transportista { get; set; }
        public string Numero_Solicitud { get; set; }
        public string Desc_Moneda { get; set; }
        public string Misc01 { get; set; }
        public string Misc02 { get; set; }
        public string Misc03 { get; set; }
        public string Misc04 { get; set; }
        public string Misc05 { get; set; }
        public string Misc06 { get; set; }
        public string Misc07 { get; set; }
        public string Misc08 { get; set; }
        public string Misc09 { get; set; }
        public string Misc10 { get; set; }
        public string Misc11 { get; set; }
        public string Misc12 { get; set; }
        public string Misc13 { get; set; }
        public string Misc14 { get; set; }
        public string Misc15 { get; set; }
        public string Misc16 { get; set; }
        public string Misc17 { get; set; }
        public string Misc18 { get; set; }
        public string Misc19 { get; set; }
        public string Misc20 { get; set; }
        public string Misc21 { get; set; }
        public string Misc22 { get; set; }
        public string Misc23 { get; set; }
        public string Misc24 { get; set; }
        public string Misc25 { get; set; }
        public string Misc26 { get; set; }
        public string Misc27 { get; set; }
        public string Misc28 { get; set; }
        public string Misc29 { get; set; }
        public string Misc30 { get; set; }
        public string Misc31 { get; set; }
        public string Misc32 { get; set; }
        public string Misc33 { get; set; }
        public string Misc34 { get; set; }
        public string Misc35 { get; set; }
        public string Misc36 { get; set; }
        public string Misc37 { get; set; }
        public string Misc38 { get; set; }
        public string Misc39 { get; set; }
        public string Misc40 { get; set; }
        public string Misc41 { get; set; }
        public string Tipo_Receptor { get; set; }
        public string Fax_Emisor { get; set; }
        public string Email_Emisor { get; set; }
        public string Monto_TotalSerGrav { get; set; }
        public string Monto_TotalSerExen { get; set; }
        public string Monto_TotalMerGrav { get; set; }
        public string Monto_TotalMerExen { get; set; }
        public string FechaResolucion { get; set; }
        public string RazonReferencia { get; set; }
        public string Porc_IVA { get; set; }
        public string Monto_ImpConsumo { get; set; }
        public string Es_TiqueteElectronico { get; set; }
        public string Delivery_Date { get; set; }
        public string TpoDocRef { get; set; }
        public string Telefono_RcpExtranjero { get; set; }
        public string Num_contrarecibo { get; set; }
        public string Fecha_Num_contrarecibo { get; set; }
        public string Contacto_Compras { get; set; }
        public string Customs_gln { get; set; }
        public string Alternate_identification_gln { get; set; }
        public string Nombre_Aduana { get; set; }
        public string Nombre_Aduana_Ciudad { get; set; }
        public string Email_Receptor { get; set; }
        public string Tasa_Divisa { get; set; }
        public string TipoDocId_Emisor { get; set; }
        public string TipoDocId_Receptor { get; set; }
        public string NombreCom_Receptor { get; set; }
        public string Indicador_Cargo_Descuento { get; set; }
        public string Situacion { get; set; }
        public string Numero_Terminal { get; set; }
        public string Porcentaje_no_aplicado { get; set; }
        public string FechaDocRef { get; set; }
        public string Monto_Total_Descuentos { get; set; }
        public string Monto_TotalVentaNeta { get; set; }
        public string Ano_Aprobacion { get; set; }
        public string Motivo_Descuento { get; set; }
        public string Metodo_Pago { get; set; }
        public string Efecto_Comprobante { get; set; }
        public string Monto_TotalGravado { get; set; }
        public string Monto_TotalExento { get; set; }

        public List<Detail> Detalles { get; set; }

        public override string ToString()
        {
            string details = "¬";
            foreach (var item in this.Detalles)
            {
                details += string.Join("|",
                    item.Linea_Descripcion,//1
                    item.Linea_Cantidad,//2
                    item.Linea_Unidad,//3
                    item.Linea_PrecioUnitario,//4
                    item.Linea_Importe,//5
                    item.Linea_Aduana_NumDoc,//6
                    item.Linea_Aduana_FechaDoc,//7
                    item.Linea_Aduana_Nombre,//8
                    item.Linea_CuentaPredial_Numero,//9
                    item.Linea_FraccionArancelaria,//10
                    item.Linea_Notas,//11
                    item.Linea_Cod_UPC,//12
                    item.Linea_Piezas_Empaque,//13
                    item.Linea_Cod_DUN,//14
                    item.Linea_Cod_Barras,//15
                    item.Linea_Cod_Articulo,//16
                    item.Linea_Cod_Desc,//17
                    item.Linea_Porc_Desc,//18
                    item.Linea_Monto_Desc,//19
                    item.Linea_PrecioUnitario_SinDesc,//20
                    item.Linea_Cant_Empaques_Fac,//21
                    item.Linea_Cant_Empaques_Emb,//22
                    item.Linea_Porc_IVA,//23
                    item.Linea_Monto_IVA,//24
                    item.Linea_Porc_IEPS,//25
                    item.Linea_Monto_IEPS,//26
                    item.Linea_PrecioUnitario_ConImp,//27
                    item.Linea_Importe_ConImp,//28
                    item.Linea_Frontera,//29
                    item.Línea_PaisOrigen,//30
                    item.Linea_EAN_Aduana,//31
                    item.Linea_Misc01,//32
                    item.Linea_Misc02,
                    item.Linea_Misc03,
                    item.Linea_Misc04,
                    item.Linea_Misc05,
                    item.Linea_Misc06,
                    item.Linea_Misc07,
                    item.Linea_Misc08,
                    item.Linea_Misc09,
                    item.Linea_Misc10,
                    item.Linea_Misc11,
                    item.Linea_Misc12,
                    item.Linea_Misc13,
                    item.Linea_Misc14,
                    item.Linea_Misc15,
                    item.Linea_Misc16,
                    item.Linea_Misc17,
                    item.Linea_Misc18,
                    item.Linea_Misc19,
                    item.Linea_Misc20,
                    item.Linea_Misc21,
                    item.Linea_Misc22,
                    item.Linea_Misc23,
                    item.Linea_Misc24,
                    item.Linea_Misc25,
                    item.Linea_Misc26,
                    item.Linea_Misc27,
                    item.Linea_Misc28,
                    item.Linea_Misc29,
                    item.Linea_Misc30,
                    item.Linea_Misc31,
                    item.Linea_Misc32,
                    item.Linea_Misc33,
                    item.Linea_Misc34,
                    item.Linea_Misc35,
                    item.Linea_Misc36,
                    item.Linea_Misc37,
                    item.Linea_Misc38,
                    item.Linea_Misc39,
                    item.Linea_Misc40,
                    item.Linea_Misc41,
                    item.Linea_Misc42,
                    item.Linea_Misc43,
                    item.Linea_Misc44,
                    item.Linea_Misc45,
                    item.Linea_Misc46,
                    item.Linea_Misc47,
                    item.Linea_Misc48,
                    item.Linea_Misc49,
                    item.Linea_MotivoDescuento,//81
                    item.Linea_MedicionSecundaria,//82
                    item.Linea_TipoIdent_Adicional,//83
                    item.Linea_DescripIdioma,//84
                    item.Linea_Cant_Adicional,//85
                    item.Linea_Cant_Adicional_Tipo,//86
                    item.Linea_Tipo_Referencia,//87
                    item.Linea_Calif_NumIdentidad,//88
                    item.Linea_TipoEmpaquetado,//89
                    item.Linea_Metodo_Pago,//90
                    item.Linea_Numero_Lote,//91
                    item.Linea_Fecha_ProdLote,//92
                    item.Linea_Ind_CargoDescuento,//93
                    item.Linea_Inf_CargoDescuento,//94
                    item.Linea_Secuencia_Calculo,//95
                    item.Linea_Tipo_ServiciosEsp,//96
                    item.Linea_Ident_Impuesto,//97
                    item.Linea_Cod_EAN,//98
                    item.Linea_NoIdentificacion//99
                    ) + Environment.NewLine;
            }

            string header = "~" + string.Join("|",
                                this.Folio,//1
                                this.Nombre_Emisor,//2
                                this.RFC_Emisor,//3
                                this.Dom_Emisor_calle,//4
                                this.Dom_Emisor_noExterior,//5
                                this.Dom_Emisor_noInterior,//6
                                this.Dom_Emisor_colonia,//7
                                this.Dom_Emisor_localidad,//8
                                this.Dom_Emisor_referencia,//9
                                this.Dom_Emisor_municipio,//10
                                this.Dom_Emisor_estado,//11
                                this.Dom_Emisor_pais,//12
                                this.Dom_Emisor_codigoPostal,//13
                                this.Tel_Emisor,//14
                                this.Dom_Sucursal_calle,//15
                                this.Dom_Sucursal_noExterior,//16
                                this.Dom_Sucursal_noInterior,//17
                                this.Dom_Sucursal_colonia,//18
                                this.Dom_Sucursal_localidad,//19
                                this.Dom_Sucursal_referencia,//20
                                this.Dom_Sucursal_municipio,//21
                                this.Dom_Sucursal_estado,//22
                                this.Dom_Sucursal_pais,//23
                                this.Dom_Sucursal_codigoPostal,//24
                                this.Tel_Sucursal,//25
                                this.Version,//26
                                this.Serie_Comprobante,//27
                                this.Numero_Aprobacion,//28
                                this.FormaPago,//19
                                this.Fecha,//30
                                this.Hora,//31
                                this.Dom_LugarExpide_calle,//32
                                this.Dom_LugarExpide_noExterior,//33
                                this.Dom_LugarExpide_noInterior,//34
                                this.Dom_LugarExpide_colonia,//35
                                this.Dom_LugarExpide_localidad,//36
                                this.Dom_LugarExpide_referencia,//37
                                this.Dom_LugarExpide_municipio,//38
                                this.Dom_LugarExpide_estado,//39
                                this.Dom_LugarExpide_pais,//40
                                this.Dom_LugarExpide_codigoPostal,//41
                                this.Nombre_Receptor,//42
                                this.RFC_Receptor,//43
                                this.Dom_Receptor_calle,//44
                                this.Dom_Receptor_noExterior,//45
                                this.Dom_Receptor_noInterior,//46
                                this.Dom_Receptor_colonia,//47
                                this.Dom_Receptor_localidad,//48
                                this.Dom_Receptor_referencia,//49
                                this.Dom_Receptor_municipio,//50
                                this.Dom_Receptor_estado,//51
                                this.Dom_Receptor_pais,//52
                                this.Dom_Receptor_codigoPostal,//53
                                this.Monto_SubTotal,//54
                                this.Monto_IVA,//55
                                this.Monto_Total,//56
                                this.Estado,//57
                                this.TipoCFD,//58
                                this.Notas,//59
                                this.Notas02,//60
                                this.Notas03,//61
                                this.TradingPartner_Prov,//62
                                this.Calif_TradingPartner_Prov,//63
                                this.Numero_Factura,//64
                                this.Numero_OrdenCompra,//65
                                this.Fecha_OrdenCompra,//66
                                this.Numero_Proveedor,//67
                                this.EAN_Tienda,//68
                                this.EAN_Tienda,//69
                                this.Numero_Tienda,//70
                                this.Nombre_Tienda,//71
                                this.Dom_Tienda_calle,//72
                                this.Dom_Tienda_noExterior,//73
                                this.Dom_Tienda_noInterior,//74
                                this.Dom_Tienda_colonia,//75
                                this.Dom_Tienda_localidad,//76
                                this.Dom_Tienda_referencia,//77                                this.Dom_Tienda_municipio,//76
                                this.Dom_Tienda_municipio,//78
                                this.Dom_Tienda_estado,//79
                                this.Dom_Tienda_pais,//80
                                this.Dom_Tienda_codigoPostal,//81
                                this.RFC_Tienda,//82
                                this.Cod_Moneda,//83
                                this.Dias_Pago,//84
                                this.Porc_Desc_ProntoPago,//85
                                this.Monto_Desc_ProntoPago,//86
                                this.Cod_Descuento,//87
                                this.Porc_Descuento,//88
                                this.Monto_Descuento,//89
                                this.Cantidad_LineasFactura,//90
                                this.Fecha_Vencimiento,//91
                                this.Cod_Zona,//92
                                this.Numero_Receptor,//93
                                this.Cod_Vendedor,//94
                                this.Nombre_Vendedor,//95
                                this.Via_Embarque,//96
                                this.Condiciones_Pago,//97
                                this.Numero_Pedido,//98
                                this.Fecha_Pedido,//99
                                this.Letras_Monto_Total,//100
                                this.Cantidad_unidades,//101
                                this.Cantidad_empaques,//102
                                this.EAN_Receptor,//103
                                this.EAN_LugarExpide,//104
                                this.Tel_Receptor,//105
                                this.NombreCom_Emisor,//106
                                this.Numero_Emisor,//107
                                this.Monto_OtrosImp,//108
                                this.Monto_SubTotal_ApIVA,//109
                                this.Transportista,//110
                                this.Numero_Solicitud,//111
                                this.Desc_Moneda,//112
                                this.Misc01,//113
                                this.Misc02,//114
                                this.Misc03,//115
                                this.Misc04,//116
                                this.Misc05,//117
                                this.Misc06,//118
                                this.Misc07,//119
                                this.Misc08,//120
                                this.Misc09,//121
                                this.Misc10,//122
                                this.Misc11,//123
                                this.Misc12,//124
                                this.Misc13,//125
                                this.Misc14,//126
                                this.Misc15,//127
                                this.Misc16,//128
                                this.Misc17,//129
                                this.Misc18,//130
                                this.Misc19,//131
                                this.Misc20,//132
                                this.Misc21,//133
                                this.Misc22,//134
                                this.Misc23,//135
                                this.Misc24,//136
                                this.Misc25,//137
                                this.Misc26,//138
                                this.Misc27,//139
                                this.Misc28,//140
                                this.Misc29,//141
                                this.Misc30,//142
                                this.Misc31,//143
                                this.Misc32,//144
                                this.Misc33,//145
                                this.Misc34,//146
                                this.Misc35,//147
                                this.Misc36,//148
                                this.Misc37,//149
                                this.Misc38,//150
                                this.Misc39,//151
                                this.Misc40,//152
                                this.Misc41,//153
                                this.Tipo_Receptor,//154
                                this.Fax_Emisor,//155
                                this.Email_Emisor,//156
                                this.Monto_TotalSerGrav,//157
                                this.Monto_TotalSerExen,//158
                                this.Monto_TotalMerGrav,//159
                                this.Monto_TotalMerExen,//160
                                this.FechaResolucion,//161
                                this.RazonReferencia,//162
                                this.Porc_IVA,//163
                                this.Monto_ImpConsumo,//164
                                this.Es_TiqueteElectronico,//165
                                this.Delivery_Date,//166
                                this.TpoDocRef,//167
                                this.Telefono_RcpExtranjero,//168
                                this.Num_contrarecibo,//169
                                this.Fecha_Num_contrarecibo,//170
                                this.Contacto_Compras,//171
                                this.Customs_gln,//172
                                this.Alternate_identification_gln,//173
                                this.Nombre_Aduana,//174
                                this.Nombre_Aduana_Ciudad,//175
                                this.Email_Receptor,//176
                                this.Tasa_Divisa,//177
                                this.TipoDocId_Emisor,//178
                                this.TipoDocId_Receptor,//179
                                this.NombreCom_Receptor,//180
                                this.Indicador_Cargo_Descuento,//181
                                this.Situacion,//182
                                this.Numero_Terminal,//183
                                this.Porcentaje_no_aplicado,//184
                                this.FechaDocRef,//185
                                this.Monto_Total_Descuentos,//186
                                this.Monto_TotalVentaNeta,//187
                                this.Ano_Aprobacion,//188
                                this.Motivo_Descuento,//189
                                this.Metodo_Pago,//190
                                this.Efecto_Comprobante,//191
                                this.Monto_TotalGravado,//192
                                this.Monto_TotalExento//193
                                );

            return header + Environment.NewLine + details;
        }

    }
}
