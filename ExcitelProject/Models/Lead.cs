using System.ComponentModel.DataAnnotations.Schema;

namespace ExcitelProject.Models
{
    public class Lead
    {
        public int LeadId { get; set; }

        public string? Name { get; set; } = string.Empty;

        public string? Address { get; set; } = string.Empty;

        public string? MobileNumber { get; set; } = string.Empty;

        public string? Email { get; set; } = string.Empty;

        [ForeignKey("SubareaId")]
        public Subarea? Subarea { get; set; }

        public int SubareaId { get; set; } = 0;
    }
}
