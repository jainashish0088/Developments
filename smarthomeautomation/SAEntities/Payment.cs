using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAEntities
{
    public class Payment : CommonProperty
    {
        public decimal Amount { get; set; }
        public IList<Order> Orders { get; set; }
        public IList<PaymentDetail> PaymentDetails { get; set; }
    }
}
