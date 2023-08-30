using System.ComponentModel.DataAnnotations.Schema;
using UniversistetAPI.Extessions;


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
                _name = value.ToUpperFirstChar();
            }
        }

        #region Инфо о курсе
        public CourseContent CourseContent { get; set; }
        public List<TopicCourse> TopicCourse { get; set; } = new();
        #endregion

        public List<Student> Students { get; } = new();
        public List<CourseStudent> CourseStudents { get; } = new();

        public List<Teacher> Teachers { get; set; } = new();
        public List<CourseTeacher> CourseTeachers { get; } = new();

    }
}
