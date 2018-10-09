namespace SAEntities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class T_MS_Coupon
    {
        [Key]
        public long CouponID { get; set; }

        [StringLength(200)]
        public string CouponName { get; set; }

        [StringLength(200)]
        public string CouponCode { get; set; }

        [StringLength(2000)]
        public string CouponDesc { get; set; }

        public DateTime? CouponStartDate { get; set; }

        public DateTime? CouponEndDate { get; set; }

        public bool IsActive { get; set; }

        public bool IsDeleted { get; set; }

        public DateTime CreatedDate { get; set; }

        public DateTime? UpdatedDate { get; set; }
    }
}
