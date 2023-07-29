using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DbownDemo.Models
{
    public class UserDTO
    {
        [Required]
        public string Mobile { get; set;}
        public string Password { get; set; }
        public string Role { get; set; }

        public UserDTO(long mobile,string password,string role)

        {
            Mobile = mobile.ToString();
            Password = password;
            Role = role;
        }
        public UserDTO()
        {
            
        }
    }
}
