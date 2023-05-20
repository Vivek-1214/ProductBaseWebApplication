using ProductBaseWebApplication.DAL;
using System.ComponentModel.DataAnnotations;

namespace ProductBaseWebApplication.Models
{
    public class EditVM
    {
        public EditVM()
        {

        } 
        public EditVM(ProductList  product)
        {
            this.Id = product.Id;
            this.Name = product.Name;
            this.Color = product.Color;
            this.Prices = product.Prices;
        }
        public int? Id { get; set; }
        [Required]
        public string? Name { get; set; }
        [Required]
        public string? Color { get; set; }
        [Required]
        public int? Prices { get; set; }
    }
}
