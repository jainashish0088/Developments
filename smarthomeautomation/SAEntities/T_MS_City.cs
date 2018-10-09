namespace SAEntities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class T_MS_City
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public T_MS_City()
        {
            T_CM_Address_Book = new HashSet<T_CM_Address_Book>();
        }

        [Key]
        public int CityID { get; set; }

        [Required]
        [StringLength(800)]
        public string CityName { get; set; }

        public int StateID { get; set; }

        public bool IsActive { get; set; }

        public bool ISDeleted { get; set; }

        public DateTime CreatedDate { get; set; }

        public DateTime? UpdatedDate { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<T_CM_Address_Book> T_CM_Address_Book { get; set; }

        public virtual T_MS_State T_MS_State { get; set; }
    }
}
