using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
namespace IGames.DataInterface
{
    public class Category
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }
        [DisplayName("Order")]
        [Range(1,100, ErrorMessage="Cant Be Higher than 100")]
        public int DisplayOrder { get;set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;

    }
}
