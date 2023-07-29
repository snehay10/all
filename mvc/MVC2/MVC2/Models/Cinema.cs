using System.ComponentModel.DataAnnotations;
using System.Security.Principal;

namespace MVC2.Models
{
    public class Cinema
    {
        [Key]
        public  int Id { get; set; }
        [Display(Name =" Cinema Logo")]
        public String Logo { get; set; }
        [Display(Name = " Cinema Name")]
        public String Name { get; set; }
        [Display(Name = " Cinema Description")]
        public String Description { get; set; }

        //Relationship
        public List<Movie> Movies { get; set; }
    }
}
