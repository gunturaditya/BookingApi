using System.ComponentModel.DataAnnotations;

namespace BokingManagementApp.Dto.Room
{
    public class NewRoomDto
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public int Floor { get; set; }

        [Required]
        public int Capacity { get; set; }
    }
}
