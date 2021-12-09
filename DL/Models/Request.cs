using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace DL.Models
{
    public class Request
    {
        [Required]
        public int RequestId { get; set; }

        [StringLength(200)]
        public string Description { get; set; }
        
        [Required]
        public int UserId { get; set; }

        [Required]
        public int ServiceId { get; set; }
        public List<Condition> Conditions { get; set; }
    }
}
