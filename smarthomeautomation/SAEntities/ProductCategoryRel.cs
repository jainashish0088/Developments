using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAEntities
{
    public class ProductCategoryRel
    {
        [Key]
        public long Id { get; set; }
        [Required, ForeignKey("Product")]
        public long ProductID { get; set; }
        [Required, ForeignKey("Category")]
        public long CategoryID { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }
        [Required, DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public IList<Product> Products { get; set; }
        public IList<Category> Categories { get; set; }
    }
}
