﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAEntities
{
    public class Product
    {
        [Key]
        public long Id { get; set; }
        [Required, ForeignKey("Supplier")]
        public long SupplierID { get; set; }
        [MaxLength(1000)]
        public string ProductName { get; set; }
        [MaxLength(200)]
        public string ProductCode { get; set; }
        [MaxLength(2000)]
        public string ProductShortDesc { get; set; }
        [MaxLength(5000)]
        public string ProductDesc { get; set; }
        public int Quantity { get; set; }
        public decimal SellingPrice { get; set; }
        public decimal MRP { get; set; }
        public decimal Discount { get; set; }
        public decimal Tax { get; set; }
        public bool AllowReturn { get; set; }
        public int ReturnDuration { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }
        [Required, DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime CreatedDate { get; set; }//save GMT Time 0
        public DateTime? UpdatedDate { get; set; }//save GMT Time 0
        public short ISDiscOnPercOrValue { get; set; } //default -1
        public IList<ProductGallery> ProductGalleries { get; set; }
        public IList<ProductCategoryRel> ProductCategoryRels { get; set; }
        public Brand Brand { get; set; }
    }
}