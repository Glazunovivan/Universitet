using System.ComponentModel.DataAnnotations.Schema;

namespace UniversistetAPI.Models
{
    [Table("groupStudent")]
    public class GroupStudent : Entity
    {
        /// <summary>
        /// Идентификатор курса
        /// </summary>
        [Column("_id_group")]
        public int CourseId { get; set; }

        /// <summary>
        /// Идентификатор преподавателя
        /// </summary>
        [Column("_id_student")]
        public int StudentId { get; set; }

        public Group Group { get; set; }

        public Student Student { get; set; }
    }
}
