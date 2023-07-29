using System.ComponentModel.DataAnnotations;

namespace firstCrud.Models
{
    public class product
    {
        public int Id { get; set; }
        [Required]
        public string ProductName { get; set; }
        [Required]
        public float Price { get; set; }
        [Required]
        public int Qty { get; set;}
    }
}
