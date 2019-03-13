using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAPO
{
    public class GetProduct
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string CategoryName { get; set; }
        public string BrandName { get; set; }
        public List<SAPO.Brands> BrandIds { get; set; }
    }
    public class ProductsPro
    {
        public ProductsPro()
        {
            ProductGalleries = new List<ProductGallery>();
        }
        public long Id { get; set; }
        [MaxLength(1000)]
        public string ProductName { get; set; }

        [MaxLength(1000)]
        public string NameForCalculator { get; set; }
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
        
        public short ISDiscOnPercOrValue { get; set; } //default -1
        public List<ProductGallery> ProductGalleries { get; set; }
        //public ICollection<Category> Categories { get; set; }
        //public Supplier Supplier { get; set; }
        //public Brand Brand { get; set; }
        //public ICollection<OrderDetail> OrderDetails { get; set; }
        //public ICollection<ShoppingCartDetail> ShoppingCartDetails { get; set; }
    }
    public class ProductGallery
    {
        public long Id { get; set; }
        public long ProductID { get; set; }
        [MaxLength(500)]
        public string GalleryName { get; set; }
        [MaxLength(2000)]
        public string GalleryDesc { get; set; }
        [MaxLength(2000)]
        public string GalleryImg { get; set; }
        public bool ShowOnListing { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
    }
}
