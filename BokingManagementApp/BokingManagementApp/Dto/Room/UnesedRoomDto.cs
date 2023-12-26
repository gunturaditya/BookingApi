using System.ComponentModel.DataAnnotations;

namespace BokingManagementApp.Dto.Room
{
    public class UnesedRoomDto
    {
        public Guid RoomGuid { get; set; }
        public string RoomName { get; set; }
        public int Floor { get; set; }
        public int Capacity { get; set; }
    }
}
