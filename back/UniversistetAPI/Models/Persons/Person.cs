using System.ComponentModel.DataAnnotations.Schema;
using UniversistetAPI.Extessions;

namespace UniversistetAPI.Models
{
    public class Person : Entity
    {
        private string _name;
        private string _lastName;
        private string _middleName;

        /// <summary>
        /// Имя
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
        /// <summary>
        /// Фамилия
        /// </summary>
        [Column("_lastname")]
        public string Lastname
        {
            get => _lastName;
            set
            {
                _lastName = value.ToUpperFirstChar();
            }
        }
        /// <summary>
        /// Отчество
        /// </summary>
        [Column("_middlename")]
        public string Middlename
        {
            get => _middleName;
            set
            {
                _middleName = value.ToUpperFirstChar();
            }
        }
    }
}
 