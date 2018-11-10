using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAEntities
{
    public class Customer
    {
        [Key]
        public long Id { get; set; }
        [ForeignKey("UserType")]
        public int UserTypeId { get; set; }
        [MaxLength(200)]
        public string FirstName { get; set; }
        [MaxLength(200)]
        public string MiddleName { get; set; }
        [MaxLength(200)]
        public string LastName { get; set; }
        public DateTime? DateofBirth { get; set; }
        [MaxLength(500)]
        [Index(IsUnique = true)]
        public string EmailID { get; set; }
        [MaxLength(200)]
        [Index(IsUnique = true)]
        public string MobileNo { get; set; }
        public bool IsActive { get; set; }
        public bool IsMobileVerified { get; set; }
        public bool IsEmailVerified { get; set; }
        [Required, DatabaseGenerated(DatabaseGeneratedOption.Computed)]
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public IList<AddressBook> AddressBooks { get; set; }
        
    }
}
