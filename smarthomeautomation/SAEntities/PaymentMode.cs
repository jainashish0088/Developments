using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAEntities
{
    public class PaymentMode : CommonProperty
    {
        [MaxLength(200)]
        public string PayName { get; set; }
        [MaxLength(1000)]
        public string PayDesc { get; set; }
        public IList<Order> Orders { get; set; }
    }
}
