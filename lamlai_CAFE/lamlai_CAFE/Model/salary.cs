namespace lamlai_CAFE.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("salary")]
    public partial class salary
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(100)]
        public string UserName { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Type { get; set; }

        public int? WORKDAY { get; set; }

        public int? restday { get; set; }

        public double? wagelevel { get; set; }

        public double? bonus { get; set; }

        public double? punish { get; set; }

        public double? total { get; set; }

        public virtual ACCOUNT ACCOUNT { get; set; }
    }
}
