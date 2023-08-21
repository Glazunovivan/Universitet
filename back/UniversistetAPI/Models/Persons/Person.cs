using System.ComponentModel.DataAnnotations.Schema;

namespace UniversistetAPI.Models
{
    public class Person : Entity
    {
        /// <summary>
        /// Имя
        /// </summary>
        [Column("_name")]
        public string Name { get; set; }
        /// <summary>
        /// Фамилия
        /// </summary>
        [Column("_lastname")]
        public string Lastname { get; set; }
        /// <summary>
        /// Отчество
        /// </summary>
        [Column("_middlename")]
        public string Middlename { get; set; }
    }
}
 