using System.ComponentModel.DataAnnotations.Schema;

namespace UniversistetAPI.Models
{
    [Table("courseTeacher")]
    public class CourseTeacher : Entity
    {
        /// <summary>
        /// Идентификатор курса
        /// </summary>
        [Column("_id_course")]
        public int CourseId { get; set; }

        /// <summary>
        /// Идентификатор преподавателя
        /// </summary>
        [Column("_id_teacher")]
        public int TeacherId { get; set; }

        public List<Course> Courses { get; set; }

        public List<Teacher> Teachers { get; set; }
    }
}
