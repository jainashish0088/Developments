using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAEntities
{
    public class State : CommonProperty
    {
        [Required, MaxLength(200)]
        public string Name { get; set; }
        public Country Country { get; set; }
        public IList<City> Cities { get; set; }
    }
}
