using System.ComponentModel.DataAnnotations;

namespace registration.Model.authentication.SighUp
{
    public class RegisterUser
    {
        [Required(ErrorMessage ="Username required *")]
        
        public string UserName { get; set; }
        [EmailAddress]
        [Required(ErrorMessage = "email required *")]

        public string Email { get; set; }
        [Required(ErrorMessage = "password required *")]

        public string Password { get; set; }
    }
}
