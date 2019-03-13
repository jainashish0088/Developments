using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAEntities
{
    public class CommonProperty
    {
        [Key]
        public long Id { get; set; }
        [Required, DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime CreatedDate { get; set; }//save GMT Time 0
        public DateTime? UpdatedDate { get; set; }//save GMT Time 0
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }
    }
}
