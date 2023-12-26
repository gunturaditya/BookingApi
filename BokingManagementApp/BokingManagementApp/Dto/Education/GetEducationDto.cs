﻿using System.ComponentModel.DataAnnotations;

namespace BokingManagementApp.Dto.Education
{
    public class GetEducationDto
    {
        [Required]
        public Guid Guid { get; set; }

        [Required]
        public string Major { get; set; }

        [Required]
        public string Degree { get; set; }

        [Range(0, 4, ErrorMessage = "GPA Must Betwen 0 - 4")]
        public double Gpa { get; set; }

        [Required]
        public Guid UniversityGuid { get; set; }
    }
}
