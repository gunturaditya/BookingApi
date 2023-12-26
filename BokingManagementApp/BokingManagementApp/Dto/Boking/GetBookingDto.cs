﻿using BokingManagementApp.Utilities.Enum;

namespace BokingManagementApp.Dto.Boking
{
    public class GetBookingDto
    {
        public Guid Guid { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Remarks { get; set; }
        public StatusLevel Status { get; set; }
        public Guid RoomGuid { get; set; }
        public Guid EmployeeGuid { get; set; }
    }
}
