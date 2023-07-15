namespace lamlai_CAFE.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BILL")]
    public partial class BILL
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BILL()
        {
            BILLINFOes = new HashSet<BILLINFO>();
        }

        [Key]
        public int IDBILL { get; set; }

        [Column(TypeName = "date")]
        public DateTime DATECHECKIN { get; set; }

        [Column(TypeName = "date")]
        public DateTime? DATECHECKOUT { get; set; }

        public int IDTABLEFOOD { get; set; }

        public int STATUS { get; set; }

        public virtual TABLEFOOD TABLEFOOD { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BILLINFO> BILLINFOes { get; set; }
    }
}
