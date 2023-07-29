using System.ComponentModel.DataAnnotations;

namespace Patient.Model
{
    public class login
    {
        [Required]

        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
