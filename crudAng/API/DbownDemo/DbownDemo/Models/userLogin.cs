using System.ComponentModel.DataAnnotations;

namespace DbownDemo.Models
{
    public class userLogin
    {
        [Required]
        public string mobile { get; set; }
        public string password { get; set; }
    }
}
