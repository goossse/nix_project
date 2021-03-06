using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using DL.Models.Base;

namespace DL.Models
{
    public class Service : BaseClass
    {
        [Required]
        [StringLength(30, MinimumLength = 2)]
        public string Title { get; set; }

        [Required]
        [StringLength(2000, MinimumLength = 2)]
        public string Info { get; set; }

        public int? UserId { get; set; }
        public User User { get; set; }
        public List<ServiceType> Types { get; set; }
        public List<Request> Requests { get; set; }
        public List<Price> PriceList { get; set; }
        public List<Review> Reviews { get; set; }
    }
}
