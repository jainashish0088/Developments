using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAEntities
{
    public class ProductGallery
    {
        [Key]
        public long Id { get; set; }
        [Required, ForeignKey("Product")]
        public long ProductID { get; set; }
        [MaxLength(500)]
        public string GalleryName { get; set; }
        [MaxLength(2000)]
        public string GalleryDesc { get; set; }
        [MaxLength(2000)]
        public string GalleryImg { get; set; }
        public bool ShowOnListing { get; set; }
        public bool IsActive { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public Product Product { get; set; }
    }
}
