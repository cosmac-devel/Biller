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
        public int Folio { get; set; }

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
        public int Tel_Emisor { get; set; }

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
        public int RFC_Receptor { get; set; }

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
        public string Dom_Tienda_noInterio { get; set; }
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
                    item.Linea_Descripcion,
                    item.Linea_Cantidad,
                    item.Linea_Unidad,
                    item.Linea_PrecioUnitario,
                    item.Linea_Importe,
                    item.Linea_Aduana_NumDoc,
                    item.Linea_Aduana_FechaDoc,
                    item.Linea_Aduana_Nombre,
                    item.Linea_CuentaPredial_Numero,
                    item.Linea_FraccionArancelaria,
                    item.Linea_Notas,
                    item.Linea_Cod_UPC,
                    item.Linea_Piezas_Empaque,
                    item.Linea_Cod_DUN,
                    item.Linea_Cod_Barras,
                    item.Linea_Cod_Articulo,
                    item.Linea_Cod_Desc,
                    item.Linea_Porc_Desc,
                    item.Linea_Monto_Desc,
                    item.Linea_PrecioUnitario_SinDesc,
                    item.Linea_Cant_Empaques_Fac,
                    item.Linea_Cant_Empaques_Emb,
                    item.Linea_Porc_IVA,
                    item.Linea_Monto_IVA,
                    item.Linea_Porc_IEPS,
                    item.Linea_Monto_IEPS,
                    item.Linea_PrecioUnitario_ConImp,
                    item.Linea_Importe_ConImp,
                    item.Linea_Frontera,
                    item.Línea_PaisOrigen,
                    item.Linea_EAN_Aduana,
                    item.Linea_Misc01,
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
                    item.Linea_MotivoDescuento,
                    item.Linea_MedicionSecundaria,
                    item.Linea_TipoIdent_Adicional,
                    item.Linea_DescripIdioma,
                    item.Linea_Cant_Adicional,
                    item.Linea_Cant_Adicional_Tipo,
                    item.Linea_Tipo_Referencia,
                    item.Linea_Calif_NumIdentidad,
                    item.Linea_TipoEmpaquetado,
                    item.Linea_Metodo_Pago,
                    item.Linea_Numero_Lote,
                    item.Linea_Fecha_ProdLote,
                    item.Linea_Ind_CargoDescuento,
                    item.Linea_Inf_CargoDescuento,
                    item.Linea_Secuencia_Calculo,
                    item.Linea_Tipo_ServiciosEsp,
                    item.Linea_Ident_Impuesto,
                    item.Linea_Cod_EAN,
                    item.Linea_NoIdentificacion

                    ) + (char)13;
            }

            string header = "~" + string.Join("|",
                                this.Folio,
                                this.Nombre_Emisor,
                                this.RFC_Emisor,
                                this.Dom_Emisor_calle,
                                this.Dom_Emisor_noExterior,
                                this.Dom_Emisor_noInterior,
                                this.Dom_Emisor_colonia,
                                this.Dom_Emisor_localidad,
                                this.Dom_Emisor_referencia,
                                this.Dom_Emisor_municipio,
                                this.Dom_Emisor_estado,
                                this.Dom_Emisor_pais,
                                this.Dom_Emisor_codigoPostal,
                                this.Tel_Emisor,
                                this.Dom_Sucursal_calle,
                                this.Dom_Sucursal_noExterior,
                                this.Dom_Sucursal_noInterior,
                                this.Dom_Sucursal_colonia,
                                this.Dom_Sucursal_localidad,
                                this.Dom_Sucursal_referencia,
                                this.Dom_Sucursal_municipio,
                                this.Dom_Sucursal_estado,
                                this.Dom_Sucursal_pais,
                                this.Dom_Sucursal_codigoPostal,
                                this.Tel_Sucursal,
                                this.Version,
                                this.Serie_Comprobante,
                                this.Numero_Aprobacion,
                                this.FormaPago,
                                this.Fecha,
                                this.Hora,
                                this.Dom_LugarExpide_calle,
                                this.Dom_LugarExpide_noExterior,
                                this.Dom_LugarExpide_noInterior,
                                this.Dom_LugarExpide_colonia,
                                this.Dom_LugarExpide_localidad,
                                this.Dom_LugarExpide_referencia,
                                this.Dom_LugarExpide_municipio,
                                this.Dom_LugarExpide_estado,
                                this.Dom_LugarExpide_pais,
                                this.Dom_LugarExpide_codigoPostal,
                                this.Nombre_Receptor,
                                this.RFC_Receptor,
                                this.Dom_Receptor_calle,
                                this.Dom_Receptor_noExterior,
                                this.Dom_Receptor_noInterior,
                                this.Dom_Receptor_colonia,
                                this.Dom_Receptor_localidad,
                                this.Dom_Receptor_referencia,
                                this.Dom_Receptor_municipio,
                                this.Dom_Receptor_estado,
                                this.Dom_Receptor_pais,
                                this.Dom_Receptor_codigoPostal,
                                this.Monto_SubTotal,
                                this.Monto_IVA,
                                this.Monto_Total,
                                this.Estado,
                                this.TipoCFD,
                                this.Notas,
                                this.Notas02,
                                this.Notas03,
                                this.Dom_Tienda_noInterio,
                                this.Dom_Tienda_colonia,
                                this.Dom_Tienda_localidad,
                                this.Dom_Tienda_referencia,
                                this.Dom_Tienda_municipio,
                                this.Dom_Tienda_estado,
                                this.Dom_Tienda_pais,
                                this.Dom_Tienda_codigoPostal,
                                this.RFC_Tienda,
                                this.Cod_Moneda,
                                this.Dias_Pago,
                                this.Porc_Desc_ProntoPago,
                                this.Porc_Desc_ProntoPago,
                                this.Monto_Desc_ProntoPago,
                                this.Cod_Descuento,
                                this.Porc_Descuento,
                                this.Monto_Descuento,
                                this.Cantidad_LineasFactura,
                                this.Fecha_Vencimiento,
                                this.Cod_Zona,
                                this.Numero_Receptor,
                                this.Cod_Vendedor,
                                this.Nombre_Vendedor,
                                this.Via_Embarque,
                                this.Condiciones_Pago,
                                this.Numero_Pedido,
                                this.Fecha_Pedido,
                                this.Letras_Monto_Total,
                                this.Cantidad_unidades,
                                this.Cantidad_empaques,
                                this.EAN_Receptor,
                                this.EAN_LugarExpide,
                                this.Tel_Receptor,
                                this.NombreCom_Emisor,
                                this.Numero_Emisor,
                                this.Monto_OtrosImp,
                                this.Monto_SubTotal_ApIVA,
                                this.Transportista,
                                this.Numero_Solicitud,
                                this.Desc_Moneda,
                                this.Misc01,
                                this.Misc02,
                                this.Misc03,
                                this.Misc04,
                                this.Misc05,
                                this.Misc06,
                                this.Misc07,
                                this.Misc08,
                                this.Misc09,
                                this.Misc10,
                                this.Misc11,
                                this.Misc12,
                                this.Misc13,
                                this.Misc14,
                                this.Misc15,
                                this.Misc16,
                                this.Misc17,
                                this.Misc18,
                                this.Misc19,
                                this.Misc20,
                                this.Misc21,
                                this.Misc22,
                                this.Misc23,
                                this.Misc24,
                                this.Misc25,
                                this.Misc26,
                                this.Misc27,
                                this.Misc28,
                                this.Misc29,
                                this.Misc30,
                                this.Misc31,
                                this.Misc32,
                                this.Misc33,
                                this.Misc34,
                                this.Misc35,
                                this.Misc36,
                                this.Misc37,
                                this.Misc38,
                                this.Misc39,
                                this.Misc40,
                                this.Misc41,
                                this.Tipo_Receptor,
                                this.Fax_Emisor,
                                this.Monto_TotalSerGrav,
                                this.Monto_TotalSerExen,
                                this.Monto_TotalMerGrav,
                                this.Monto_TotalMerExen,
                                this.FechaResolucion,
                                this.RazonReferencia,
                                this.Porc_IVA,
                                this.Monto_ImpConsumo,
                                this.Es_TiqueteElectronico,
                                this.Delivery_Date,
                                this.TpoDocRef,
                                this.Telefono_RcpExtranjero,
                                this.Num_contrarecibo,
                                this.Fecha_Num_contrarecibo,
                                this.Contacto_Compras,
                                this.Customs_gln,
                                this.Alternate_identification_gln,
                                this.Nombre_Aduana,
                                this.Nombre_Aduana_Ciudad,
                                this.Email_Receptor,
                                this.Tasa_Divisa,
                                this.TipoDocId_Emisor,
                                this.TipoDocId_Receptor,
                                this.NombreCom_Receptor,
                                this.Indicador_Cargo_Descuento,
                                this.Situacion,
                                this.Numero_Terminal,
                                this.Porcentaje_no_aplicado,
                                this.FechaDocRef,
                                this.Monto_Total_Descuentos,
                                this.Monto_TotalVentaNeta,
                                this.Ano_Aprobacion,
                                this.Motivo_Descuento,
                                this.Metodo_Pago,
                                this.Efecto_Comprobante,
                                this.Monto_TotalGravado,
                                this.Monto_TotalExento);

            return header + (char)13 + details;
        }

    }
}
