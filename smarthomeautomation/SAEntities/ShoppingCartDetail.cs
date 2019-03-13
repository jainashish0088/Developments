using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAEntities
{
    public class ShoppingCartDetail : CommonProperty
    {
        public ShoppingCartDetail()
        {
            this.Products = new HashSet<Product>();
        }
        public long ShoppingCartId { get; set; }
        [MaxLength(1000)]
        public string ProductName { get; set; }
        [MaxLength(200)]
        public string ProductCode { get; set; }
        public decimal SellingPrice { get; set; }
        public decimal MRP { get; set; }
        public decimal Discount { get; set; }
        public decimal Tax { get; set; }
        public bool IsCancelled { get; set; }
        public ShoppingCart ShoppingCart { get; set; }
        public ICollection<Product> Products { get; set; }
    }
}
