namespace lamlai_CAFE.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("FOODCATEGORY")]
    public partial class FOODCATEGORY
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public FOODCATEGORY()
        {
            FOODs = new HashSet<FOOD>();
        }

        [Key]
        public int IDFOODCATEGORY { get; set; }

        [Required]
        [StringLength(100)]
        public string NAMECATEGORYFOOD { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FOOD> FOODs { get; set; }
    }
}
