using System.ComponentModel.DataAnnotations;

namespace EternaAgain.Models
{
    public class TeamMember
    {
        public int Id { get; set; }
        [Required]
        public int PositionId { get; set; }
        [Required]
        [MaxLength(50)]
        public string FullName { get; set; }
        [MaxLength(500)]
        public string Description { get; set; }
        [Required]
        [MaxLength(50)]
        public string BgImg { get; set; }
        public Position Position { get; set; }
    }
}
