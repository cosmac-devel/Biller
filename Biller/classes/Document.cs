using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Biller.classes
{
    public class Document
    {

        public CSM_FA_factura getInvoice(string guid)
        {
            DataBaseDataContext db = new DataBaseDataContext();
            CSM_FA_factura document = (from e in db.CSM_FA_facturas
                                       where e.guid.Equals(guid)
                                       select e).Single<CSM_FA_factura>();
            return document;
        }

        public List<CSM_FA_factura_detalle> getInvoiceDetail(string guid)
        {
            DataBaseDataContext db = new DataBaseDataContext();
            var document = (from e in db.CSM_FA_factura_detalles
                                       where e.guid_factura.Equals(guid)
                            select e).ToList<CSM_FA_factura_detalle>();
            return document;
        }
    }
}
