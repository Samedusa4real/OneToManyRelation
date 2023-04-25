using System.ComponentModel.DataAnnotations;

namespace EternaAgain.Models
{
    public class Category
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(35)]
        public string Name { get; set; }
    }
}
