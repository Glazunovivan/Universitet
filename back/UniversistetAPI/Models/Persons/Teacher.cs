namespace UniversistetAPI.Models
{
    public class Teacher : Person
    {
        public List<Course> Courses { get; set; }
    }
}
