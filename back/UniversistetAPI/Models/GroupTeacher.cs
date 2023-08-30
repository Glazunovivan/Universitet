using System.ComponentModel.DataAnnotations.Schema;

namespace UniversistetAPI.Models
{
    [Table("groupTeacher")]
    public class GroupTeacher : Entity
    {
        /// <summary>
        /// Идентификатор курса
        /// </summary>
        [Column("_id_group")]
        public int GroupId { get; set; }

        /// <summary>
        /// Идентификатор преподавателя
        /// </summary>
        [Column("_id_teacher")]
        public int TeacherId { get; set; }

        public Group Group { get; set; }

        public Teacher Teacher { get; set; }
    }
}
