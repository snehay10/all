using System.ComponentModel.DataAnnotations;

namespace cardsAPI.model
{
    public class stud
    {
        [Key]
        public Guid StudID { get; set; }
        public String StudName { get; set; }
        public String StudC { get; set; }
    }
}
