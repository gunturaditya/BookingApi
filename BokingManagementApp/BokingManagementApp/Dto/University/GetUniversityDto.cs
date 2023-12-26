using System.ComponentModel.DataAnnotations;

namespace BokingManagementApp.Dto.University
{
    public class GetUniversityDto
    {
        [Required]
        public Guid Guid { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Code { get; set; }
    }
}
