namespace lamlai_CAFE.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("STORE")]
    public partial class STORE
    {
        [Key]
        [StringLength(100)]
        public string MaterialID { get; set; }

        [StringLength(100)]
        public string NameMaterial { get; set; }

        public DateTime? RecivedDate { get; set; }

        public int? SupplierPrice { get; set; }

        [StringLength(100)]
        public string Unit { get; set; }

        public int? Quantity { get; set; }
    }
}
