using System.ComponentModel.DataAnnotations.Schema;

namespace UniversistetAPI.Models
{
    [Table("courseTeacher")]
    public class CourseTeacher
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

        /// <summary>
        /// Ссылка на курс
        /// </summary>
        [ForeignKey("_id_course")]
        public Course Course { get; set; }

        /// <summary>
        /// Ссылка на преподавателя
        /// </summary>
        [ForeignKey("_id_teacher")]
        public Teacher Teacher { get; set; }
    }
}
