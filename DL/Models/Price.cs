using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DL.Models
{
    public class Price
    {
        public int PriceId { get; set; }
        public string Currency { get; set; }
        public decimal Value { get; set; }
        public int ServiceId { get; set; }
    }
}
