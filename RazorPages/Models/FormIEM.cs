using System.ComponentModel.DataAnnotations;

namespace RazorPages.Models
{
    public class FormIEM
    {
        [Key]
        public int ID { get; set; }
        [MinLength(5), Required]
        public string Name { get; set; } = string.Empty;
        [EmailAddress, Required]
        public string Email { get; set; } = string.Empty;
        [MinLength(0)]
        public string? Message { get; set; } = string.Empty;
    }
}
