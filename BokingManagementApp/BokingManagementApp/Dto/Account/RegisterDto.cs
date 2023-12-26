﻿using BokingManagementApp.Utilities.Enum;
using BokingManagementApp.Utilities;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace BokingManagementApp.Dto.Account
{
    public class RegisterDto
    {
        [Required]
        public string FirstName { get; set; }
        public string? LastName { get; set; }

        [Required]
        public DateTime BirthDate { get; set; }

        [Required]
        [Range(0, 1, ErrorMessage = "0 = Female, 1 = Male")]
        public GenderEnum Gender { get; set; }

        [Required]
        public DateTime HiringDate { get; set; }

        [Required]
        [EmailAddress]
        [EmployeeDuplicateProperty("string", "Email")]
        public string Email { get; set; }

        [Phone]
        [EmployeeDuplicateProperty("string", "PhoneNumber")]
        public string Phone { get; set; }

        [Required]
        public string Major { get; set; }

        [Required]
        public string Degree { get; set; }

        [Required]
        [Range(0, 4, ErrorMessage = "Gpa From 0.0 - 4.0")]
        public Double Gpa { get; set; }
/*
        [Required]
        public string UniversityCode { get; set; }*/

        [Required]
        public string UniversityName { get; set; }

        [Required]
        [PasswordPolicy]
        public string Password { get; set; }

        [Required]
        [NotMapped]
        [Compare(nameof(Password), ErrorMessage = "Passwor Do not Match")]
        public string ConfirmPassword { get; set; }
    }
}
