using System.ComponentModel.DataAnnotations;

namespace Entities
{
    public class Post: BaseEntity
    {
        [Required]
        public int User_Id { get; set; }
        [Required]
        public string Title { get; set; } = string.Empty;
        [Required]
        public string Body { get; set; } = string.Empty;
    }
}
