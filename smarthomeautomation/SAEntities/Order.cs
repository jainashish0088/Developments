using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAEntities
{
    public class Order : CommonProperty
    {
        public decimal TotalPrice { get; set; }
        public decimal TotalDiscount { get; set; }
        public decimal TotalTax { get; set; }
        public string OrderNumber { get; set; }
        public PaymentMode PaymentMode { get; set; }
        public Customer Customer { get; set; }
    }
}
