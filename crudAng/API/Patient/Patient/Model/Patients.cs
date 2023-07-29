using System.ComponentModel.DataAnnotations;

namespace Patient.Model
{
    public class Patients
    {
        [Key]
        public int Id { get; set; }
        
        public string FirstName { get; set; }
        
        public string LastName { get; set; }
        [Required]

        public string Email { get; set; }
       
        public long Mobile { get; set; }
        
        public string  BloodGroup { get; set; }
        
        public string Gender { get; set; }
        [Required]
        public string  Password { get; set; }
        public string Token { get; set; }
    }
}
