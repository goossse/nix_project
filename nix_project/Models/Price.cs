using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace nix_project.Models
{
    public class Price
    {
        public int PriceId { get; set; }
        public string Currency { get; set; }
        public decimal Value { get; set; }
        public int ServiceId { get; set; }
    }
}
