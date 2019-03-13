using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAEntities
{
    public class Brand : CommonProperty
    {
        [MaxLength(200)]
        public string Name { get; set; }
        [MaxLength(2000)]
        public string Desc { get; set; }
        [MaxLength(200)]
        public string LargeImg { get; set; }
        [MaxLength(200)]
        public string SmallImg { get; set; }
        public IList<Product> Products { get; set; }
    }
}
