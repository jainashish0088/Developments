using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAEntities
{
    public class Category : CommonProperty
    {
        public Category()
        {
            this.Products = new HashSet<Product>();
        }
        public long? CategoryId { get; set; }
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
        [Required]
        public long SequenceNumber { get; set; }
        public bool IsShowOnCalculator { get; set; } = false;
        public virtual ICollection<Product> Products { get; set; }
    }
}
