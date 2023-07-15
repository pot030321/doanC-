namespace lamlai_CAFE.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BILLINFO")]
    public partial class BILLINFO
    {
        [Key]
        public int IDBILLINFO { get; set; }

        [Required]
        [StringLength(100)]
        public string USERNAME { get; set; }

        public int IDBILL { get; set; }

        public int IDFOOD { get; set; }

        public int COUNTFOOD { get; set; }

        public virtual ACCOUNT ACCOUNT { get; set; }

        public virtual BILL BILL { get; set; }

        public virtual FOOD FOOD { get; set; }
    }
}
