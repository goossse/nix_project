using System.ComponentModel.DataAnnotations;
using DL.Models.Base;

namespace DL.Models
{
    public class Price : BaseClass
    {
        [Valute]
        public string Currency { get; set; }

        [Required]
        public int Value { get; set; }

        [Required]
        public int ServiceId { get; set; }
    }
}
