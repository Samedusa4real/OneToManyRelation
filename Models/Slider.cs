using System.ComponentModel.DataAnnotations;

using System.ComponentModel.DataAnnotations;

namespace EternaAgain.Models
{
    public class Slider
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(35)]
        public string Title1 { get; set; }
        [Required]
        [MaxLength(35)]
        public string Title2 { get; set; }
        [MaxLength(500)]
        public string Description { get; set; }
        [MaxLength(250)]
        public string BackgroundImg { get; set; }
        [MaxLength(250)]
        public string ButtonUrl { get; set; }
        public int Order { get; set; }
    }
}
