namespace SAEntities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class T_MS_Product_Category
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public T_MS_Product_Category()
        {
            T_MS_Product_Category1 = new HashSet<T_MS_Product_Category>();
        }

        [Key]
        public long CategoryID { get; set; }

        public long? ParentCategory { get; set; }

        [Required]
        [StringLength(2000)]
        public string CategoryName { get; set; }

        [StringLength(2000)]
        public string CategoryShortDesc { get; set; }

        [StringLength(5000)]
        public string CategoryDesc { get; set; }

        [StringLength(5000)]
        public string CategoryMetaTitle { get; set; }

        [StringLength(5000)]
        public string CategoryMetaDesc { get; set; }

        [StringLength(5000)]
        public string CategroyMetaKeywords { get; set; }

        public bool IsActive { get; set; }

        public bool IsDeleted { get; set; }

        public long SequenceNumber { get; set; }

        public DateTime CreatedDate { get; set; }

        public DateTime? UpdatedDate { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<T_MS_Product_Category> T_MS_Product_Category1 { get; set; }

        public virtual T_MS_Product_Category T_MS_Product_Category2 { get; set; }
    }
}
