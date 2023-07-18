using System.ComponentModel.DataAnnotations;

namespace Entities
{
    public class Comment: BaseEntity
    {
        [Required]
        public int Post_Id { get; set; }
        [Required]
        public string Name { get; set; } = string.Empty;

        [Required]
        [EmailAddress]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; } = string.Empty;

        [Required]
        public string Body { get; set; } = string.Empty;
    }
}
