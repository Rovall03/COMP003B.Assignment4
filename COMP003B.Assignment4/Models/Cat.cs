using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace COMP003B.Assignment4.Models
{
    public class Cat
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        [Required]
        [Range(1, 20)]
        public int Age { get; set; }

        [Required]
        [StringLength(100)]
        public string Breed { get; set; }

        [StringLength(300)]
        public string Description { get; set; }

        // Instead of uploading, users provide an external image link
        [Required]
        [Url]
        public string ImageUrl { get; set; }
    }
}
