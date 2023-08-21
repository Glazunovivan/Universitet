using System.ComponentModel.DataAnnotations.Schema;

namespace UniversistetAPI.Models.Persons
{
    [Table("students")]
    public class Student : Person
    {
        public List<Course> Courses { get; set; }
    }
}
