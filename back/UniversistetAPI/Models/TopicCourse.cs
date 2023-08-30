using System.ComponentModel.DataAnnotations.Schema;

namespace UniversistetAPI.Models
{
    [Table("topicsCourse")]
    public class TopicCourse : Entity
    {
        [Column("_id_course")]
        public int CourseId { get; set; }

        public Course Course { get; set; }

        /// <summary>
        /// Номер темы
        /// </summary>
        [Column("_number")]
        public int Number { get; set; }

        /// <summary>
        /// Название темы
        /// </summary>
        [Column("_topic_name")]
        public string TopicName { get; set; }
    }
}
