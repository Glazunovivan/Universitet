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

        public Course Course { get; set; }

        public Teacher Teacher { get; set; }
    }
}
