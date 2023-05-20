using System.ComponentModel.DataAnnotations;

namespace ProductBaseWebApplication.Models
{
    public class AddVM
    {
        public int Id { get; set; }
        [Required ]
        public string? Name { get; set; }
        [Required]
        public string? Color { get; set; }
        [Required]
        public int? Prices { get; set; }
    }
}
