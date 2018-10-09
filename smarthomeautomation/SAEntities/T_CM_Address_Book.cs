namespace SAEntities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class T_CM_Address_Book
    {
        [Key]
        public long AddressBookID { get; set; }

        public long CustomerID { get; set; }

        [Required]
        [StringLength(500)]
        public string Address1 { get; set; }

        [StringLength(500)]
        public string Address2 { get; set; }

        [StringLength(500)]
        public string Address3 { get; set; }

        [Required]
        [StringLength(20)]
        public string PostCode { get; set; }

        public int CityID { get; set; }

        public bool IsActive { get; set; }

        public bool ISDeleted { get; set; }

        public DateTime CreatedDate { get; set; }

        public DateTime? UpdatedDate { get; set; }

        public virtual T_MS_City T_MS_City { get; set; }

        public virtual T_CM_Customers T_CM_Customers { get; set; }
    }
}
