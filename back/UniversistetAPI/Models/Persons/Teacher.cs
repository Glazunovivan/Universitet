using System.ComponentModel.DataAnnotations.Schema;

namespace UniversistetAPI.Models
{
    [Table("teachers")]
    public class Teacher : Person
    {
        public List<Course> Courses { get; } = new();
        public List<CourseTeacher> CourseTeacher { get; } = new();
        public List<GroupTeacher> GroupsTeacher { get; } = new();

    }
}
 