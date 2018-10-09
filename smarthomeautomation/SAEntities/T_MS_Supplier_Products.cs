namespace SAEntities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class T_MS_Supplier_Products
    {
        [Key]
        public long SuppProductID { get; set; }

        public long ProductID { get; set; }

        [Required]
        [StringLength(200)]
        public string ProductCode { get; set; }

        [StringLength(2000)]
        public string ProductShortDesc { get; set; }

        [StringLength(5000)]
        public string ProductDesc { get; set; }

        public int Quantity { get; set; }

        public decimal SellingPrice { get; set; }

        public decimal Price { get; set; }

        public decimal Discount { get; set; }

        public decimal Tax { get; set; }

        public bool IsActive { get; set; }

        public bool IsDeleted { get; set; }

        public DateTime CreatedDate { get; set; }

        public DateTime? UpdatedDate { get; set; }

        public virtual T_MS_Products T_MS_Products { get; set; }
    }
}
