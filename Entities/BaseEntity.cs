using System.ComponentModel.DataAnnotations;

namespace Entities
{
    public class BaseEntity
    {
        [Required]
        public int Id { get; set; }
    }
}
