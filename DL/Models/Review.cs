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

        [StringLength(2000, MinimumLength = 2)]
        public string Text { get; set; }

        [Required]
        public string Info { get; set; }
        public int? UserId { get; set; }
        public User User { get; set; }  
        [Required]
        public int? ServiceId { get; set; }
        public Service Service { get; set; }
    }
}
