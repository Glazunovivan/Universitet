namespace UniversistetAPI.Models
{
    public class Person : Entity
    {
        /// <summary>
        /// Имя
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// Фамилия
        /// </summary>
        public string Lastname { get; set; }
        /// <summary>
        /// Отчество
        /// </summary>
        public string Middlename { get; set; }
    }
}
