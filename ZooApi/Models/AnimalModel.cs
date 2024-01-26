using System.ComponentModel.DataAnnotations;

namespace ZooApi.Models
{
    public class AnimalModel
    {
        [Key]
        public int Id { get; set; }
        public string Species { get; set; } = null!;
        public string? Habitat { get; set; }
    }
}
