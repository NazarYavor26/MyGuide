using System.ComponentModel.DataAnnotations;

namespace MyGuide.DAL.Entities
{
    public class City
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(150)]
        public string Name { get; set; }

        [Required]
        public string Description { get; set; }
    }
}
