using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DL.Models
{
    public class User
    {
        public int UserId { get; set; }
        public string Name { get; set; }
        public string ContactDetails { get; set; }
        public List<Request> Requests{get;set;}
        public List<Service> Services { get; set; }
        public List<Review> Reviews { get; set; }
    }
}
