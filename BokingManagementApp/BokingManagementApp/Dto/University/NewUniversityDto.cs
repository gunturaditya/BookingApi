using System.ComponentModel.DataAnnotations;

namespace BokingManagementApp.Dto.University
{
    public class NewUniversityDto
    {
        [Required]
        public string Code { get; set; }

        [Required]
        public string Name { get; set; }
    }
}
