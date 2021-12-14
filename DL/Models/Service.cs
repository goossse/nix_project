using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace DL.Models
{ 
    public class Service
    {
        [Required]
        public int ServiceId { get; set; }

        [Required]
        [StringLength(30, MinimumLength =2)]
        public string Title { get; set; }

        [Required]
        [StringLength(2000, MinimumLength =2)]
        public string Info { get; set; }

        [Required]
        public int UserId { get; set; }
        public List<ServiceType> Types { get; set; }
        public List<Request> Requests { get; set; }
        public List<Price> PriceList { get; set; }
        public List<Review> Reviews { get; set; }
    }
}
