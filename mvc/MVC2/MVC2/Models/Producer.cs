using System.ComponentModel.DataAnnotations;

namespace MVC2.Models
{
    public class Producer
    {
        [Key]
        public int Id { get; set; }
        [Display(Name =" Profile Picture")]
        public String ProfilePictureURL { get; set; }
        [Display(Name = " Full Name")]
        public String FullName { get; set; }
        [Display(Name = " Biography")]
        public string Bio { get; set; }

        //Realtionship
        public List<Movie> Movies { get; set;}
    }
}
