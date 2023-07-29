using System.ComponentModel.DataAnnotations;

namespace mvc_crud.Models
{
    public class emp
    {
        [Key]
        public int ID { get; set; }
        [Required]
        [Display(Name = "Employee Name")]
        public string Name { get; set; }
        public String Designation { get; set; }
        [DataType(DataType.MultilineText)]
        public String Address { get; set; }
        public DateTime? RecordCreatedOn { get; set; }

    }
}
