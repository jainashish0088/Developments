namespace SAEntities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class T_MS_PaymentMode
    {
        [Key]
        public int PayModeID { get; set; }

        [Required]
        [StringLength(200)]
        public string PayName { get; set; }

        [StringLength(500)]
        public string PayDesc { get; set; }

        public bool IsActive { get; set; }

        public bool IsDeleted { get; set; }

        public DateTime CreatedDate { get; set; }

        public DateTime? UpdatedDate { get; set; }
    }
}
