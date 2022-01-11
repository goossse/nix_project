using System.ComponentModel.DataAnnotations;
using DL.Models.Base;

namespace DL.Models
{
    public class Condition : BaseClass
    {
        [Required]
        [StringLength(2000,MinimumLength = 2)]
        public string Info { get; set; }

        [Required]
        public int RequestId { get; set; }
    }
}
