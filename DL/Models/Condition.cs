using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace DL.Models
{
    public class Condition
    {
        [Required]
        public int ConditionId { get; set; }

        [Required]
        [StringLength(2000,MinimumLength =2)]
        public string Info { get; set; }

        [Required]
        public int RequestId { get; set; }
    }
}
