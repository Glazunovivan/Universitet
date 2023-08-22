using System.ComponentModel.DataAnnotations.Schema;

namespace UniversistetAPI.Models
{
    [Table("courseStudent")]

    public class CourseStudent : Entity
    {
        /// <summary>
        /// Идентификатор курса
        /// </summary>
        [Column("_id_course")]
        public int CourseId { get; set; }

        /// <summary>
        /// Идентификатор преподавателя
        /// </summary>
        [Column("_id_student")]
        public int StudentId { get; set; }

        public List<Course> Courses { get; set; }

        public List<Student> Students { get; set; }
    }
}
