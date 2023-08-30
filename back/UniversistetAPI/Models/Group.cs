using System.ComponentModel.DataAnnotations.Schema;
using UniversistetAPI.Extessions;


namespace UniversistetAPI.Models
{
    [Table("groups")]
    public class Group : Entity
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
                _name = value.ToUpperFirstChar();
            }
        }

        public List<Student> Students { get; } = new();
        public List<GroupStudent> GroupStudents { get; } = new();

        //public List<Teacher> Teachers { get; } = new();
        public List<GroupTeacher> GroupTeachers { get; } = new();

    }
}