using Microsoft.Extensions.Diagnostics.HealthChecks;
using System.ComponentModel.DataAnnotations;

namespace Exo_ASPMVC_01.Models
{

    public class ContactForm
    {
        [MinLength(3)]
        public string FirstName { get; set; }

        [MinLength(2)]
        public string LastName { get; set; }

        [Required, EmailAddress]
        public string Email { get; set; }

        [Required, Phone]
        public string Tel { get; set; }

        [Required,MaxLength(500)]
        public string Message { get; set; }

    }
}
