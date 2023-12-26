﻿using BokingManagementApp.Utilities.Enum;
using System.ComponentModel.DataAnnotations;

namespace BokingManagementApp.Dto.Employee
{
    public class NewEmployeDto
    {
        [Required]
        public string FirstName { get; set; }
        public string LastName { get; set; }

        [Required]
        public DateTime BirthDate { get; set; }

        [Required]
        [Range(0, 1, ErrorMessage = "Required 0 or 1, 0 = Female, 1 = Male")]
        public GenderEnum Gender { get; set; }

        [Required]
        public DateTime HiringDate { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Phone]
        public string PhoneNumber { get; set; }
    }
}
