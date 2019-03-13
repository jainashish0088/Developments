using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAEntities
{
    public class ProductGallery : CommonProperty
    {
        [Required, ForeignKey("Product")]
        public long ProductID { get; set; }
        [MaxLength(500)]
        public string GalleryName { get; set; }
        [MaxLength(2000)]
        public string GalleryDesc { get; set; }
        [MaxLength(2000)]
        public string GalleryImg { get; set; }
        public bool ShowOnListing { get; set; }
        public Product Product { get; set; }
    }
}
