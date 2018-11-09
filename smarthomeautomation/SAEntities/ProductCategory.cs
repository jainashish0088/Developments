using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAEntities
{
    public class Category
    {
        [Key]
        public long Id { get; set; }
        [ForeignKey("ProductCategory")]
        public long ParentCategory { get; set; }
        [Required, MaxLength(2000)]
        public string Name { get; set; }
        [MaxLength(2000)]
        public string ShortDesc { get; set; }
        [MaxLength(5000)]
        public string Desc { get; set; }
        [MaxLength(2000)]
        public string MetaTitle { get; set; }
        [MaxLength(5000)]
        public string MetaDesc { get; set; }
        [MaxLength(5000)]
        public string MetaKeywords { get; set; }
        [MaxLength(5000)]
        public string SmallImg { get; set; }
        [MaxLength(5000)]
        public string LargeImg { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }
        [Required]
        public long SequenceNumber { get; set; }
        [Required, DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public IList<ProductCategoryRel> ProductCategoryRels { get; set; }
    }
}
