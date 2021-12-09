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
        [StringLength(15)]
        public string Title { get; set; }

        [Required]
        [StringLength(200)]
        public string Info { get; set; }

        [Required]
        public int UserId { get; set; }
        public List<ServiceType> Types { get; set; }
        public List<Request> Requests { get; set; }
        public List<Price> PriceList { get; set; }
        public List<Review> Reviews { get; set; }
    }
}
