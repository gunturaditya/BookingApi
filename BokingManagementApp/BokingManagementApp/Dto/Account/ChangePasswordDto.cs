using BokingManagementApp.Utilities;
using System.ComponentModel.DataAnnotations;

namespace BokingManagementApp.Dto.Account
{
    public class ChangePasswordDto
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        public int Otp { get; set; }

        [Required]
        [PasswordPolicy]
        public string NewPassword { get; set; }

        [Required(ErrorMessage = "Password Not Match")]
        [Compare("NewPassword")]
        public string ConfirmPassword { get; set; }
    }
}
