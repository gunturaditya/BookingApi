using System.ComponentModel.DataAnnotations;

namespace BokingManagementApp.Dto.AccountRole
{
    public class NewAccountRoleDto
    {
        [Required]
        public Guid AccountGuid { get; set; }

        [Required]
        public Guid RoleGuid { get; set; }
    }
}
