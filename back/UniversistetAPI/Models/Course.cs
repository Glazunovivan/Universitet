using System.ComponentModel.DataAnnotations.Schema;


namespace UniversistetAPI.Models
{
    [Table("courses")]
    public class Course : Entity
    {
        /// <summary>
        /// Название
        /// </summary>
        [Column("_name")]
        public string Name { get; set; }
    }
}
