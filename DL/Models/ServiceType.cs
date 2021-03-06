using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using DL.Models.Base;

namespace DL.Models
{
    public class ServiceType : BaseClass
    {
        [StringLength(30, MinimumLength = 2)]
        public string Name { get; set; }
        public List<Service> Services { get; set; }
    }
}
