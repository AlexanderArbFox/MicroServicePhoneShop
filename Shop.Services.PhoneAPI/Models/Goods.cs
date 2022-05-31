using System.ComponentModel.DataAnnotations;

namespace Shop.Services.PhoneAPI.Models
{
    public class Goods
    {
        [Key]
        public int GoodId { get; set; }

        [Required]
        public string Name { get; set; }
        
        [Required]
        public decimal Price { get; set; }

        public string Description { get; set; }

        public string CategoryName { get; set; }

        public string ImageUrl { get; set; }
    }
}
