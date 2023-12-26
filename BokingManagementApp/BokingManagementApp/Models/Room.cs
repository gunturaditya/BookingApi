﻿using BokingManagementApp.Base;
using System.ComponentModel.DataAnnotations.Schema;

namespace BokingManagementApp.Models
{
    [Table("tb_m_rooms")]
    public class Room : BaseEntity
    {
        [Column("name", TypeName = "nvarchar(100)")]
        public string Name { get; set; }

        [Column("floor")]
        public int Floor { get; set; }

        [Column("capacity")]
        public int Capacity { get; set; }

        //cardinalitas
        public ICollection<Booking>? Bookings { get; set; }
    }
}
