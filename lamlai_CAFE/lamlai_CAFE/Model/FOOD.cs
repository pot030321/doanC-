namespace lamlai_CAFE.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("FOOD")]
    public partial class FOOD
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public FOOD()
        {
            BILLINFOes = new HashSet<BILLINFO>();
        }

        [Key]
        public int IDFOOD { get; set; }

        [Required]
        [StringLength(100)]
        public string NAMEFOOD { get; set; }

        public int IDFOODCATEGORY { get; set; }

        public double PRICE { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BILLINFO> BILLINFOes { get; set; }

        public virtual FOODCATEGORY FOODCATEGORY { get; set; }
    }
}
