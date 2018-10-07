using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAEntities
{
    public class T_CM_Customers
    {
        public long CustomerID { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string DateofBirth { get; set; }
        public string EmailID { get; set; }
        public string MobileNo { get; set; }
        public bool IsActive { get; set; }
        public bool IsMobileVerified { get; set; }
        public bool IsEmailVerified { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
    }
    public class T_MS_ROLE
    {
        public long RoleID { get; set; }
        public string RoleNAME { get; set; }
        public string RoleDESC { get; set; }
        public bool ISActive { get; set; }
        public bool ISDeleted { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }

    }
    public class T_MS_USER_ROLE
    {
        public long UserRoleID { get; set; }
        public IList<T_CM_Customers> CustomerID { get; set; }
        public IList<T_MS_ROLE> RoleID { get; set; }
        public bool ISActive { get; set; }
        public bool ISDeleted { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }

    }
}
