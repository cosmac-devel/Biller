using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Biller.classes
{
    public class Product
    {
        public CSM_IV_articulo getInvoiceDetail(string guid)
        {
            DataBaseDataContext db = new DataBaseDataContext();
            var document = (from e in db.CSM_IV_articulos
                            where e.guid == guid
                            select e).Single<CSM_IV_articulo>();
            return document;
        }
    }
}
