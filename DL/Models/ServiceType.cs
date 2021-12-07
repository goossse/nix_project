using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DL.Models
{
    public class ServiceType
    {
        public int ServiceTypeId { get; set; }
        public string Name { get; set; }
        public List<Service> Services { get; set; }
    }
}
