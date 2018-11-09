using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAEntities
{
    public class Supplier
    {
        [Key]
        public long Id { get; set; }
        [Required, ForeignKey("Customer")]
        public long CustomerID { get; set; }
        [Required]
        public string CompanyName { get; set; }
        [Required, Index(IsUnique = true)]
        public string CompanyEmailID { get; set; }
        [Required, Index(IsUnique = true)]
        public string CompanyContactNumber { get; set; }
        public string CompanyFaxNumber { get; set; }
        public string GSTNumber { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }
        [Required, DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public IList<Product> Products { get; set; }

    }
}
