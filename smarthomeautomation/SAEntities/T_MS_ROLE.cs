namespace SAEntities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class T_MS_ROLE
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public T_MS_ROLE()
        {
            T_MS_USER_ROLE = new HashSet<T_MS_USER_ROLE>();
        }

        [Key]
        public int RoleID { get; set; }

        [Required]
        [StringLength(30)]
        public string RoleNAME { get; set; }

        [StringLength(200)]
        public string RoleDESC { get; set; }

        public bool ISActive { get; set; }

        public bool ISDeleted { get; set; }

        public DateTime CreatedDate { get; set; }

        public DateTime? UpdatedDate { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<T_MS_USER_ROLE> T_MS_USER_ROLE { get; set; }
    }
}
