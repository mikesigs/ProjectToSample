using System.ComponentModel.DataAnnotations;

namespace ProjectToSample
{
    public class Child
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public bool Disowned { get; set; }
    }
}