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

        [Valute]
        public string Currency { get; set; }

        [Required]
        public int Value { get; set; }

        [Required]
        public int ServiceId { get; set; }
    }
}
