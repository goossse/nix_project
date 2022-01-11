using System.ComponentModel.DataAnnotations;
using DL.Models.Base;

namespace DL.Models
{
    public class ReviewCriteria : BaseClass
    {
        [Required]
        [StringLength(30, MinimumLength = 2)]
        public string Title { get; set; }
        [Required]
        [MaxLength(10)]
        [MinLength(1)]
        public int Rate { get; set; }
    }
}
