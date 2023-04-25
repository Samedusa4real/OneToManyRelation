﻿using System.ComponentModel.DataAnnotations;

namespace EternaAgain.Models
{
    public class Position
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
    }
}
