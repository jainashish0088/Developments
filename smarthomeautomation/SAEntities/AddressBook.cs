using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAEntities
{
    public class AddressBook
    {
        [Key]
        public long Id { get; set; }
        [Required, ForeignKey("Customer")]
        public long CustomerId { get; set; }
        [Required, MaxLength(500)]
        public string Address1 { get; set; }
        [MaxLength(500)]
        public string Address2 { get; set; }
        [MaxLength(500)]
        public string Address3 { get; set; }
        [Required, MaxLength(20)]
        public string PostCode { get; set; }
        [Required, ForeignKey("City")]
        public int CityID { get; set; }
        [Required, DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public Customer Customer { get; set; }
    }
}
