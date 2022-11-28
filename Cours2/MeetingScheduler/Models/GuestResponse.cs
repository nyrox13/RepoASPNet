using System.ComponentModel.DataAnnotations;

namespace MeetingScheduler.Models
{
    public class GuestResponse
    {
        [Required(ErrorMessage = "SVP! Entrez voter nom")]
        public string? Nom { get; set; }

        [Required(ErrorMessage = "SVP! Entrez voter email")]
        [EmailAddress]
        public string? Email { get; set; }

        [Required(ErrorMessage = "SVP! Entrez voter téléphone")]
        public string? Telephone { get; set; }

        [Required(ErrorMessage = "Veuillez préciser si vous participerez")]
        public bool? Participera { get; set; }
    }
}
