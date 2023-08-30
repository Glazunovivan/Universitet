using System.ComponentModel.DataAnnotations.Schema;

namespace UniversistetAPI.Models
{
    [Table("students")]
    public class Student : Person
    {
        [Column("_id_group")]
        public int? GroupId { get; set; } = null;

        public Group Group { get; set; } = null;


        public List<Course> Courses { get; } = new();
        public List<CourseStudent> CourseStudent { get; } = new();
    }
}
