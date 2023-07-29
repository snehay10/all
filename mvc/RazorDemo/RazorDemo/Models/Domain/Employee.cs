namespace RazorDemo.Models.Domain
{
    public class Employee
    {
        public Guid id { get; set; }
        public String Name { get; set; }
        public string Email { get; set; }
        public long salary { get; set; }
        public DateTime DateOfBirth { get; set; }
        public String Department { get; set; }
    }
}
