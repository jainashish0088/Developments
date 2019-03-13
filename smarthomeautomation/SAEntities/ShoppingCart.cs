using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAEntities
{
    public class ShoppingCart : CommonProperty
    {
        public Customer Customer { get; set; }
        public IList<ShoppingCartDetail> ShoppingCartDetails { get; set; }
    }
}
