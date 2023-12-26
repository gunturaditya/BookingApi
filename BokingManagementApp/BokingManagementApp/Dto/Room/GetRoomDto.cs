using System.ComponentModel.DataAnnotations;

namespace BokingManagementApp.Dto.Room
{
    public class GetRoomDto
    {
        [Required]
        public Guid Guid { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public int Floor { get; set; }

        [Required]
        public int Capacity { get; set; }
    }
}
