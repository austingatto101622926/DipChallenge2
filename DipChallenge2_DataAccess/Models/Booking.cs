using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DipChallenge2_DataAccess
{
    public class Booking
    {
        public decimal Payment { get; set; }
        public DateTime? DateBooked { get; set; }
        public int ClientID { get; set; }
        public int EventID { get; set; }
        public virtual Client Client { get; set; }
        public virtual Event Event { get; set; }
    }
}
