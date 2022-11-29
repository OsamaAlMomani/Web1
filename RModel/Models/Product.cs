using IGames.DataInterface;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RModel.Models
{
    public class Product
    {
        
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string ISBN { get; set; }
        [Required]
        public string Author { get; set; }
        [Required]
        public string? Description { get; set; }
        [Required]
        public int CategoryId { get; set; }
        [ForeignKey("CategoryId")]
        public Category category_R { get; set; }
        [Required]
        [Range(0, 1000)]
        public double Price { get; set; }
        [Required]
        [Range(0, 1000)]
        public double Price50 { get; set; }
        [Required, Range(0, 1000)]
        public double Price100 { get; set; }
        public string ImageUrl { get; set; }
        [Required]
        public int CoverTypeID { get; set; }
        public CoverType coverType { get; set; }


    }
}
