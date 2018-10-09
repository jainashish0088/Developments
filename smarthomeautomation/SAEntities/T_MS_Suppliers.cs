namespace SAEntities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class T_MS_Suppliers
    {
        [Key]
        public long SupplierID { get; set; }

        public long CustomerID { get; set; }

        [Required]
        [StringLength(800)]
        public string CompanyName { get; set; }

        [Required]
        [StringLength(800)]
        public string CompanyEmailID { get; set; }

        [Required]
        [StringLength(200)]
        public string CompanyContactNumber { get; set; }

        [StringLength(200)]
        public string CompanyFaxNumber { get; set; }

        [StringLength(200)]
        public string GSTNumber { get; set; }

        public bool IsActive { get; set; }

        public bool IsDeleted { get; set; }

        public DateTime CreatedDate { get; set; }

        public DateTime? UpdatedDate { get; set; }

        public virtual T_CM_Customers T_CM_Customers { get; set; }
    }
}
