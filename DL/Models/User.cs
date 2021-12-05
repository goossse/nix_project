using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace nix_project.Models
{
    public class User
    {
        public int UserId { get; set; }
        public string Name { get; set; }
        public string ContactDetails { get; set; }
        public List<Request> Requests{get;set;}
        public List<Service> Services { get; set; }
    }
}
