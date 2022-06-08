using ExcitelProject.Data;

namespace ExcitelProject.Models
{
    public class Subarea : IEntity
    {
        public int Id { get; set; }

        public string? Name { get; set; } = string.Empty;

        public int? PINCode { get; set; } = 0;
    }
}
