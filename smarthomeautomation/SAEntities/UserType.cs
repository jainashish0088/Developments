using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAEntities
{
    public class UserType : CommonProperty
    {
        [Required, MaxLength(50)]
        public string Name { get; set; }
        [Required, MaxLength(200)]
        public string Desc { get; set; }
        public IList<Customer> Customers { get; set; }
        public IList<UserRoleRel> UserRoleRel { get; set; }
    }
}
