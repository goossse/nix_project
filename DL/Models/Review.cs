using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace DL.Models
{
    public class Review
    {
        [Required]
        public int ReviewId { get; set; }

        [Required]
        [MaxLength(5)]
        [MinLength(1)]
        public int Rate { get; set; }

        [StringLength(200)]
        public string Text { get; set; }

        [Required]
        public string Info { get; set; }
        [Required]
        public int UserId { get; set; }
        [Required]
        public int ServiceId { get; set; }
    }
}
