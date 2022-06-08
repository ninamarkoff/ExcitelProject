using ExcitelProject.Data;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExcitelProject.Models
{
    public class Lead : IEntity
    {
        public int Id { get; set; }

        public string? Name { get; set; } = string.Empty;

        public string? Address { get; set; } = string.Empty;

        public string? MobileNumber { get; set; } = string.Empty;

        public string? Email { get; set; } = string.Empty;        

        [Display(Name = "Subarea")]
        public virtual int SubareaId { get; set; }

        [ForeignKey("SubareaId")]
        public virtual Subarea? Subarea { get; set; }
    }
}
