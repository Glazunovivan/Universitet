using System.ComponentModel.DataAnnotations.Schema;

namespace UniversistetAPI.Models
{
    [Table("courseContent")]
    public class CourseContent : Entity
    {
        [Column("_id_course")]
        public int CourseId { get; set; }

        public Course Course { get; set; }

        [Column("_description")]
        public string Description { get; set; }
    }
}
