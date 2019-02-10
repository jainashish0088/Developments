using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAPO
{
    public class BrandInput
    {
        public string Name { get; set; }
    }
    public class Brands
    {
        public int Id { get; set; }
        [MaxLength(200)]
        public string Name { get; set; }
        [MaxLength(2000)]
        public string Desc { get; set; }
        [MaxLength(200)]
        public string LargeImg { get; set; }
        [MaxLength(200)]
        public string SmallImg { get; set; }
        public bool Selected { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
    }
}
