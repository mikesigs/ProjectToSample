using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ProjectToSample
{
    public class Parent
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public virtual ICollection<Child> Children { get; set; }
    }
}