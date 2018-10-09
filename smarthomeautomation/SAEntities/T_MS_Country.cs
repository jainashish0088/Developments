namespace SAEntities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class T_MS_Country
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public T_MS_Country()
        {
            T_MS_State = new HashSet<T_MS_State>();
        }

        [Key]
        public int CountryID { get; set; }

        [Required]
        [StringLength(800)]
        public string CountryName { get; set; }

        [StringLength(3)]
        public string CountryCode { get; set; }

        public bool IsActive { get; set; }

        public bool ISDeleted { get; set; }

        public DateTime CreatedDate { get; set; }

        public DateTime? UpdatedDate { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<T_MS_State> T_MS_State { get; set; }
    }
}
