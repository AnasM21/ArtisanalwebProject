using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Artisanal_Services_ProductAPI.Models
{
    [Table("Products")]
    public class Product
    {
        
        [Key]
        public int ProductId { get; set; }
        [Required, StringLength(25)]
        public string Name { get; set; }

        [Range(1,1000)]
        public double Price { get; set; }

        public string Description { get; set; }

        public string CategoryName { get; set; }

        public string ImageURL { get; set; }

    }
}
