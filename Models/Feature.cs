using System.ComponentModel.DataAnnotations;

namespace EternaAgain.Models
{
    public class Feature
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        public string Title { get; set; }
        [MaxLength(200)]
        public string Description { get; set; }
        [Required]
        [MaxLength(50)]
        public string Icon { get; set; }
    }
}
