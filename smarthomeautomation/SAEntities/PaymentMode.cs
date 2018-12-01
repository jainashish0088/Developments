using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAEntities
{
    public class PaymentMode
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(200)]
        public string PayName { get; set; }
        [MaxLength(1000)]
        public string PayDesc { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }
        [Required, DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public IList<Order> Orders { get; set; }
    }
}
