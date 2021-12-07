using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DL.Models
{ 
    public class Service
    {
        public int ServiceId { get; set; }
        public string Title { get; set; }
        public string Info { get; set; }
        public int UserId { get; set; }
        public List<ServiceType> Types { get; set; }
        public List<Request> Requests { get; set; }
        public List<Price> PriceList { get; set; }
        public List<Review> Reviews { get; set; }
    }
}
