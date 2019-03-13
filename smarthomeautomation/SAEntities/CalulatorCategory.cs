using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAEntities
{
    public class CalulatorCategory : CommonProperty
    {
        public CalulatorCategory()
        {
            Product = new HashSet<Product>();
        }
        public string Name { get; set; }
        public bool MustAddInList { get; set; }
        public virtual ICollection<Product> Product { get; set; }
    }
}
