namespace Hospital.models
{
    public class patient
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }

        public string BloodGroup { get; set; }

        public string Mobile { get; set; }

        public string Gender { get; set; }

        public string Pwd { get; set; }
        public DateTime registrationDate { get; set; }


    }
}
