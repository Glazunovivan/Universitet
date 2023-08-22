using System.ComponentModel.DataAnnotations.Schema;

namespace UniversistetAPI.Models
{
    [Table("students")]
    public class Student : Person
    {
        public List<Course> Courses { get; } = new();
        public List<CourseStudent> CourseStudent { get; } = new();
    }
}
