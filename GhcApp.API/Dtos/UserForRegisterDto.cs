using System.ComponentModel.DataAnnotations;

namespace GhcApp.API.Dtos
{
    public class UserForRegisterDto
    {
        [Required]
        public string Username { get; set; }

        [Required]
        [StringLength(50, MinimumLength = 8, ErrorMessage = "Must specify password over 8 characters!")]
        public string Password { get; set; }
    }
}