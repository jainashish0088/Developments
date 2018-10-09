namespace SAEntities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class T_CM_Customers
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public T_CM_Customers()
        {
            T_CM_Address_Book = new HashSet<T_CM_Address_Book>();
            T_MS_Suppliers = new HashSet<T_MS_Suppliers>();
            T_MS_USER_ROLE = new HashSet<T_MS_USER_ROLE>();
        }

        [Key]
        public long CustomerID { get; set; }

        [Required]
        [StringLength(500)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(500)]
        public string MiddleName { get; set; }

        [Required]
        [StringLength(500)]
        public string LastName { get; set; }

        public DateTime? DateofBirth { get; set; }

        [Required]
        [StringLength(800)]
        public string EmailID { get; set; }

        [Required]
        [StringLength(200)]
        public string MobileNo { get; set; }

        public bool IsActive { get; set; }

        public bool IsMobileVerified { get; set; }

        public bool IsEmailVerified { get; set; }

        public DateTime CreatedDate { get; set; }

        public DateTime? UpdatedDate { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<T_CM_Address_Book> T_CM_Address_Book { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<T_MS_Suppliers> T_MS_Suppliers { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<T_MS_USER_ROLE> T_MS_USER_ROLE { get; set; }
    }
}
