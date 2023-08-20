using System.ComponentModel.DataAnnotations.Schema;

namespace UniversistetAPI.Models
{
    public class Entity
    {
        
        [Column("_id")]
        public int Id { get; set; }
    }
}
