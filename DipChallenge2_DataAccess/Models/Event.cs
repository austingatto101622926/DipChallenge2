using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DipChallenge2_DataAccess
{
    public class Event
    {
        public int EventID { get; set; }
        public DateTime EventDate { get; set; }
        public decimal Fee { get; set; }
        public int TourID { get; set; }
        public virtual ICollection<Booking> Bookings { get; set; }
        public virtual Tour Tour { get; set; }
    }
}
