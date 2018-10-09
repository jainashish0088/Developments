namespace SAEntities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class T_MS_State
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public T_MS_State()
        {
            T_MS_City = new HashSet<T_MS_City>();
        }

        [Key]
        public int StateID { get; set; }

        [Required]
        [StringLength(800)]
        public string StateName { get; set; }

        public int? CountryID { get; set; }

        public bool IsActive { get; set; }

        public bool ISDeleted { get; set; }

        public DateTime CreatedDate { get; set; }

        public DateTime? UpdatedDate { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<T_MS_City> T_MS_City { get; set; }

        public virtual T_MS_Country T_MS_Country { get; set; }
    }
}
