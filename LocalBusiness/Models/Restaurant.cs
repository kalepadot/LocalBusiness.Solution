using System.ComponentModel.DataAnnotations;

namespace LocalBusiness.Models

{
    public class Restaurant
    {
        public int RestaurantId { get; set; }
        [Required]
        [StringLength(30)]
        public string Name { get; set; }
        [Required]
        public string Type { get; set; }
    }
}
