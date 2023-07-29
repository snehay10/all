using System.ComponentModel.DataAnnotations;

namespace firstCrud1.Models
{
    public class Product
    {
        public int Id { get; set; }
        [Required]
        public string ProductName { get; set; }
        [Required]
        public float Price { get; set; }
        [Required]
        public int Qty { get; set; }
    }
}
