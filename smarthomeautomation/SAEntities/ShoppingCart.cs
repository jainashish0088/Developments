using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAEntities
{
    public class ShoppingCart
    {
        [Key]
        public long Id { get; set; }
        [ForeignKey("Customer")]
        public long CustomerId { get; set; }
        [Required, DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public IList<ShoppingCartDetail> ShoppingCartDetails { get; set; }
    }
}
