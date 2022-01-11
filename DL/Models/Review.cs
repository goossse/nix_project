using System.ComponentModel.DataAnnotations;
using DL.Models.Base;

namespace DL.Models
{
    public class Review : BaseClass
    {
        [Required]
        [MaxLength(10)]
        [MinLength(1)]
        public int Rate { get; set; }

        [StringLength(2000, MinimumLength =2)]
        public string Text { get; set; }

        [Required]
        public string Info { get; set; }
        [Required]
        public int UserId { get; set; }
        [Required]
        public int ServiceId { get; set; }
    }
}
