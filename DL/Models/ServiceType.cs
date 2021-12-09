using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace DL.Models
{
    public class ServiceType
    {
        [Required]
        public int ServiceTypeId { get; set; }

        [StringLength(15)]
        public string Name { get; set; }
        public List<Service> Services { get; set; }
    }
}
