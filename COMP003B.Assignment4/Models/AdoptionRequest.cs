using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace COMP003B.Assignment4.Models
{
    
        public class AdoptionRequest
        {
            public int Id { get; set; }

            [Required]
            public string ApplicantName { get; set; }

            [Required]
            [EmailAddress]
            public string Email { get; set; }

            [Required]
            public string Phone { get; set; }

            [Required]
            public int CatId { get; set; }
        }
    }

