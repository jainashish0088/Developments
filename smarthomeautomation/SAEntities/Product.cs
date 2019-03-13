using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAEntities
{
    public class Product : CommonProperty
    {
        public Product()
        {
            this.CalulatorCategory = new HashSet<CalulatorCategory>();
            //this.ProductCategoryRels = new HashSet<ProductCategoryRel>();
            this.Categories = new HashSet<Category>();
            this.OrderDetails = new HashSet<OrderDetail>();
            this.ShoppingCartDetails = new HashSet<ShoppingCartDetail>();

        }
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
        public short ISDiscOnPercOrValue { get; set; } //default -1
        public IList<ProductGallery> ProductGalleries { get; set; }
        public ICollection<Category> Categories { get; set; }
        public ICollection<CalulatorCategory> CalulatorCategory { get; set; }
        public Supplier Supplier { get; set; }
        public Brand Brand { get; set; }
        public ICollection<OrderDetail> OrderDetails { get; set; }
        public ICollection<ShoppingCartDetail> ShoppingCartDetails { get; set; }
    }
}
