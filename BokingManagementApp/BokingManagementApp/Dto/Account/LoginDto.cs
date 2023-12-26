using BokingManagementApp.Utilities;
using System.ComponentModel.DataAnnotations;

namespace BokingManagementApp.Dto.Account
{
    public class LoginDto
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [PasswordPolicy]
        public string Password { get; set; }
    }
}
