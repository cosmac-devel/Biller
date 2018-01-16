﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.17929
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Biller
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="CMS")]
	public partial class DataBaseDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Extensibility Method Definitions
    partial void OnCreated();
    #endregion
		
		public DataBaseDataContext() : 
				base(global::Biller.Properties.Settings.Default.CMSConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public DataBaseDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataBaseDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataBaseDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public DataBaseDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<CSM_FA_factura> CSM_FA_facturas
		{
			get
			{
				return this.GetTable<CSM_FA_factura>();
			}
		}
		
		public System.Data.Linq.Table<CSM_FA_factura_detalle> CSM_FA_factura_detalles
		{
			get
			{
				return this.GetTable<CSM_FA_factura_detalle>();
			}
		}
		
		public System.Data.Linq.Table<CSM_CC_TP_movimiento> CSM_CC_TP_movimientos
		{
			get
			{
				return this.GetTable<CSM_CC_TP_movimiento>();
			}
		}
		
		public System.Data.Linq.Table<CSM_IV_articulo> CSM_IV_articulos
		{
			get
			{
				return this.GetTable<CSM_IV_articulo>();
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.CSM_FA_factura")]
	public partial class CSM_FA_factura
	{
		
		private string _guid;
		
		private string _consecutivo;
		
		private string _cod_cliente;
		
		private string _cod_vendedor;
		
		private string _cod_tp_precio;
		
		private string _fecha_hora_factura;
		
		private decimal _subtotal;
		
		private decimal _descuento_al_costo;
		
		private decimal _impuesto_ventas;
		
		private decimal _gravado;
		
		private decimal _exento;
		
		private decimal _porc_exonerado;
		
		private decimal _monto_exoneracion;
		
		private bool _sta;
		
		private string _observaciones;
		
		private System.Nullable<byte> _con_tp_factura;
		
		private System.Nullable<bool> _preventa;
		
		public CSM_FA_factura()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_guid", DbType="Char(10) NOT NULL", CanBeNull=false)]
		public string guid
		{
			get
			{
				return this._guid;
			}
			set
			{
				if ((this._guid != value))
				{
					this._guid = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_consecutivo", DbType="Char(10) NOT NULL", CanBeNull=false)]
		public string consecutivo
		{
			get
			{
				return this._consecutivo;
			}
			set
			{
				if ((this._consecutivo != value))
				{
					this._consecutivo = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_cod_cliente", DbType="Char(4) NOT NULL", CanBeNull=false)]
		public string cod_cliente
		{
			get
			{
				return this._cod_cliente;
			}
			set
			{
				if ((this._cod_cliente != value))
				{
					this._cod_cliente = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_cod_vendedor", DbType="Char(4) NOT NULL", CanBeNull=false)]
		public string cod_vendedor
		{
			get
			{
				return this._cod_vendedor;
			}
			set
			{
				if ((this._cod_vendedor != value))
				{
					this._cod_vendedor = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_cod_tp_precio", DbType="Char(4) NOT NULL", CanBeNull=false)]
		public string cod_tp_precio
		{
			get
			{
				return this._cod_tp_precio;
			}
			set
			{
				if ((this._cod_tp_precio != value))
				{
					this._cod_tp_precio = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_fecha_hora_factura", DbType="Char(14) NOT NULL", CanBeNull=false)]
		public string fecha_hora_factura
		{
			get
			{
				return this._fecha_hora_factura;
			}
			set
			{
				if ((this._fecha_hora_factura != value))
				{
					this._fecha_hora_factura = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_subtotal", DbType="Money NOT NULL")]
		public decimal subtotal
		{
			get
			{
				return this._subtotal;
			}
			set
			{
				if ((this._subtotal != value))
				{
					this._subtotal = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_descuento_al_costo", DbType="Money NOT NULL")]
		public decimal descuento_al_costo
		{
			get
			{
				return this._descuento_al_costo;
			}
			set
			{
				if ((this._descuento_al_costo != value))
				{
					this._descuento_al_costo = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_impuesto_ventas", DbType="Money NOT NULL")]
		public decimal impuesto_ventas
		{
			get
			{
				return this._impuesto_ventas;
			}
			set
			{
				if ((this._impuesto_ventas != value))
				{
					this._impuesto_ventas = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_gravado", DbType="Money NOT NULL")]
		public decimal gravado
		{
			get
			{
				return this._gravado;
			}
			set
			{
				if ((this._gravado != value))
				{
					this._gravado = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_exento", DbType="Money NOT NULL")]
		public decimal exento
		{
			get
			{
				return this._exento;
			}
			set
			{
				if ((this._exento != value))
				{
					this._exento = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_porc_exonerado", DbType="Money NOT NULL")]
		public decimal porc_exonerado
		{
			get
			{
				return this._porc_exonerado;
			}
			set
			{
				if ((this._porc_exonerado != value))
				{
					this._porc_exonerado = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_monto_exoneracion", DbType="Money NOT NULL")]
		public decimal monto_exoneracion
		{
			get
			{
				return this._monto_exoneracion;
			}
			set
			{
				if ((this._monto_exoneracion != value))
				{
					this._monto_exoneracion = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_sta", DbType="Bit NOT NULL")]
		public bool sta
		{
			get
			{
				return this._sta;
			}
			set
			{
				if ((this._sta != value))
				{
					this._sta = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_observaciones", DbType="VarChar(50)")]
		public string observaciones
		{
			get
			{
				return this._observaciones;
			}
			set
			{
				if ((this._observaciones != value))
				{
					this._observaciones = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_con_tp_factura", DbType="TinyInt")]
		public System.Nullable<byte> con_tp_factura
		{
			get
			{
				return this._con_tp_factura;
			}
			set
			{
				if ((this._con_tp_factura != value))
				{
					this._con_tp_factura = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_preventa", DbType="Bit")]
		public System.Nullable<bool> preventa
		{
			get
			{
				return this._preventa;
			}
			set
			{
				if ((this._preventa != value))
				{
					this._preventa = value;
				}
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.CSM_FA_factura_detalle")]
	public partial class CSM_FA_factura_detalle
	{
		
		private string _guid_factura;
		
		private string _guid_articulo;
		
		private short _linea;
		
		private float _cantidad;
		
		private decimal _costo;
		
		private decimal _precio;
		
		private decimal _descuento;
		
		private decimal _impuesto;
		
		private byte _num_precio;
		
		private string _guid_orden_venta;
		
		public CSM_FA_factura_detalle()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_guid_factura", DbType="Char(10) NOT NULL", CanBeNull=false)]
		public string guid_factura
		{
			get
			{
				return this._guid_factura;
			}
			set
			{
				if ((this._guid_factura != value))
				{
					this._guid_factura = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_guid_articulo", DbType="Char(10) NOT NULL", CanBeNull=false)]
		public string guid_articulo
		{
			get
			{
				return this._guid_articulo;
			}
			set
			{
				if ((this._guid_articulo != value))
				{
					this._guid_articulo = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_linea", DbType="SmallInt NOT NULL")]
		public short linea
		{
			get
			{
				return this._linea;
			}
			set
			{
				if ((this._linea != value))
				{
					this._linea = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_cantidad", DbType="Real NOT NULL")]
		public float cantidad
		{
			get
			{
				return this._cantidad;
			}
			set
			{
				if ((this._cantidad != value))
				{
					this._cantidad = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_costo", DbType="Money NOT NULL")]
		public decimal costo
		{
			get
			{
				return this._costo;
			}
			set
			{
				if ((this._costo != value))
				{
					this._costo = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_precio", DbType="Money NOT NULL")]
		public decimal precio
		{
			get
			{
				return this._precio;
			}
			set
			{
				if ((this._precio != value))
				{
					this._precio = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_descuento", DbType="Money NOT NULL")]
		public decimal descuento
		{
			get
			{
				return this._descuento;
			}
			set
			{
				if ((this._descuento != value))
				{
					this._descuento = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_impuesto", DbType="Money NOT NULL")]
		public decimal impuesto
		{
			get
			{
				return this._impuesto;
			}
			set
			{
				if ((this._impuesto != value))
				{
					this._impuesto = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_num_precio", DbType="TinyInt NOT NULL")]
		public byte num_precio
		{
			get
			{
				return this._num_precio;
			}
			set
			{
				if ((this._num_precio != value))
				{
					this._num_precio = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_guid_orden_venta", DbType="Char(10)")]
		public string guid_orden_venta
		{
			get
			{
				return this._guid_orden_venta;
			}
			set
			{
				if ((this._guid_orden_venta != value))
				{
					this._guid_orden_venta = value;
				}
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.CSM_CC_TP_movimiento")]
	public partial class CSM_CC_TP_movimiento
	{
		
		private string _cod;
		
		private string _des;
		
		private string _cod_estatus;
		
		private double _porc;
		
		private int _dia;
		
		private string _consecutivo;
		
		private string _cod_debcred;
		
		private string _cod_asiento;
		
		public CSM_CC_TP_movimiento()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_cod", DbType="Char(4) NOT NULL", CanBeNull=false)]
		public string cod
		{
			get
			{
				return this._cod;
			}
			set
			{
				if ((this._cod != value))
				{
					this._cod = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_des", DbType="VarChar(40) NOT NULL", CanBeNull=false)]
		public string des
		{
			get
			{
				return this._des;
			}
			set
			{
				if ((this._des != value))
				{
					this._des = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_cod_estatus", DbType="Char(4) NOT NULL", CanBeNull=false)]
		public string cod_estatus
		{
			get
			{
				return this._cod_estatus;
			}
			set
			{
				if ((this._cod_estatus != value))
				{
					this._cod_estatus = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_porc", DbType="Float NOT NULL")]
		public double porc
		{
			get
			{
				return this._porc;
			}
			set
			{
				if ((this._porc != value))
				{
					this._porc = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_dia", DbType="Int NOT NULL")]
		public int dia
		{
			get
			{
				return this._dia;
			}
			set
			{
				if ((this._dia != value))
				{
					this._dia = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_consecutivo", DbType="Char(10) NOT NULL", CanBeNull=false)]
		public string consecutivo
		{
			get
			{
				return this._consecutivo;
			}
			set
			{
				if ((this._consecutivo != value))
				{
					this._consecutivo = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_cod_debcred", DbType="Char(4) NOT NULL", CanBeNull=false)]
		public string cod_debcred
		{
			get
			{
				return this._cod_debcred;
			}
			set
			{
				if ((this._cod_debcred != value))
				{
					this._cod_debcred = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_cod_asiento", DbType="Char(4) NOT NULL", CanBeNull=false)]
		public string cod_asiento
		{
			get
			{
				return this._cod_asiento;
			}
			set
			{
				if ((this._cod_asiento != value))
				{
					this._cod_asiento = value;
				}
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.CSM_IV_articulo")]
	public partial class CSM_IV_articulo
	{
		
		private string _guid;
		
		private char _con_inventario;
		
		private string _cdl_categoria;
		
		private string _cod;
		
		private string _idc_sub_familia;
		
		private string _estante;
		
		private string _casilla;
		
		private string _pasillo;
		
		private string _cdl_medida;
		
		private string _cdl_empaque;
		
		private string _cdl_impuesto;
		
		private string _des;
		
		private string _codigo_barra;
		
		private string _des_fabrica;
		
		private string _codigo_barra_fabrica;
		
		private bool _sta;
		
		private string _codigo_des;
		
		private string _des_clave;
		
		public CSM_IV_articulo()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_guid", DbType="Char(10) NOT NULL", CanBeNull=false)]
		public string guid
		{
			get
			{
				return this._guid;
			}
			set
			{
				if ((this._guid != value))
				{
					this._guid = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_con_inventario", DbType="Char(1) NOT NULL")]
		public char con_inventario
		{
			get
			{
				return this._con_inventario;
			}
			set
			{
				if ((this._con_inventario != value))
				{
					this._con_inventario = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_cdl_categoria", DbType="Char(2) NOT NULL", CanBeNull=false)]
		public string cdl_categoria
		{
			get
			{
				return this._cdl_categoria;
			}
			set
			{
				if ((this._cdl_categoria != value))
				{
					this._cdl_categoria = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_cod", DbType="Char(4) NOT NULL", CanBeNull=false)]
		public string cod
		{
			get
			{
				return this._cod;
			}
			set
			{
				if ((this._cod != value))
				{
					this._cod = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_idc_sub_familia", DbType="Char(3) NOT NULL", CanBeNull=false)]
		public string idc_sub_familia
		{
			get
			{
				return this._idc_sub_familia;
			}
			set
			{
				if ((this._idc_sub_familia != value))
				{
					this._idc_sub_familia = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_estante", DbType="Char(2) NOT NULL", CanBeNull=false)]
		public string estante
		{
			get
			{
				return this._estante;
			}
			set
			{
				if ((this._estante != value))
				{
					this._estante = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_casilla", DbType="Char(2) NOT NULL", CanBeNull=false)]
		public string casilla
		{
			get
			{
				return this._casilla;
			}
			set
			{
				if ((this._casilla != value))
				{
					this._casilla = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_pasillo", DbType="Char(2) NOT NULL", CanBeNull=false)]
		public string pasillo
		{
			get
			{
				return this._pasillo;
			}
			set
			{
				if ((this._pasillo != value))
				{
					this._pasillo = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_cdl_medida", DbType="Char(2) NOT NULL", CanBeNull=false)]
		public string cdl_medida
		{
			get
			{
				return this._cdl_medida;
			}
			set
			{
				if ((this._cdl_medida != value))
				{
					this._cdl_medida = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_cdl_empaque", DbType="Char(2) NOT NULL", CanBeNull=false)]
		public string cdl_empaque
		{
			get
			{
				return this._cdl_empaque;
			}
			set
			{
				if ((this._cdl_empaque != value))
				{
					this._cdl_empaque = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_cdl_impuesto", DbType="Char(2) NOT NULL", CanBeNull=false)]
		public string cdl_impuesto
		{
			get
			{
				return this._cdl_impuesto;
			}
			set
			{
				if ((this._cdl_impuesto != value))
				{
					this._cdl_impuesto = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_des", DbType="VarChar(70) NOT NULL", CanBeNull=false)]
		public string des
		{
			get
			{
				return this._des;
			}
			set
			{
				if ((this._des != value))
				{
					this._des = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_codigo_barra", DbType="VarChar(20) NOT NULL", CanBeNull=false)]
		public string codigo_barra
		{
			get
			{
				return this._codigo_barra;
			}
			set
			{
				if ((this._codigo_barra != value))
				{
					this._codigo_barra = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_des_fabrica", DbType="VarChar(15) NOT NULL", CanBeNull=false)]
		public string des_fabrica
		{
			get
			{
				return this._des_fabrica;
			}
			set
			{
				if ((this._des_fabrica != value))
				{
					this._des_fabrica = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_codigo_barra_fabrica", DbType="VarChar(20) NOT NULL", CanBeNull=false)]
		public string codigo_barra_fabrica
		{
			get
			{
				return this._codigo_barra_fabrica;
			}
			set
			{
				if ((this._codigo_barra_fabrica != value))
				{
					this._codigo_barra_fabrica = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_sta", DbType="Bit NOT NULL")]
		public bool sta
		{
			get
			{
				return this._sta;
			}
			set
			{
				if ((this._sta != value))
				{
					this._sta = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_codigo_des", DbType="VarChar(100)")]
		public string codigo_des
		{
			get
			{
				return this._codigo_des;
			}
			set
			{
				if ((this._codigo_des != value))
				{
					this._codigo_des = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_des_clave", DbType="VarChar(100)")]
		public string des_clave
		{
			get
			{
				return this._des_clave;
			}
			set
			{
				if ((this._des_clave != value))
				{
					this._des_clave = value;
				}
			}
		}
	}
}
#pragma warning restore 1591
