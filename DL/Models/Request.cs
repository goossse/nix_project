using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using DL.Models.Base;

namespace DL.Models
{
    public class Request : BaseClass
    {

        [StringLength(2000, MinimumLength = 2)]
        public string Description { get; set; }

        [Required]
        public DateTime DateTimeOfCreating { get; set; }
        [Required]
        public DateTime StartOfBooking { get; set; }
        [Required]
        public DateTime EndOfBooking { get; set; }

        public int? UserId { get; set; }
        public User User { get; set; }

        [Required]
        public int? ServiceId { get; set; }
        public Service Service { get; set; }
        public List<Condition> Conditions { get; set; }
    }
}
