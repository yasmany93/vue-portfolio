using System.ComponentModel.DataAnnotations;

namespace Entities
{
    public class User : BaseEntity
    {
        [Required]
        public string Name { get; set; } = string.Empty;

        [Required]
        [EmailAddress]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; } = string.Empty;

        [Required]
        public Gender Gender { get; set; }
        [Required]
        public Status Status { get; set; }
    }
}