using System.ComponentModel.DataAnnotations;

namespace valentines.Models
{
    public class Candy
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Type { get; set; }
        [Required]
        public float Price { get; set; }

    }
}