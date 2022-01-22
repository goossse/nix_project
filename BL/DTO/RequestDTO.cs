using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.DTO
{
    public class RequestDTO
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public DateTime DateTimeOfCreating { get; set; }
        public DateTime StartOfBooking { get; set; }
        public DateTime EndOfBooking { get; set; }
        public int UserId { get; set; }
        public int ServiceId { get; set; }

    }
}
