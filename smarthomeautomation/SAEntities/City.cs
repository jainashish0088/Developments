using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAEntities
{
    public class City:CommonProperty
    {
        [Required,MaxLength(200)]
        public string Name { get; set; }
        public State State { get; set; }
        public IList<AddressBook> AddressBooks { get; set; }
    }
}
