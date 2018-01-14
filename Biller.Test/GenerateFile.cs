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
            Biller.classes.Detail detail1 = new classes.Detail()
            {
                Linea_Aduana_FechaDoc = "Linea_Aduana_FechaDoc",
                Linea_Aduana_Nombre = "Linea_Aduana_Nombre",
                Linea_Aduana_NumDoc = "Linea_Aduana_NumDoc",
                Linea_Cantidad = 0,
                Linea_CuentaPredial_Numero = "Linea_CuentaPredial_Numero",
                Linea_Descripcion = "Linea_Descripcion",
                Linea_FraccionArancelaria = "Linea_FraccionArancelaria",
                Linea_Importe = 0,
                Linea_Notas = "Linea_Notas",
                Linea_PrecioUnitario = 0,
                Linea_Unidad = "Linea_Unidad"
            };

            Biller.classes.Detail detail2 = new classes.Detail()
            {
                Linea_Aduana_FechaDoc = "Linea_Aduana_FechaDoc",
                Linea_Aduana_Nombre = "Linea_Aduana_Nombre",
                Linea_Aduana_NumDoc = "Linea_Aduana_NumDoc",
                Linea_Cantidad = 0,
                Linea_CuentaPredial_Numero = "Linea_CuentaPredial_Numero",
                Linea_Descripcion = "Linea_Descripcion",
                Linea_FraccionArancelaria = "Linea_FraccionArancelaria",
                Linea_Importe = 0,
                Linea_Notas = "Linea_Notas",
                Linea_PrecioUnitario = 0,
                Linea_Unidad = "Linea_Unidad"
            };

            Biller.classes.Detail detail3 = new classes.Detail()
            {
                Linea_Aduana_FechaDoc = "Linea_Aduana_FechaDoc",
                Linea_Aduana_Nombre = "Linea_Aduana_Nombre",
                Linea_Aduana_NumDoc = "Linea_Aduana_NumDoc",
                Linea_Cantidad = 0,
                Linea_CuentaPredial_Numero = "Linea_CuentaPredial_Numero",
                Linea_Descripcion = "Linea_Descripcion",
                Linea_FraccionArancelaria = "Linea_FraccionArancelaria",
                Linea_Importe = 0,
                Linea_Notas = "Linea_Notas",
                Linea_PrecioUnitario = 0,
                Linea_Unidad = "Linea_Unidad"
            };


            Biller.classes.Header header = new classes.Header()
            {
                Folio = 0,
                Nombre_Emisor = "Nombre_Emisor",
                RFC_Emisor = "RFC_Emisor",
                Dom_Emisor_calle = "Dom_Emisor_calle",
                Dom_Emisor_noExterior = "Dom_Emisor_noExterior",
                Dom_Emisor_noInterior = "Dom_Emisor_noInterior",
                Dom_Emisor_colonia = "Dom_Emisor_colonia",
                Dom_Emisor_localidad = "Dom_Emisor_localidad",
                Dom_Emisor_referencia = "Dom_Emisor_referencia",
                Dom_Emisor_municipio = "Dom_Emisor_municipio",
                Dom_Emisor_estado = "Dom_Emisor_estado",
                Dom_Emisor_pais = "Dom_Emisor_pais",
                Dom_Emisor_codigoPostal = "Dom_Emisor_codigoPostal",
                Tel_Emisor = 0,
                Dom_Sucursal_calle = "Dom_Sucursal_calle",
                Dom_Sucursal_noExterior = "Dom_Sucursal_noExterior",
                Dom_Sucursal_noInterior = "Dom_Sucursal_noInterior",
                Dom_Sucursal_colonia = "Dom_Sucursal_colonia",
                Dom_Sucursal_localidad = "Dom_Sucursal_localidad",
                Dom_Sucursal_referencia = "Dom_Sucursal_referencia",
                Dom_Sucursal_municipio = "Dom_Sucursal_municipio",
                Dom_Sucursal_estado = "Dom_Sucursal_estado",
                Dom_Sucursal_pais = "Dom_Sucursal_pais",
                Dom_Sucursal_codigoPostal = "Dom_Sucursal_codigoPostal",
                Tel_Sucursal = "Tel_Sucursal",
                Version = "Version",
                Serie_Comprobante = "Serie_Comprobante",
                Numero_Aprobacion = "Numero_Aprobacion",
                FormaPago = "FormaPago",
                Fecha = "Fecha",
                Hora = "Hora",
                Dom_LugarExpide_calle = "Dom_LugarExpide_calle",
                Dom_LugarExpide_noExterior = "Dom_LugarExpide_noExterior",
                Dom_LugarExpide_noInterior = "Dom_LugarExpide_noInterior",
                Dom_LugarExpide_colonia = "Dom_LugarExpide_colonia",
                Dom_LugarExpide_localidad = "Dom_LugarExpide_localidad",
                Dom_LugarExpide_referencia = "Dom_LugarExpide_referencia",
                Dom_LugarExpide_municipio = "Dom_LugarExpide_municipio",
                Dom_LugarExpide_estado = "Dom_LugarExpide_estado",
                Dom_LugarExpide_pais = "Folio",
                Dom_LugarExpide_codigoPostal = "Dom_LugarExpide_codigoPostal",
                Nombre_Receptor = "Nombre_Receptor",
                RFC_Receptor = 0,
                Dom_Receptor_calle = "Dom_Receptor_calle",
                Dom_Receptor_noExterior = "Dom_Receptor_noExterior",
                Dom_Receptor_noInterior = "Dom_Receptor_noInterior",
                Dom_Receptor_colonia = "Dom_Receptor_colonia",
                Dom_Receptor_localidad = "Dom_Receptor_localidad",
                Dom_Receptor_referencia = "Dom_Receptor_referencia",
                Dom_Receptor_municipio = "Dom_Receptor_municipio",
                Dom_Receptor_estado = "Dom_Receptor_estado",
                Dom_Receptor_pais = "Dom_Receptor_pais",
                Dom_Receptor_codigoPostal = "Dom_Receptor_codigoPostal",
                Monto_SubTotal = 0,
                Monto_IVA = 0,
                Monto_Total = 0,
                Estado = 0,
                TipoCFD = "TipoCFD",
                Notas = "Notas",
                Notas02 = "Notas02",
                Notas03 = "Notas03",
                Detalles = new List<classes.Detail>()
            };

            header.Detalles.Add(detail1);
            header.Detalles.Add(detail2);
            header.Detalles.Add(detail3);

            string path = string.Format(@"c:\temp\{0}.txt", Guid.NewGuid().ToString("N"));
            if (!File.Exists(path))
            {
                File.WriteAllText(path, header.ToString());
            }

        }
    }
}
