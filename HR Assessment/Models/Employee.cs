namespace HR_Assessment.Models
{
    public class Employee
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Gender { get; set; }
        public string Position { get; set; }
        public string Address { get; set; }
        public DateTime HireDate { get; set; }
        public DateTime Birthday { get; set; }
        public string Note { get; set; }
    }
}
