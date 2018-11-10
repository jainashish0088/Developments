using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAEntities
{
    public class OrderDetail
    {
        [Key]
        public long Id { get; set; }
        public long OrderId { get; set; }
        [ForeignKey("Product")]
        public long? ProductId { get; set; }
        [MaxLength(1000)]
        public string ProductName { get; set; }
        [MaxLength(200)]
        public string ProductCode { get; set; }
        public decimal SellingPrice { get; set; }
        public decimal MRP { get; set; }
        public decimal Discount { get; set; }
        public decimal Tax { get; set; }
        //public bool AllowReturn { get; set; }
        //public bool ReturnDuration { get; set; }
        //public bool CouponCode { get; set; }
        //public bool IsCancelled { get; set; }
        [Required, DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }

    }
}
