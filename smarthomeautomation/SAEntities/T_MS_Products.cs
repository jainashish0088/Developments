namespace SAEntities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class T_MS_Products
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public T_MS_Products()
        {
            T_MS_Supplier_Products = new HashSet<T_MS_Supplier_Products>();
        }

        [Key]
        public long ProductID { get; set; }

        public long BrandID { get; set; }

        [Required]
        [StringLength(1000)]
        public string ProductName { get; set; }

        [StringLength(2000)]
        public string ProductShortDesc { get; set; }

        [StringLength(5000)]
        public string ProductDesc { get; set; }

        [StringLength(5000)]
        public string ProductMetaTitle { get; set; }

        [StringLength(5000)]
        public string ProductMetaDesc { get; set; }

        [StringLength(5000)]
        public string ProductMetaKeyword { get; set; }

        public int Quantity { get; set; }

        public bool IsActive { get; set; }

        public bool IsDeleted { get; set; }

        public DateTime CreatedDate { get; set; }

        public DateTime? UpdatedDate { get; set; }

        public virtual T_MS_Brands T_MS_Brands { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<T_MS_Supplier_Products> T_MS_Supplier_Products { get; set; }
    }
}
