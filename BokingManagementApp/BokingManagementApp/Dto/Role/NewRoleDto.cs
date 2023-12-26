using System.ComponentModel.DataAnnotations;

namespace BokingManagementApp.Dto.Role
{
    public class NewRoleDto
    {
        [Required]
        public string Name { get; set; }
    }
}
