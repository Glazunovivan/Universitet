using System.ComponentModel.DataAnnotations.Schema;

namespace UniversistetAPI.Models
{
    [Table("courseStudent")]

    public class CourseStudent
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
        public int TeacherId { get; set; }

        /// <summary>
        /// Ссылка на курс
        /// </summary>
        [ForeignKey("_id_course")]
        public Course Course { get; set; }

        /// <summary>
        /// Ссылка на студента
        /// </summary>
        [ForeignKey("_id_student")]
        public Student Student { get; set; }
    }
}
