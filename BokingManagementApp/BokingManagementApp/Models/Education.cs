﻿using BokingManagementApp.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace BokingManagementApp.Models
{
    [Table("tb_m_educations")]
    public class Education :BaseEntity
    {
        [Column("major", TypeName = "nvarchar(100)")]
        public string Major { get; set; }

        [Column("degree", TypeName = "nvarchar(10)")]
        public string Degree { get; set; }

        [Column("gpa")]
        public double Gpa { get; set; }

        [Column("university_guid")]
        public Guid UniversityGuid { get; set; }

        //Cardinalitas
        public University? University { get; set; }
        public Employee? Employee { get; set; }
    }
}
