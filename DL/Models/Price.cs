using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace DL.Models
{
    public class Price
    {
        [Required]
        public int PriceId { get; set; }

        [Required]
        [StringLength(20)]
        public string Currency { get; set; }

        [Required]
        [MinLength(0)]
        [MaxLength(10000)]
        public decimal Value { get; set; }

        [Required]
        public int ServiceId { get; set; }
    }
}
