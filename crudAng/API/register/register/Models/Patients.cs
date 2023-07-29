namespace register.Models
{
    public class Patients
    {
        public int PatientId { get; set; }
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public String EMail { get; set; }
        public String BloodGroup { get; set; }
        public String Mobile { get; set; }
        public String Gender { get; set; }
        public String Pwd { get; set; }

        public DateTime creationDate { get; set; }
    }
}
