using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace cognitocoreapi.Models
{
    public class LoginModel
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string? Name { get; set; }

        [Required]
        [RegularExpression("^[a-zA-Z0-9_\\.-]+@([a-zA-Z0-9-]+\\.)+[a-zA-Z]{2,6}$", ErrorMessage = "E-mail is not valid")]
        public string? Email { get; set; }

        [Required]
        public string? Password { get; set; }

    }
}