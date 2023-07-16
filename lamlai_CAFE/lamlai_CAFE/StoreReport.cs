using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lamlai_CAFE
{
    internal class StoreReport
    {

        public string MaterialID { get; set; }
        public string NameMaterial { get; set; }
        public DateTime? RecivedDate { get; set; }
        public int? SupplierPrice { get; set; }
        public string Unit { get; set; }

        public int? Quantity { get; set; }
    }
}
