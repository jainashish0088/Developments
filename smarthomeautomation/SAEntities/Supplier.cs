using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAEntities
{
    public class Supplier : CommonProperty
    {
        [Required]
        public string CompanyName { get; set; }
        [MaxLength(500)]
        [Required, Index(IsUnique = true)]
        public string EmailId { get; set; }
        [MaxLength(200)]
        [Required, Index(IsUnique = true)]
        public string ContactNumber { get; set; }
        public string CompanyFaxNumber { get; set; }
        public string GSTNumber { get; set; }
        public IList<Product> Products { get; set; }
        public IList<Customer> Customers { get; set; }

    }
}
