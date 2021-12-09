using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace DL.Models
{
    public class User
    {
        [Required]
        public int UserId { get; set; }

        [Required]
        [StringLength(15)]
        public string Name { get; set; }

        [Required]
        [StringLength(30)]
        public string ContactDetails { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        public List<Request> Requests{get;set;}
        public List<Service> Services { get; set; }
        public List<Review> Reviews { get; set; }
    }
}
