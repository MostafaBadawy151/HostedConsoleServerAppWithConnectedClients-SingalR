namespace MVCClientApp.Models
{
    public class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }

        public int DepartmentId { get; set; }
        public Department Department { get; set; }
    }
}
