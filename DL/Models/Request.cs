using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace nix_project.Models
{
    public class Request
    {
        public int RequestId { get; set; }
        public string Description { get; set; }
        public int UserId { get; set; }
        public int ServiceId { get; set; }
        public List<Condition> Conditions { get; set; }
    }
}
