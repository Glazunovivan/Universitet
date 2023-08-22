using System.ComponentModel.DataAnnotations.Schema;


namespace UniversistetAPI.Models
{
    [Table("courses")]
    public class Course : Entity
    {
        private string _name;
        /// <summary>
        /// Название
        /// </summary>
        [Column("_name")]
        public string Name
        {
            get => _name;
            set
            {
                var result = char.ToUpper(value[0]) + value.Substring(1);
                _name = result.ToString();
               
            }
        }

        public List<Student> Students { get; set; }

        //список учителей
        public List<Teacher> Teachers { get; set; }
    }
}
