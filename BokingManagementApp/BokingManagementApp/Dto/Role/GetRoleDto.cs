using System.ComponentModel.DataAnnotations;

namespace BokingManagementApp.Dto.Role
{
    public class GetRoleDto
    {
        [Required]
        public Guid Guid { get; set; }

        [Required]
        public string Name { get; set; }
    }
}
