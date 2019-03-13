using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAEntities
{
    public class Role : CommonProperty
    {
        [MaxLength(30)]
        public string Name { get; set; }
        [MaxLength(200)]
        public string Desc { get; set; }
        public IList<UserRoleRel> UserRoleRel { get; set; }
    }
}
