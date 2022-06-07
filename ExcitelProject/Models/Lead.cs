using System.ComponentModel.DataAnnotations.Schema;

namespace ExcitelProject.Models
{
    public class Lead
    {
        public int LeadId { get; set; }

        string? Name { get; set; } = string.Empty;

        string? Address { get; set; } = string.Empty;

        string? MobileNumber { get; set; } = string.Empty;

        string? Email { get; set; } = string.Empty;

        [ForeignKey("SubareaId")]
        Subarea? Subarea { get; set; }

        public int SubareaId { get; set; } = 0;
    }
}
