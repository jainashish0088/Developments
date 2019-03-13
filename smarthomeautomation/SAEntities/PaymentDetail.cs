using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAEntities
{
    public class PaymentDetail : CommonProperty
    {
        public Payment Payment { get; set; }
        public decimal Amount { get; set; }
        public OrderDetail OrderDetail { get; set; }
        //public bool IsReturnRequested { get; set; }
        //public bool IsReturnProcessed { get; set; }
        //public bool IsReturnComplete { get; set; }
    }
}
