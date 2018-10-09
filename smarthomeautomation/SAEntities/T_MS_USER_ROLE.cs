namespace SAEntities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class T_MS_USER_ROLE
    {
        [Key]
        public long UserRoleID { get; set; }

        public long CustomerID { get; set; }

        public int RoleID { get; set; }

        public DateTime CreatedDate { get; set; }

        public DateTime? UpdatedDate { get; set; }

        public virtual T_CM_Customers T_CM_Customers { get; set; }

        public virtual T_MS_ROLE T_MS_ROLE { get; set; }
    }
}
