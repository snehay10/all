using System.ComponentModel.DataAnnotations;

namespace MVC2.Models
{
    public class Actor
    {
        [Key]
        public int Id { get; set; }
        [Display(Name ="Profile Picture URL")]
        public String ProfilePictureURL { get; set; }
       
        [Display (Name ="Full Name")]
        public String FullName { get; set; }
        [Display(Name ="Biography")]
        public string Bio { get; set; }

        //Relationship

        public List <Actor_Movie> Actors_Movies { get; set; }
    }
}
