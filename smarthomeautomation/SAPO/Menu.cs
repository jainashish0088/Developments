using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAPO
{
    public class MenuRequest
    {
        public int? Id { get; set; }
        public bool IsShowOnCalculator { get; set; }
        public string Name { get; set; }
    }

    public class Category
    {
        public long Id { get; set; }
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
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }
        [Required]
        public long SequenceNumber { get; set; }
    }
}
